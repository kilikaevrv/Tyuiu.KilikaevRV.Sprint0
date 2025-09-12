﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KilikaevRV.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KilikaevRV.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        
            [TestMethod]
            public void ChechedAdditionValid()
            {
                Assert.AreEqual(10, DataService.Addition(5, 5));
            }

            [TestMethod]
            public void ChechedSubtractionValid()
            {
                Assert.AreEqual(5, DataService.Subtraction(10, 5));
            }

            [TestMethod]
            public void ChechedDivisionValid()
            {
                Assert.AreEqual(50, DataService.Multiplication(10, 5));
            }
            [TestMethod]
            public void ChechedMultiplicationValid()
            {
                Assert.AreEqual(3, DataService.Division(9, 3));
            }
        
    }
} 
    

