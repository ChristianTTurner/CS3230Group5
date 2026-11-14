
namespace CS3230_Group5.Model
{
    /// <summary>
    /// Represents the medical checkup measurements, symptoms, and diagnosis information
    /// associated with a patient appointment.
    /// </summary>
    public class AppointmentSummary
    {
        /// <summary>
        /// Gets or sets the unique identifier of the associated appointment.
        /// </summary>
        public int AppointmentId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the nurse responsible for the checkup.
        /// </summary>
        public int? NurseId { get; set; }

        /// <summary>
        /// Gets or sets the patient's systolic blood pressure reading.
        /// </summary>
        public int? SystolicReading { get; set; }

        /// <summary>
        /// Gets or sets the patient's diastolic blood pressure reading.
        /// </summary>
        public int? DiastolicReading { get; set; }

        /// <summary>
        /// Gets or sets the patient's body temperature.
        /// </summary>
        public decimal? BodyTemperature { get; set; }

        /// <summary>
        /// Gets or sets the patient's pulse reading.
        /// </summary>
        public int? Pulse { get; set; }

        /// <summary>
        /// Gets or sets the patient's height.
        /// </summary>
        public decimal? Height { get; set; }

        /// <summary>
        /// Gets or sets the patient's weight.
        /// </summary>
        public decimal? Weight { get; set; }

        /// <summary>
        /// Gets or sets the symptoms reported by the patient.
        /// </summary>
        public string? Symptoms { get; set; }

        /// <summary>
        /// Gets or sets the initial diagnosis recorded during the appointment.
        /// </summary>
        public string? InitialDiagnosis { get; set; }

        /// <summary>
        /// Gets or sets the final diagnosis recorded after the checkup.
        /// </summary>
        public string? FinalDiagnosis { get; set; }

        /// <summary>
        /// Initializes a new instance of the AppointmentSummary class.
        /// </summary>
        public AppointmentSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the AppointmentSummary class
        /// with the specified appointment identifier.
        /// </summary>
        /// <param name="appointmentId">
        /// The unique identifier of the associated appointment.
        /// </param>
        public AppointmentSummary(int appointmentId)
        {
            AppointmentId = appointmentId;
        }
    }
}