//-----------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="IVT-131">
// Copyright (c) IVT-131. All rights reserved.
// </copyright>
// <author>Лобачев Андрей</author>
// <author>Супрун Артем</author>
// <author>Дарий Олеся</author>
//-----------------------------------------------------------------------
namespace UnitTestProject1
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Windows.Forms;
    using Multi2048;
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void MoveTileTest1()
        {
            int[,] mas1 = new int[4, 4] { 
                                        { 2, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 } };
            int[,] mas2 = new int[4, 4] { 
                                        { 0, 0, 0, 2 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 } };

            DvigWASD dvig = new DvigWASD();
            dvig.MoveTile("down", mas1);
            CollectionAssert.AreEqual(mas1, mas2);
        }
        [TestMethod]
        public void MoveTileTest2()
        {
            int[,] mas1 = new int[4, 4] { 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 2, 0, 0, 0 } };
            int[,] mas2 = new int[4, 4] { 
                                        { 2, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 } };

            DvigWASD dvig = new DvigWASD();
            dvig.MoveTile("left", mas1);
            CollectionAssert.AreEqual(mas1, mas2);
        }
        [TestMethod]
        public void MoveTileTest3()
        {
            int[,] mas1 = new int[4, 4] { 
                                        { 2, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 } };
            int[,] mas2 = new int[4, 4] { 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 2, 0, 0, 0 } };

            DvigWASD dvig = new DvigWASD();
            dvig.MoveTile("right", mas1);
            CollectionAssert.AreEqual(mas1, mas2);
        }
        [TestMethod]
        public void MoveTileTest4()
        {
            int[,] mas1 = new int[4, 4] { 
                                        { 0, 0, 0, 2 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 } };
            int[,] mas2 = new int[4, 4] { 
                                        { 2, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 }, 
                                        { 0, 0, 0, 0 } };

            DvigWASD dvig = new DvigWASD();
            dvig.MoveTile("up", mas1);
            CollectionAssert.AreEqual(mas1, mas2);
        }

        
       
    }
}
