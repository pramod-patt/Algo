using Algo2020.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020.Sorting
{
   public class MeetingIntervals
    {

        /// <summary>
        /// Merge meeting timings
        /// You want to add a feature to see the times in a day when everyone is available
        /// </summary>
        /// <param name="meetings"></param>
        /// <returns></returns>
        public List<Meeting> MergeRanges(List<Meeting> meetings)
        {
            // Merge meeting ranges
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime)).OrderBy(m => m.StartTime).ToList();

            //initialize merged meetings with earliest meeting 
            var mergedMeetings = new List<Meeting> { sortedMeetings[0] };

            foreach (var cm in sortedMeetings)
            {
                var lastMergedMeetings = mergedMeetings.Last();

                //var meetings = new List<Meeting>() //sample input
                //{
                //    new Meeting(1, 3), new Meeting(2, 4)
                //};

                if (cm.StartTime <= lastMergedMeetings.EndTime)
                {
                    lastMergedMeetings.EndTime = Math.Max(lastMergedMeetings.EndTime, cm.EndTime);
                }
                else
                {
                    mergedMeetings.Add(cm);
                }
            }

            return mergedMeetings;
        }

        /// <summary>
        /// L252 - Meeting Rooms
        /// Given an array of meeting time intervals consisting of start and end times [[s1,e1],[s2,e2],...] (si < ei), determine if a person could attend all meetings.
        /// Input: [[0,30],[5,10],[15,20]]
        /// Output: false
        /// Input: [[7,10],[2,4]]
        /// Output: true
        /// </summary>
        /// <param name="meetings"></param>
        /// <returns></returns>
        public bool CheckPersonCanAttendMeetings(List<Meeting> meetings)
        {
            // base case
            if (meetings.Count == 0)
                return false;

            //sort the meeting object by meeting start time
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime)).OrderBy(m => m.StartTime).ToList();

            for (int i = 0; i < sortedMeetings.Count; i++)
            {
                if (sortedMeetings[i].EndTime > sortedMeetings[i + 1].EndTime)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
