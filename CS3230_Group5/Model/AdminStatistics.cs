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
        public int TotalAppointments { get; set; }

        public int UniquePatients { get; set; }

        public int CompletedCheckups { get; set; }

        public int TestsOrdered { get; set; }

        public int TestsPerformed { get; set; }

        public int AbnormalResults { get; set; }
    }
}
