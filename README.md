# FirstProjectITI - ASP.NET Core MVC

A practice project built while learning **ASP.NET Core MVC**. The project demonstrates core MVC concepts including CRUD operations, Entity Framework Core, Model Validation, Relationships, View Models, and different techniques for passing data from Controllers to Views.

## Features

### Employee Management

* View all employees
* Add new employees
* Edit employee information
* View employee details
* Assign employees to departments
* Display employee information using View Models

### Department Management

* View all departments
* Add new departments
* Display employees related to each department

### Student Management

* View all students
* Add new students
* Edit student information
* Delete students
* View student details
* Server-side validation using Data Annotations
* Custom validation for unique student names

## Concepts Practiced

* ASP.NET Core MVC
* Controllers and Actions
* Routing
* Razor Views
* Models
* ViewData
* View Models
* Model Binding
* Model Validation
* Data Annotations
* Custom Validation Attributes
* CRUD Operations
* Entity Framework Core
* Code First
* EF Core Migrations
* SQL Server
* One-to-Many Relationships
* Navigation Properties
* Eager Loading using `Include()`
* Dependency between Models and Views
* HTTP GET and POST Actions
* Anti-Forgery Tokens

## Technologies Used

* C#
* .NET 9
* ASP.NET Core MVC
* Entity Framework Core 9
* SQL Server
* Razor Views
* HTML
* CSS

## Project Structure

```text
FirstProjectITI
│
├── Controllers
│   ├── EmployeeController.cs
│   ├── DepartmentController.cs
│   ├── StudentController.cs
│   └── BindController.cs
│
├── Models
│   ├── Employee.cs
│   ├── Department.cs
│   ├── Student.cs
│   ├── ITIContext.cs
│   └── UniqueNameAttribute.cs
│
├── ViewModel
│   ├── EmpWithDeptListViewModel.cs
│   └── EmpDeptColorTempMsgCitysViewModel.cs
│
├── Views
│   ├── Employee
│   ├── Department
│   ├── Student
│   ├── Home
│   └── Shared
│
├── Migrations
│
└── Program.cs
```

## Database

The project uses **SQL Server** with **Entity Framework Core**.

The database contains the following main entities:

* Employee
* Department
* Student

### Relationships

* A Department can contain multiple Employees.
* An Employee belongs to one Department.
* A Student can be associated with a Department.

## Getting Started

### 1. Clone the repository

```bash
git clone <your-repository-url>
```

### 2. Navigate to the project

```bash
cd FirstProjectITI
```

### 3. Restore dependencies

```bash
dotnet restore
```

### 4. Update the database connection

Update the connection configuration according to your local SQL Server setup.

### 5. Apply migrations

```bash
dotnet ef database update
```

### 6. Run the project

```bash
dotnet run
```

## Learning Purpose

This project was created as part of my learning journey in ASP.NET Core MVC.

The main goal was to gain hands-on experience with:

* Building MVC applications
* Working with Controllers and Views
* Performing CRUD operations
* Using Entity Framework Core
* Working with SQL Server
* Applying Model Validation
* Creating Custom Validation Attributes
* Using View Models to transfer data between Controllers and Views

## Future Improvements

* Implement Dependency Injection for the database context
* Move the connection string to `appsettings.json`
* Add a Repository and Service Layer
* Improve validation using View Models
* Add authentication and authorization
* Improve UI and user experience
* Add error handling
* Add logging
* Use asynchronous database operations
* Add unit tests

## Author

**Ahmed Raafat**

ASP.NET Core / .NET Developer
