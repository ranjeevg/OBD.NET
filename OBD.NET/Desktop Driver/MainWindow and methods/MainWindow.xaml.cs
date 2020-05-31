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
#endregion

namespace Desktop_Driver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            #region sizing
            //vb.Width = SystemParameters.WorkArea.Width;
            //vb.Height = SystemParameters.WorkArea.Height;
            #endregion

            #region establishing a Bluetooth connection
            
            string[] ports = PortInfoQuerier.DiscoverCOMPorts();

            #region should this even be in the constructor for the main class
            // if no ports found, display a message and close the window
            if (ports.Length == 0 || ports is null)
            {
                System.Threading.Thread.Sleep(1500);
                MessageBox.Show
                    ("No COM ports found, please check Bluetooth settings on your computer.");
                this.Close();
            }
            else
            {
                foreach (string port in ports)
                    comPortList.Items.Add(port);
            }
            #endregion // should this be in the MainWindow constructor

            #endregion // establishing a Bluetooth connection
        }
    }
}
