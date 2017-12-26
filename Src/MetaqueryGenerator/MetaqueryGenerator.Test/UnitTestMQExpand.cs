﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetaqueryGenerator.Common;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MetaqueryGenerator.Test
{
    [TestClass]
    public class UnitTestMQExpand
    {

        #region Expand Head

        [TestMethod]
        public void TestMethodExpandHeadRoot()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            Assert.AreEqual(rootMQ.ExpandHead().Count, 0);
        }
        [TestMethod]
        public void TestMethodExpandHeadTo1()
        {
            Metaquery metaquery = new Metaquery("R0(1)←R1(1,2)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult.Count, 1);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2)");
        }
        [TestMethod]
        public void TestMethodExpandHeadTo2()
        {
            Metaquery metaquery = new Metaquery("R(1)←R1(1,2)&R2(3)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult.Count, 2);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2)&R2(X3)");
            Assert.AreEqual(listResult[1].ToString(), "R0(X1,X3)←R1(X1,X2)&R2(X3)");
        }


        #endregion Expand Head

        #region Expand Body - Relation
        [TestMethod]
        public void TestMethodExpandBodyRelationRoot()
        {
            Metaquery rootMQ = Metaquery.GetRootMQ();
            List<Metaquery> listResult = rootMQ.ExpandBodyRelation();
            Assert.AreEqual(listResult.Count, 2);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1)←R1(X1)&R2(X1)");
            Assert.AreEqual(listResult[1].ToString(), "R0(X1)←R1(X1)&R2(X2)");
        }
        /*[TestMethod]
        public void TestMethodExpandBodyRelationTo1()
        {
            Metaquery metaquery = new Metaquery("R0(1)←R1(1,2)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult.Count, 1);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2)");
        }
        [TestMethod]
        public void TestMethodExpandBodyRelationTo2()
        {
            Metaquery metaquery = new Metaquery("R(1)←R1(1,2)&R2(3)");
            List<Metaquery> listResult = metaquery.ExpandHead();
            Assert.AreEqual(listResult.Count, 2);
            Assert.AreEqual(listResult[0].ToString(), "R0(X1,X2)←R1(X1,X2)&R2(X3)");
            Assert.AreEqual(listResult[1].ToString(), "R0(X1,X3)←R1(X1,X2)&R2(X3)");
        }*/

        

        #endregion Expand Body - Relation
    }

}