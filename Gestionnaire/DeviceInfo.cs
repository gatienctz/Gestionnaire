using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace Gestionnaire
{
    public class DeviceInfo
    {
        public DeviceInfo()
        {
            
        }

        public string GetDriveLetter(string serialNr)
        {
            return SelectDeviceInformation()
                .Single(a =>
                    a.pnpDeviceId.Remove(a.pnpDeviceId.Length - 2).Substring(a.pnpDeviceId.LastIndexOf('\\')).Replace("\\", "") ==(serialNr)).driveLetter;
        }

        private static IEnumerable<(string deviceId, string pnpDeviceId, string driveLetter)> SelectDeviceInformation()
        {
            foreach (ManagementObject device in SelectDevices())
            {
                var deviceId = (string)device.GetPropertyValue("DeviceID");
                var pnpDeviceId = (string)device.GetPropertyValue("PNPDeviceID");
                var driveLetter = (string)SelectPartitions(device).SelectMany(SelectDisks).Select(disk => disk["Name"]).Single();

                yield return (deviceId, pnpDeviceId, driveLetter);
            } 

            static IEnumerable<ManagementObject> SelectDevices() => new ManagementObjectSearcher(
                    @"SELECT * FROM Win32_DiskDrive WHERE InterfaceType LIKE 'USB%'").Get()
                .Cast<ManagementObject>();

            static IEnumerable<ManagementObject> SelectPartitions(ManagementObject device) => new ManagementObjectSearcher(
                    "ASSOCIATORS OF {Win32_DiskDrive.DeviceID=" +
                    "'" + device.Properties["DeviceID"].Value + "'} " +
                    "WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get()
                .Cast<ManagementObject>();

            static IEnumerable<ManagementObject> SelectDisks(ManagementObject partition) => new ManagementObjectSearcher(
                    "ASSOCIATORS OF {Win32_DiskPartition.DeviceID=" +
                    "'" + partition["DeviceID"] + "'" +
                    "} WHERE AssocClass = Win32_LogicalDiskToPartition").Get()
                .Cast<ManagementObject>();
        }
    }
    public struct USBDeviceInfo
    {
        public USBDeviceInfo(string deviceId, string SerialNr)
        {
            DeviceId = deviceId;
            this.SerialNr = SerialNr;
           
        }

        public string DeviceId { get; }

        public string SerialNr { get; }
        
        public char DriveLetter { get; }

        
        public override string ToString() => $"DeviceId: {DeviceId}; SerialNr: {SerialNr}; DriveLetter: {DriveLetter}";
    }
    
}