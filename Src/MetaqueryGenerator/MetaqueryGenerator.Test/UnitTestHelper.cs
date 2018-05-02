using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using System.Collections.Generic;
using MetaqueryGenerator.Common.Helpers;

namespace MetaqueryGenerator.Test
{
    [TestClass]
    public class UnitTestHelper
	{
        /// <summary>
        /// Unit test to check the Root Metaquery result
        /// </summary>
        [TestMethod]
        public void TestMethodMailHelperSend()
        {
			MailHelper.SendTextMailAsync(
				"Test Mail - 1", 
				"mail with attachment", 
				new List<string> { "genyakobi@gmail.com" }
				);

            Assert.AreEqual(true, true);
		}
		
        

    }
}
