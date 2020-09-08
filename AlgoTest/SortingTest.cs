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
        public void MergeMeetings()
        {
            MeetingIntervals mg = new MeetingIntervals();
            
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

        [TestMethod]
        public void CanAttendMeetings1()
        {
            MeetingIntervals mg = new MeetingIntervals();

            var meetings = new List<Meeting>()
            {
                new Meeting(0, 30), new Meeting(5, 10), new Meeting(15,20)
            };

            var actual = mg.CheckPersonCanAttendMeetings(meetings);

            var expected = false;
            
            Assert.AreEqual(expected, actual);            
        }

        [TestMethod]
        public void CanAttendMeetings2()
        {
            MeetingIntervals mg = new MeetingIntervals();

            var meetings = new List<Meeting>()
            {
                new Meeting(7, 10), new Meeting(2, 4)
            };

            var actual = mg.CheckPersonCanAttendMeetings(meetings);

            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
