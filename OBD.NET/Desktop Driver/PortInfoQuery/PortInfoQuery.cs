using System;

namespace Desktop_Driver.PortInfoQuery
{
    public static class PortInfoQuerier
    {
        public static string[] DiscoverCOMPorts()
        {
            /***********************************************************************************************
             *  Description:
             *      This method tries to find all available COM ports to connect. If no COM ports are 
             *      found, it shows a message asking the user to check Bluetooth settings. If an exception
             *      is caught, this method shows a message with the exception message.
             *      
             *  Input:
             *      None
             *      
             *  Output:
             *      A string[] where each element is a COM port.
             *      
             *  Assumptions:
             *      None (We're catching any exceptions, and checking to see if DiscoverCOMPorts is null)
             *  
             *  To Work On: 
             *      Try to filter through the selected COM ports and select only Bluetooth ports.
             *      
             *  Note to self: 
             *      On my computer, this method should return a 1-element string[] with the element of 
             *      "COM5".
             * 
             **********************************************************************************************/

            string[] DiscoveredCOMPorts = null;
            // trying to 
            try
            {
                DiscoveredCOMPorts = System.IO.Ports.SerialPort.GetPortNames();
                if (DiscoveredCOMPorts.Length == 0)
                {
                    System.Threading.Thread.Sleep(1500);
                    System.Windows.MessageBox.Show
                        ("No COM ports found, please check Bluetooth settings on your computer.");
                }
            }
            catch (Exception ex)
            {
                System.Threading.Thread.Sleep(1500);
                System.Windows.MessageBox.Show(ex.Message);
            }
            // note: this string[] is null if no COM ports are found, so no issues there
            return DiscoveredCOMPorts;
        }
    }
}
