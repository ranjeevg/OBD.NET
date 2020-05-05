using System;

namespace Desktop_Driver.PortInfoQuery
{
    class PortInfoQuery
    {
        #region Constructors
        public PortInfoQuery() { }
        #endregion

        #region Fields
        private string COMPort;
        #endregion

        #region Methods
        private string GetCOMPort()
        {
            return this.COMPort;
        }

        private void SetCOMPort(string s)
        {
            this.COMPort = s;
        }

        private string DiscoverCOMPorts()
        {
            /*************************************************************************************
             * 
             *  My idea is to call System.IO.Ports.SerialPort.GetAvailablePorts() and 
             * somehow sort through the returned, non-null values to find the outgoing
             * Bluetooth port
             * 
             ************************************************************************************/
            throw new NotImplementedException();
        }

        private void NullifyCOMPort()
        {
            this.COMPort = String.Empty;
        }
        #endregion
    }
}
