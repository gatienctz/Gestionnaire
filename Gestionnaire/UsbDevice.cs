/*
using System.Windows.Forms;
using System.ComponentModel;


namespace Gestionnaire
{
    public partial class UsbDevice : Form 
    {
        public UsbDevice()
        {
            InitializeComponent();
            
            var bgwDriveDetector = new BackgroundWorker();
            bgwDriveDetector.DoWork += bgwDriveDetector_DoWork;
            bgwDriveDetector.RunWorkerAsync();
            
        }
        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
            MessageBox.Show(driveName + " inserted");
        }
        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
             string driveName = e.NewEvent.Properties["DriveName"].Value.ToString();
             MessageBox.Show(driveName + " removed");
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
        
        private static USBDeviceInfo MapEventArgs(EventArrivedEventArgs e)
        {
             ManagementBaseObject instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
        
             string deviceId = (string)instance.GetPropertyValue("DeviceID");
             string serialNr = deviceId.Substring(deviceId.LastIndexOf('\\')).Replace("\\", "");
             char driveLetter = GetDriveLetter(serialNr).First();
        
             return new USBDeviceInfo(deviceId, serialNr, driveLetter);
        }

    }
}
*/
