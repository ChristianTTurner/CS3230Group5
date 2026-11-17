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

        public int TotalHEPATestsPerformed { get; set; }

        public double HEPATestPercentage {  get; set; }

        public int TotalHEPBTestsPerformed { get; set; }

        public double HEPBTestPercentage { get; set; }

        public int TotalLDLTestsPerformed { get; set; }

        public double LDLTestPercentage { get; set; }

        public int TotalWBCTestsPerformed { get; set; }

        public double WBCTestPercentage { get; set; }

        public int NumAbnormalResults { get; set; }

        public int NumNormalResults { get; set; }

    }
}
