### SQLite & Entity Framework Core

## What is a database?

A database is where our application permanently stores information
This allows our information to stay saved even when our API stops

## SQLite

SQLite is a simple database that stores all of its data inside a file

Unlike SQL Server SQLite does not require us to have a separate database server running

## Entity Framework Core

EF core allows our C# application to communicate with a database

* Instead of writing SQL ourselves, we can work with our database using C# *

C# API -> Ef Core -> SQLite Database

## AppDbContext class

This is the main connection between our application and our database

It tells EF Core which models we want to store in our DB

Each DbSet inside of our AppDbContext represents a table

## What is a migration?

A migration is Ef Core's way of keeping track of changes we want to make to our DB

Whenever we create / change models, we create a migration

* dotnet ef migrations add init * init stands for initialize

any migrations after the initial migration can be named anything
* dotnet ef migrations add StudentUpdate *

## Updating The Database

Creating a migration does not automatically update the database

We still need to run our database update

* dotnet ef database update *

Model -> Migration -> Database Update -> Database

## Common LINQ Methods

FirstOrDefault() - finds the first matching record, if nothing is found, it returns null

Where() - Filters records based on a condition. (We would store the results in a variable)

ToList() - gets multiple records and returns them as a list

## SaveChanges

Ef Core keeps track of changes we make to our data.

When we add, update, or remove something, those changes need to be saved to the DB

* SaveChanges() * tells EF Core: take the changes I made and save them to the database

## Dependency Injection

DI allows our classes to receive the things they need instead of creating them manually

Ex of manually creating classes / objects * Student = new Student(); *

## Csproj folder

This contains all of our packages that our project has