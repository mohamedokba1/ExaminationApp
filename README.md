# Examination App
This application is built using Windows Forms and SQL Server. Here are the instructions for setting up and using the application:

Prerequisites:

Visual Studio installed on your machine
SQL Server Management Studio installed on your machine
Steps to setup the application:

- Clone or download this repository to your local machine.
- Open the solution file (.sln) in Visual Studio.
- Restore the NuGet packages used in the solution(EF Core packages).
- Open SQL Server Management Studio and create a new database named 'ExamsDB'.
- Restore the database backup file.
- Update the connection string in the App.config file to point to your SQL Server instance and the 'ExamDB' database.

## Steps to use the application:

 - Launch the application in Visual Studio.
 - Select the appropriate user role (Admin, Instructor, or Student) to access the application features.
 - Admins can add or remove Instructors and students, while Instructors can create and grade exams for their students. Students can view their exam scores.
 - Use the various forms and controls to perform actions in the application.
