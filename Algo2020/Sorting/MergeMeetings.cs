using Algo2020.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020.Sorting
{
   public class MergeMeetings
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
    }
}
