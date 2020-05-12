﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO.Ports;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ODB.NET.Desktop;
using OBD.NET.Common;
using Desktop_Driver.PortInfoQuery;

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
            PortInfoQuery.PortInfoQuery piq = new PortInfoQuery.PortInfoQuery();
            string[] ports = piq.DiscoverCOMPorts();

            // don't waste time if the array is null or empty
            if (!(ports.Length == 0 || ports is null))
            {
                foreach(string port in ports)
                {
                    comPortList.Items.Add(port);
                }
            }

            #region not implemented the rest
            throw new NotImplementedException();
            #endregion

            #endregion
        }
    }
}
