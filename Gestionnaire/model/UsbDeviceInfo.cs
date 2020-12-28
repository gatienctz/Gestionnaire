using System.IO;

namespace Gestionnaire.model
{
    using System;
    using System.Collections.Generic; 
    using System.Management;// need to add System.Management to your project references.

    class UsbDeviceInfoMain
    {
        public static void Test()
        {
            var usbDevices = GetUSBDevices();

            foreach (var usbDevice in usbDevices)
            {
                Console.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                    usbDevice.DeviceID, usbDevice.PnpDeviceID, usbDevice.Description);
            }

            var usbPath = getUSBPath();
            foreach (var usb in usbPath)
            {
                Console.WriteLine("Device : "+usb.Name+", Path : "+usb.RootDirectory);
            }

        }

        public static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub "))//WHERE Description = 'Dispositif de stockage de masse USB'"))
                collection = searcher.Get();      

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                    (string)device.GetPropertyValue("DeviceID"),
                    (string)device.GetPropertyValue("CurrentConfigValue"),
                    (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }
        
        public static List<DriveInfo> getUSBPath(){
            DriveInfo[] loadedDrives = DriveInfo.GetDrives();
            List<DriveInfo> deviceInfo = new List<DriveInfo>();

            foreach (DriveInfo ld in loadedDrives)
            {
                if (ld.DriveType == DriveType.Removable)
                {
                    if (ld.IsReady)
                    {             
                        deviceInfo.Add(ld);              
                    }
                }
            }

            return deviceInfo;
        }
        
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID.Replace('&', '_');
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            return "Device ID:" + DeviceID + " , PNP Device ID: " + PnpDeviceID + ", Description: " + Description;
        }
    }
}