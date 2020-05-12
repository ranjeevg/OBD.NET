using System;
using Desktop_Driver.PortInfoQuery;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class FindCOMPorts_Test_AssertFound
    {
        [TestMethod]
        public void COMPorts_Check()
        {
            // checking to see if the program returns the COM ports that I know to be 
            // available
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            Assert.AreEqual(PortInfoQuerier.DiscoverCOMPorts(), ports);
        }
    }
}
