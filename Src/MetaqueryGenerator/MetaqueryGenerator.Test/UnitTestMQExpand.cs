using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MetaqueryGenerator.Test
{
    [TestClass]
    public class UnitTestMQExpand
    {

        #region Expand Head - Add Variable
        /// <summary>
        /// Unit test to check the Expand Head - Add Variable on the root query
        /// </summary>
        [TestMethod]
        public void TestMethod_Expand_HeadRoot()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            Assert.AreEqual(rootMQ.ExpandHead().Count, 0);
        }
        /// <summary>
        /// Unit test to check the Expand Head - Add Variable on some query
        /// </summary>
        [TestMethod]
        public void TestMethod_Expand_HeadTo1()
        {
            Metaquery metaquery = new Metaquery("R0(1)←R1(1,2)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult.Count, 1);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2)");
        }
        /// <summary>
        /// Unit test to check the Expand Head - Add Variable on another query
        /// </summary>
        [TestMethod]
        public void TestMethod_Expand_HeadTo2()
        {
            Metaquery metaquery = new Metaquery("R(1)←R1(1,2)&R2(3)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult.Count, 2);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2)&R2(X3)");
            Assert.AreEqual(listResult[1].ToString(), "R0(X1,X3)←R1(X1,X2)&R2(X3)");
        }


        #endregion Expand Head - Add Variable

        #region Expand Body - Add Relation
        /// <summary>
        /// Unit test to check the Expand Head - Expand Body - Add Relation
        /// </summary>
        [TestMethod]
        public void TestMethod_Expand_BodyRelationRoot()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            List<Metaquery> listResult = rootMQ.ExpandBodyRelation();
            Assert.AreEqual(listResult.Count, 2);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1)←R1(X1)&R2(X1)");
            Assert.AreEqual(listResult[1].ToString(), "R0(X1)←R1(X1)&R2(X2)");
        }

        #endregion Expand Body - Add Relation

        #region Expand Body - Add Variable
        /// <summary>
        /// Unit test to check the Expand Head - Expand Body - Add Variable
        /// </summary>
        [TestMethod]
        public void TestMethod_Expand_BodyVariableRoot()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            //mtodo
            List<Metaquery> listResult = rootMQ.ExpandBodyVariable(5);
            Assert.AreEqual(listResult.Count, 1);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1)←R1(X1,X2)");
        }

        #endregion Expand Body - Add Variable

        #region Expand - All
        [TestMethod]
        /// <summary>
        /// Unit test to check the Expand Head - Expand All
        /// </summary>
        public void TestMethod_Expand_RootTo3Level()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            //mtodo
            List<Metaquery> listResultLevel2 = rootMQ.Expand(5,ExpandType.All);

            List<Metaquery> listResultLevel3 = new List<Metaquery>();
            int[] cnt = new int[3];
            for (int i = 0; i < listResultLevel2.Count; i++)
            {
                Metaquery metaquery = listResultLevel2[i];
            //mtodo
                var list = metaquery.Expand(5, ExpandType.All);
                listResultLevel3.AddRange(list);
                cnt[i] = list.Count;
            }
            Assert.AreEqual(cnt[0], 4);
            Assert.AreEqual(cnt[1], 3);
            Assert.AreEqual(cnt[2], 4);

        }

        /// <summary>
        /// Unit test to check the Expand Metaquery with 3 parameters
        /// </summary>
        [TestMethod]
        public void TestMethod_Expand_MetaqueryLevel3()
        {
            Metaquery metaquery = new Metaquery("R(1)←R1(1,2,3)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2,X3)");
            Assert.AreEqual(listResult[1].ToString(), "R0(X1,X3)←R1(X1,X2,X3)");
            Assert.AreEqual(2, listResult.Count);
		}

		#endregion Expand - All
	}

}
