using System;
using System.Windows;
#region as-yet-unneeded using statements
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
#endregion
#region oh, we're DEFINITELY going to be using these using statements
using ODB.NET.Desktop;
using OBD.NET.Common;
using Desktop_Driver.PortInfoQuery;
using ODB.NET.Desktop.Communication;
using OBD.NET.Common.Devices;
using ODB.NET.Desktop.Logging;
using OBD.NET.Common.Logging;
#endregion

namespace Desktop_Driver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // now we're getting to the good stuff
        private void ConnectBluetooth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SerialConnection connection = new SerialConnection(comPortList.Text))
                using (ELM327 dev = new ELM327(connection, new OBDConsoleLogger(OBDLogLevel.Debug)))
                {
                    // this is just a test to see if the method does anything so far
                    // Note to self: I need to plan out what the GUI looks like before deciding what to do 
                    // with the info gathered
                    MessageBox.Show("CONNECTED :D");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}