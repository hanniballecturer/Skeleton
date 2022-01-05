using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            //some comments
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
    }
}
