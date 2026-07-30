# Theater Admin – Movie Management App

An ASP.NET Core MVC web application that lets theater administrators manage movies and their categories. Built for PRT585/681 (Software Engineering Practice), Week 2.

## Overview

The app provides full CRUD (Create, Read, Update, Delete) operations for two related entities:

- **Movie** – the films managed by the theater
- **Category** – the genre each movie belongs to (e.g. Action, Drama, Horror)

Each movie must belong to exactly one category. The category is chosen from a dropdown list on the movie's Create and Edit screens.

## Data model

### Movie

| Field | Type | Notes |
|-------|------|-------|
| Id | int | Primary key |
| Name | string | Required, max 100 chars |
| ReleaseDate | DateTime | Required, date only |
| Director | string | Required, max 100 chars |
| ContactEmail | string | Required, must be a valid email |
| Language | enum | English, Japanese, or Chinese |
| CategoryId | int | Required – links the movie to a category (NOT NULL) |

### Category

| Field | Type | Notes |
|-------|------|-------|
| Id | int | Primary key |
| Name | string | Required, max 50 chars |
| Code | string | Required, max 20 chars |

## Tech stack

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core – **code first** approach
- SQL Server Express (LocalDB) for data persistence
- Bootstrap for the default UI

## Key features

- CRUD operations for movies and categories, generated with scaffolding
- Category selection via dropdown on the movie Create/Edit screens
- Language selection via dropdown (backed by an enum)
- Model validation using data annotation attributes (Required, StringLength, EmailAddress, etc.)
- One-to-many relationship: a category can have many movies; a movie has one category

## Getting started

### Prerequisites

- .NET 10 SDK
- Visual Studio 2022 (or newer) with the "ASP.NET and web development" workload
- SQL Server Express LocalDB (installed with Visual Studio)

### Run the app

1. Open `TheaterAdmin.sln` in Visual Studio.
2. Create the database from the migrations using the Package Manager Console:
   ```powershell
   Update-Database
   ```
3. Press `Ctrl+F5` to run the app.
4. In the browser:
   - Go to `/Categories` and add a few categories (e.g. Action, Drama, Horror).
   - Go to `/Movies` and add movies, selecting a category from the dropdown.

## Project structure

```
TheaterAdmin/
├── Controllers/        # MoviesController, CategoriesController
├── Models/             # Movie, Category, Language (enum)
├── Views/
│   ├── Movies/         # Create, Edit, Details, Delete, Index
│   └── Categories/     # Create, Edit, Details, Delete, Index
├── Data/               # TheaterAdminContext (EF Core DbContext)
├── Migrations/         # EF Core migrations
├── appsettings.json    # Connection string
└── Program.cs          # App configuration and services
```

## Notes

- The database is created and updated through EF Core migrations.
- All validation rules are defined once on the model classes and are automatically enforced on both the client and the server.
