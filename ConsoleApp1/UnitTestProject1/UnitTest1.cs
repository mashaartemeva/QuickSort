using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sort
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSort3Element()
        {
            var array = new int[3] { 3, 1, 2 };
            ClassSort.QuickSort(array);
            Assert.IsTrue(array[1] >= array[0]);
            Assert.IsTrue(array[2] >= array[1]);
        }
        [TestMethod]
        public void TestSort100SameElement()
        {
            var array = new int[100];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = 11;
            ClassSort.QuickSort(array);
            Assert.IsTrue(array[rand.Next(0,100)] == array[rand.Next(0, 100)]);
            
        }
        [TestMethod]
        public void TestSort1000RandomElement()
        {
            var array = new int[1000];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = rand.Next(0,100);
            ClassSort.QuickSort(array);
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(array[rand.Next(0, 500)] <= array[rand.Next(500, 1000)]);
            }
        }
        [TestMethod]
        public void TestSortEmptyArray()
        {
            var array = new int[5];
            ClassSort.QuickSort(array);
        }

        [TestMethod]
        public void VeryDifficultForMyCalculator()
        {
            var array = new int[1500000000];
            var rand = new Random();
            for (int i = 0; i < array.Length; i++) array[i] = rand.Next(0, 100);
            ClassSort.QuickSort(array);
            Assert.IsTrue(array[rand.Next(0, 750000000)] <= array[rand.Next(750000000, 1500000000)]);
        }
    }
}
