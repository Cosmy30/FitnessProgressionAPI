# FitnessProgressionAPI


## Overview

This project is a RESTful ASP.NET Core Web API designed to track workout progress.

As a fitness enthusiast since 2021, I have noticed that many fitness websites and applications can feel overwhelming for people who are just starting their fitness journey. While these tools provide many useful features, they inspired me to develop a lightweight API that focuses on simplicity and ease of use.

The goal of this project is to provide a straightforward way for users to record and track their workouts. The API can be used both by experienced trainees and by people who are taking their first steps into fitness.


## Features

- User management. Users can be created, updated and deleted. They can also be retrieved individually or as a complete list.
- Workout management. Supports the standard CRUD operations. Workouts can be retrieved individually or filtered by owner. Ownership validation is enforced.
- Exercise logging. Supports the standard CRUD operations. The exercise logs can be retrieved individually or filtered by workout. Ownership validation is enforced.
- Exercise catalog. Provides read-only access to the predefined exercises available in the system. Exercises can be retrieved individually or as a complete list.


## Architecture / Design

The API follows a layered architecture. The controllers handle the HTTP requests, while the validation and the business logic are shared by services, data annotations and ASP.NET. 

Data Transfer Objects (DTOs) are used for data transfer between the application and the user. Entity Framework Core (EF Core) is used for database interaction, migrations and data seeds. 

The application also uses SQL Server for data storage, with four main entities - Users, Workouts, ExerciseLogs and Exercises. Users own workouts, which can contain one or more exercise logs, and each exercise log references a predefined exercise. 

Mappings are mainly used for projecting database entities into DTOs, and interfaces for extensibility and loose coupling.


## Technologies

- C#
- .NET 8 / ASP.NET Core
- Entity Framework Core
- SQL Server
- BCrypt
- Swagger / OpenAPI
- Git


## Database

The database consists of the following entities and relationships:

```text
Users
|
+-- Workouts
    |
    +-- ExerciseLogs
        |
        +-- Exercises
```

The Exercises entity was populated using seed data, and the database structure was generated using migrations.


## API Endpoints

### Users

- GET /users
- GET /users/{id}
- POST /users
- PATCH /users/{id}
- DELETE /users/{id}

### Workouts

- GET /workouts/{id}
- GET /users/{userId}/workouts
- POST /users/{userId}/workouts
- PATCH /workouts/{id}
- DELETE /workouts/{id}

### ExerciseLogs

- GET /exerciseLogs/{id}
- GET /workouts/{workoutId}/exercise-logs
- POST /workouts/{workoutId}/exercise-logs
- PATCH /exerciseLogs/{id}
- DELETE /exerciseLogs/{id}

### Exercises

- GET /exercises
- GET /exercises/{id}


## Validation

The API validates incoming data and enforces business rules before persisting it to the database. The application uses three types of validation: ASP.NET Core model validation, data annotations, and business rules. 

Data annotations are used both in DTOs (primarily those used by POST and PATCH endpoints) and in database entities. Examples include string length constraints, numeric range validation, required field validation, and format validation for fields such as email addresses. 

Business rules are primarily implemented within services. Common checks include entity existence validation, foreign key lookups and null checks, while more specific rules include enum validation and ownership validation.


## Running the Project

### Prerequisites 

- .NET 8 SDK
- SQL Server LocalDB (or SQL Server)

### Clone repository

```bash
git clone https://github.com/Cosmy30/FitnessProgressionAPI.git
cd FitnessProgressionAPI
```

### Configure the connection string

The project is configured to use SQL Server LocalDB by default. If you wish to use a different SQL Server instance, please update the `DefaultConnection` value in `appsettings.json`.

### Apply migrations

```bash
dotnet ef database update
```

This command creates the database (if it does not already exist) and applies all available migrations.

### Install EF Core CLI tools

If the `dotnet ef` command is unavailable, please install the Entity Framework Core CLI tools by running the following command:

```bash
dotnet tool install --global dotnet-ef
```

### Run the project

```bash
dotnet run
```

The project can also be run by pressing F5 in Visual Studio.

### Swagger

Swagger UI is available after starting the application.


## Future Improvements

These are some of the improvements that could be implemented in future versions of the project:

- Add authentication and authorization
- Add detailed Swagger/OpenAPI documentation
- Add pagination and filtering for collection endpoints
- Add user roles (admin/user)
- Add integration and unit testing