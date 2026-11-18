using System;
using System.Collections.Generic;
using System.Text;


namespace CS3230_Group5.Model
{
    /// <summary>
    /// Stores statistics generated for an administrator
    /// based on a selected date range.
    /// </summary>
    public class AdminStatistics
    {
        public int TotalTestsPerformed { get; set; }

        public int NumAbnormalResults { get; set; }

        public int NumNormalResults { get; set; }

        public List<TestInfo> TestStatistics { get; set; }

        public AdminStatistics() 
        {
            TotalTestsPerformed = 0;
            NumAbnormalResults = 0;
            NumNormalResults = 0;
            TestStatistics = new List<TestInfo>();
        }

    }
}
