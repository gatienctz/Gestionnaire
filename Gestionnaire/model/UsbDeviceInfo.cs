namespace Gestionnaire.model
{
    class UsbDeviceInfo
    {
        public UsbDeviceInfo(string deviceID, string pnpDeviceID, string description)
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