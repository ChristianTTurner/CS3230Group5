CS3230 Group 5 - Healthcare Management System

=====================================================================
BUILD AND RUN INSTRUCTIONS
=====================================================================

Requirements
1. Windows (the app is a Windows Forms application).
2. .NET 10 SDK (or Visual Studio with the ".NET desktop development" workload and .NET 10 support).
3. MySQL Server and MySQL Workbench.

NuGet packages (restored automatically when the project builds; internet access is needed the first time)
- MySqlConnector 2.6.2
- Microsoft.Extensions.Configuration.Json 11.0.0
- BCrypt.Net-Next 4.2.0 (password hashing)

Database setup
1. In MySQL Workbench, import the submitted SQL file (structure and data) to create the schema cs3230f26_g5.
   The data already contains hashed passwords.
2. If the stored procedures are not in the dump, run sp.sql.
3. The MySQL server must be reachable at localhost, port 3307. To use a different server or port,
   change the Server and Port values in CS3230_Group5/appsettings.json.

Connection settings
- appsettings.json holds the server, port and database name.
- The database username and password go in appsettings.local.json (same folder, copied to the build output).
  If that file is missing, create it with:
  {
    "ConnectionStrings": {
      "CS3230Database": "Server=localhost;Port=3307;Database=cs3230f26_g5;User ID=cs3230f26_g5;Password=<database password listed below>"
    }
  }
- Alternatively, set the environment variables CS3230_DB_USER and CS3230_DB_PASSWORD.

Build and run
1. Open CS3230Group5.slnx in Visual Studio.
2. Set CS3230_Group5 as the startup project.
3. Press F5 (or Ctrl+F5).
   Command line alternative: dotnet run --project CS3230_Group5
4. Log in with one of the admin or nurse accounts listed below.


=====================================================================
USERNAMES AND PASSWORDS
=====================================================================

Database username: cs3230f26_g5
Database password: xS4!IKEf9}O9kF_f.@Gm

ADMIN
Usernames: admin1, admin2, admin3, admin4, admin5
password (for all admins): admin123

NURSES
Username: nurse1
password: nurse123

username: sam
password sam1

username: john1
password: john123

username: mike
password: pass123

username: nurse4
password: nurse1234

username: nurse5
password: 12345

username: kenD
password: test

Password storage: user passwords are stored in the database as BCrypt hashes (BCrypt.Net-Next).
The passwords above are what you type at login; the database only holds the hashes.
If you load a database that still has plaintext passwords, run hash_passwords.sql once.


=====================================================================
KNOWN ISSUES OR INCOMPLETE FEATURES
=====================================================================

(Add any remaining known issues here before submitting. If there are none, write "None".)


=====================================================================
STORED PROCEDURE
=====================================================================

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

2. DeleteAppointment
 - Deletes the appointment and associated information from the database given an id
 Implemented in AppointmentDal.cs class in DeleteAppointment(int id) method.
 How it works:
  - Accepts an integer parameter that represents the appointments id
  - Starts a transaction to delete the appointment, appointment_summary, and ordered_test where appointment_id = id
  - If it's successful it commits the results and returns '1' as result
      otherwise it will rollback the results and returns '0' as result
 C# Integration:
  - The stored procedure is called from AppointmentDal.DeleteAppointment() using MySqlCommand with CommandType.StoredProcedure. The id parameter is passed in using MySQL parameters.
SQL:
DELIMITER $$
CREATE DEFINER=`cs3230f26_g5`@`%` PROCEDURE `DeleteAppointment`(IN id INT)
BEGIN
	START TRANSACTION;
	DELETE ordered_test FROM ordered_test
	WHERE appointment_id = id;

	DELETE appointment_summary FROM appointment_summary
	WHERE appointment_id = id;

	DELETE appointment FROM appointment
	WHERE appointment_id = id;
	COMMIT;
    select 1 as result;
END$$
DELIMITER ;

3. get_most_performed_tests_duringdates
 - Gets the Test Statistics during a time frame
 Implemented in AdminStatisticsDal.cs class in GetStatistics(DateTime startDate, DateTime endDate) method.
 How it works:
  - Accepts two DateTime parameters to define the time frame for the test results
  - Returns a table containing statistics for each qualifying test and the general test results
  C# Integration:
  - The stored procedure is called from AdminStatisticsDal.GetStatistics() using MySqlCommand with CommandType.StoredProcedure. The id parameter is passed in using MySQL parameters.
SQL:
DELIMITER $$
CREATE DEFINER=`cs3230f26_g5`@`%` PROCEDURE `get_most_performed_tests_duringdates`(IN startDate datetime, IN endDate datetime)
BEGIN
	SELECT ot.test_code, test_name, COUNT(*) as performed_num_times,
    (SELECT COUNT(*)
		FROM ordered_test
		WHERE performed_datetime >= startDate
		AND performed_datetime < endDate) as performed_all_tests_n_times,
	COUNT(ot.test_code)* 100.0 / (SELECT COUNT(*) FROM ordered_test) as percentage,
    (SELECT COUNT(*)
		FROM ordered_test
        WHERE abnormal = 0 AND performed_datetime >= startDate
		AND performed_datetime < endDate) as num_normal_results,
	(SELECT COUNT(*)
		FROM ordered_test
        WHERE abnormal = 1 AND performed_datetime >= startDate
		AND performed_datetime < endDate) as num_abnormal_results
	FROM ordered_test ot JOIN test t ON ot.test_code = t.test_code
    WHERE performed_datetime >= startDate
	AND performed_datetime < endDate
	GROUP BY test_code,test_name
    HAVING performed_num_times >= 2
    ORDER BY performed_num_times DESC;
END$$
DELIMITER ;
