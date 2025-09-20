# 🏥 VB.NET Patient Registration System

A Windows Forms application built with Visual Basic .NET in Visual Studio for managing patient records. This system allows users to register, update, delete, and view patient details—complete with profile image support and SQL Server integration.

## 🚀 Features

- Register new patients with full details and profile image
- Update and delete existing patient records
- Display all records in a DataGridView
- Load and resize profile images from local files
- Connects to SQL Server using `System.Data.SqlClient`
- Clean UI with responsive form controls

## 🛠️ Requirements

- Windows OS
- [.NET Framework](https://dotnet.microsoft.com/en-us/download/dotnet-framework)
- Visual Studio (for editing or rebuilding)
- SQL Server Express or compatible instance
- A database named `PatientDB` with a `Patients` table:
  ```sql
  CREATE TABLE Patients (
      Id INT PRIMARY KEY IDENTITY,
      FullName NVARCHAR(100),
      Gender NVARCHAR(10),
      DateOfBirth DATE,
      PhoneNumber NVARCHAR(20),
      Address NVARCHAR(200),
      MedicalCondition NVARCHAR(200),
      RegistrationDate DATE,
      ProfileImage VARBINARY(MAX)
  )

## 📦 How to Run

- Clone or download this repository.
- Open the .sln file in Visual Studio.
- Ensure your SQL Server instance is running and the connection string is correct.
- Build and run the project.
- Use the form to manage patient records.

## 📁 Files

- Form1.vb: Main form logic and event handlers.
- Form1.Designer.vb: UI layout.
- README.md: Project overview.
- bin/Release/PatientManager.exe: Optional compiled executable.

  Made with ❤️ by **Redd✍️🔴**
