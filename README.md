# FitnessProgressionAPI


## Overview

This project is a RESTful ASP.NET Core Web API designed to track workout progress.

As a fitness enthusiast since 2021, I have noticed that many fitness websites and applications can feel overwhelming for people who are just starting their fitness journey. While these tools provide many useful features, they inspired me to develop a lightweight API that focuses on simplicity and ease of use.

The goal of this project is to provide a straightforward way for users to record and track their workouts. The API can be used both by experienced trainees and by people who are taking their first steps into fitness.


## Features

- User management. Users can be created, updated and deleted. They can also be retrieved individually or as a complete list.
- Workout management. Supports the standard CRUD operations. Workouts can be retrieved individually or filtered by owner.
- Exercise logging. Supports the standard CRUD operations. The exercise logs can be retrieved individually or filtered by workout. This section also includes ownership validation.
- Exercise catalog. Provides read-only access to the predefined exercises available in the system. Exercises can be retrieved individually or as a complete list.


## Architecture / Design

The API follows a layered architecture. The controllers handle the HTTP requests, while the validation and the business logic are shared by services, data annotations and ASP.NET. Data Transfer Objects (DTOs) are used for data transfer between the application and the user. Entity Framework Core (EF Core) is used for database interaction, migrations and data seeds. The application also uses SQL Server for data storage, with four main entities - Users, Workouts, ExerciseLogs and Exercises. Users own workouts, which can contain one or more exercise logs, and each exercise log references a predefined exercise. Mappings are mainly used for projecting database entities into DTOs, and interfaces for extensibility and loose coupling.

## Technologies

- C#
- .NET / ASP.NET Core
- SQL Server
- Entity Framework Core
- Swagger / OpenAPI
- Git


## Database

The database consists of the following entities and relationships:

Users
|
+-- Workouts
    |
    +-- ExerciseLogs
        |
        +-- Exercises

The Exercises entity was populated using seed data, and the database structure was generated using migrations.


## API Endpoints



## Validation

## Running the Project

## Future Improvements
