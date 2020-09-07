using System;
using System.Collections.Generic;
using System.Linq;
using Algo2020.Model;
using Algo2020.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MergeMeetings mg = new MergeMeetings();
            
            var meetings = new List<Meeting>()           
            {
                new Meeting(1, 3), new Meeting(2, 4)
            };
            
            var actual = mg.MergeRanges(meetings);

            var expected = new List<Meeting>()
            {
                new Meeting(1, 4)
            };

            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
