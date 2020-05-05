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
        private string getCOMPort()
        {
            return this.COMPort;
        }

        private void setCOMPort(string s)
        {
            this.COMPort = s;
        }

        private void nullCOMPort()
        {
            this.COMPort = String.Empty;
        }

        private string discoverCOMPort()
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
        #endregion
    }
}
