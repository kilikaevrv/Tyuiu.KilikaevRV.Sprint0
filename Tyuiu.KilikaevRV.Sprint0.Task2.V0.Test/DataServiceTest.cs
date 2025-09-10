﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KilikaevRV.Sprint0.Task2.V0.Lib; 

namespace Tyuiu.KilikaevRV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Роман";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Роман", res);
        }
    }
}
