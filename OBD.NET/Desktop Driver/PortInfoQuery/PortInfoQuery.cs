using System;
using System.IO.Ports;
using System.Runtime.InteropServices;

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

        private string[] DiscoverCOMPorts()
        {
            /*************************************************************************************
             * 
             *  
             * 
             ************************************************************************************/

            string[] DiscoveredCOMPorts = null;
            // trying to 
            try
            {
                DiscoveredCOMPorts = SerialPort.GetPortNames();
                if (DiscoveredCOMPorts.Length == 0)
                    System.Windows.MessageBox.Show("No COM ports found, please check Bluetooth settings.");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            return DiscoveredCOMPorts;

            //#region Not Implemented Exception
            //// this is a really neat feature, BTW. I wonder if C++ and Java have similar features
            //throw new NotImplementedException();
            //#endregion
        }

        private void NullifyCOMPort()
        {
            this.COMPort = String.Empty;
        }
        #endregion
    }
}
