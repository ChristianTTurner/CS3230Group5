namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents checkup and diagnosis information for an appointment.
    /// </summary>
    public class AppointmentSummary
    {
        public int AppointmentId { get; set; }

        public int? NurseId { get; set; }

        public int? SystolicReading { get; set; }
        public int? DiastolicReading { get; set; }
        public decimal? BodyTemperature { get; set; }
        public int? Pulse { get; set; }

        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }

        public string? Symptoms { get; set; }
        public string? InitialDiagnosis { get; set; }
        public string? FinalDiagnosis { get; set; }

        public AppointmentSummary()
        {
        }

        public AppointmentSummary(int appointmentId)
        {
            AppointmentId = appointmentId;
        }
    }
}