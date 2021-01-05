using System;
using System.Collections.Generic;
using System.IO;
using System.Management;// need to add System.Management to your project references.

namespace Gestionnaire.model
{
    class UsbDevice
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

        public static List<UsbDeviceInfo> GetUSBDevices()
        {
            List<UsbDeviceInfo> devices = new List<UsbDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub "))//WHERE Description = 'Dispositif de stockage de masse USB'"))
                collection = searcher.Get();      

            foreach (var device in collection)
            {
                devices.Add(new UsbDeviceInfo(
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
}