
# User Management App

Description
This is a simple User Management application built with ASP.NET Core MVC. It allows managing users with roles like Admin, Principal, Teacher, Assistant Teacher, and User.

## Features
- User creation, editing, viewing, and deletion
- Role management with dropdown selection
- Server-side validation for input data

Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Microsoft SQL Server 2022 Developer Edition
- Visual Studio Code (or Visual Studio)

Setup and Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/frfarhath/UserManagementApp.git
   cd UserManagementApp


2. Restore dependencies and build the project:

   ```bash
   dotnet restore
   dotnet build

3. Update the database connection string in `appsettings.json` as per your SQL Server instance.

4. Run database migrations (if applicable):

   ```bash
   dotnet ef database update
 

5. Run the application:

   ```bash
   dotnet run

## Usage
* Use the UI to add, edit, view, or delete users.
* Validation messages and success notifications will guide you.


