using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.Model
{
    public class Appointment
    {
        public int? AppointmentID { get; set; }
        public int? PatientID { get; set; }
        public int? DoctorID { get; set; }
        public DateTime? DateTime {  get; set; }
        public string? Reason { get; set; }

        public Appointment (int? appointmentID, int? patientID, int? doctorID, DateTime? dateTime, string? reason)
        { 
            if (this.isValidInput(appointmentID, patientID, doctorID, dateTime))
            {
                AppointmentID = appointmentID;
                PatientID = patientID;
                DoctorID = doctorID;
                DateTime = dateTime;
                Reason = reason;
            }
        }

        private bool isValidInput(int? aID, int? pID, int? dID, DateTime? dateTime)
        {
            return aID != null && pID != null && dID != null && dateTime != null;
        }
    }
}
