using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.Model
{
    public class TestInfo
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int NumPerformed { get; set; }

        public double Percentage { get; set; }

        public TestInfo()
        {
            Code = "";
            Name = "";
            NumPerformed = 0;
            Percentage = 0;
        }
    }
}
