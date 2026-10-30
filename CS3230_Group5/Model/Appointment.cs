using System;
using System.Collections.Generic;
using System.Text;

namespace CS3230_Group5.Model
{
    public class Appointment
    {
        public int? AppointmentID { get; set; }
        public int? PatientID { get; set; }
        public string? PatientName { get; set; }
        public int? DoctorID { get; set; }
        public string? DoctorName { get; set; }
        public DateTime? DateTime {  get; set; }
        public string? Reason { get; set; }

        public Appointment (int? appointmentID, string? patientName, string? doctorName, DateTime? dateTime, string? reason)
        { 
            if (this.isValidInput(appointmentID, patientName, doctorName, dateTime))
            {
                AppointmentID = appointmentID;
                PatientName = patientName;
                DoctorName = doctorName;
                DateTime = dateTime;
                Reason = reason;
            }
        }

        private bool isValidInput(int? aID, string? pName, string? dName, DateTime? dateTime)
        {
            return aID != null && pName != null && dName != null && dateTime != null;
        }
    }
}
