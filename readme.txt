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

"None"


