using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Management;

namespace Gestionnaire
{
    public class UsbDevice 
    {
        public UsbDevice()
        {
            var bgwDriveDetector = new BackgroundWorker();
            bgwDriveDetector.DoWork += bgwDriveDetector_DoWork;
            bgwDriveDetector.RunWorkerAsync();
            
        }
        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
            Console.WriteLine(driveName + " inserted");
        }
        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
             string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
             Console.WriteLine(driveName + " removed");
        }
        void bgwDriveDetector_DoWork(object sender, DoWorkEventArgs e)
        {
             var insertQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2");
             var insertWatcher = new ManagementEventWatcher(insertQuery);
             insertWatcher.EventArrived += DeviceInsertedEvent;
             insertWatcher.Start();
        
             var removeQuery = new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3");
             var removeWatcher = new ManagementEventWatcher(removeQuery);
             removeWatcher.EventArrived += DeviceRemovedEvent;
             removeWatcher.Start();
        }
        
        private static USBDeviceInfo1 MapEventArgs(EventArrivedEventArgs e)
        { 
             ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
        
             string deviceId = (string)instance.GetPropertyValue("DeviceID");
             string serialNr = deviceId.Substring(deviceId.LastIndexOf('\\')).Replace("\\", "");
             char driveLetter = DeviceInfo.GetDriveLetter(serialNr).First();
        
             return new USBDeviceInfo1(deviceId, serialNr, driveLetter);
        }

    }
}

