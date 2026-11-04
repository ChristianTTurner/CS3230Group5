Usernames and passwords needed:

Database username: cs3230f26_g5
Database password: xS4!IKEf9}O9kF_f.@Gm

ADMIN
Username: admin1
password: admin123

NURSES
Username: nurse1 
password: nurse123

username: nurse5
password: 12345
 
Known issues or incomplete features: storing hashed passwords

STORED PROCEDURE
1. SaveRoutineCheckup
 - Saves routine checkup information for a patient's appointment in the appointment_summary table.
 Implemented in AppointmentSummaryDal.cs class in SaveCheckup(AppointmentSummary summary) method.
 How it works: 
  - Accepts nine input parameters containing the appointment ID, nurse ID, blood pressure, temperature, pulse, height, weight, and symptoms.
  - Validates the input values before saving.
  - Inserts a new routine checkup if one does not already exist.
  - Updates the existing checkup if a record already exists for the appointment.
  - Uses a database transaction to ensure the operation is completed successfully.
  - Rolls back the transaction if a SQL exception occurs.
 C# Integration:
  - The stored procedure is called from AppointmentSummaryDal.SaveCheckup() using MySqlCommand with CommandType.StoredProcedure. All nine parameters are passed using typed MySQL parameters.
SQL:
DELIMITER $$

CREATE PROCEDURE SaveRoutineCheckup(
    IN p_appointment_id INT,
    IN p_nurse_id INT,
    IN p_systolic INT,
    IN p_diastolic INT,
    IN p_temperature DECIMAL(4,1),
    IN p_pulse INT,
    IN p_height DECIMAL(5,2),
    IN p_weight DECIMAL(5,2),
    IN p_symptoms VARCHAR(500)
)
BEGIN
    DECLARE EXIT HANDLER FOR SQLEXCEPTION
    BEGIN
        ROLLBACK;
        RESIGNAL;
    END;

    IF p_appointment_id <= 0
       OR p_nurse_id <= 0
       OR p_systolic <= 0
       OR p_diastolic <= 0
       OR p_temperature <= 0
       OR p_pulse <= 0
       OR p_height <= 0
       OR p_weight <= 0
       OR p_symptoms IS NULL
       OR CHAR_LENGTH(TRIM(p_symptoms)) = 0
       OR CHAR_LENGTH(TRIM(p_symptoms)) > 500 THEN

        SIGNAL SQLSTATE '45000'
            SET MESSAGE_TEXT =
                'Invalid routine check-up information.';
    END IF;

    START TRANSACTION;

    INSERT INTO appointment_summary (
        appointment_id,
        nurse_id,
        systolic_reading,
        diastolic_reading,
        body_temperature,
        pulse,
        height,
        weight,
        symptoms
    )
    VALUES (
        p_appointment_id,
        p_nurse_id,
        p_systolic,
        p_diastolic,
        p_temperature,
        p_pulse,
        p_height,
        p_weight,
        TRIM(p_symptoms)
    )
    ON DUPLICATE KEY UPDATE
        nurse_id = p_nurse_id,
        systolic_reading = p_systolic,
        diastolic_reading = p_diastolic,
        body_temperature = p_temperature,
        pulse = p_pulse,
        height = p_height,
        weight = p_weight,
        symptoms = TRIM(p_symptoms);

    COMMIT;
END $$

DELIMITER ;
