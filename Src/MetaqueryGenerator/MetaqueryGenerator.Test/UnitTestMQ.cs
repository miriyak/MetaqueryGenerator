using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MetaqueryGenerator.Test
{
    [TestClass]
    public class UnitTestMQ
    {
        [TestMethod]
        public void TestMethodRootMQ()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            Assert.AreEqual(rootMQ.ToString(), "R0(X1)←R1(X1)");
        }

        [TestMethod]
        public void TestMethodStringConstructor()
        {
            Metaquery metaquery = new Metaquery("R0(X1,X2)←R1(X1,X2)&R2(X1,X2)");
            Assert.AreEqual(metaquery.ToString(), "R0(X1,X2)←R1(X1,X2)&R2(X1,X2)");
        }
        

    }
}
