## Movies App
# This is a CRUD Application with Asp.net MVC as an introductory tutorial to the functionalities of asp.net. 

The application features performing CRUD (Create, Read, Update, Delete) actions with movies 
It also handles sorting functionalities based on movie titles, genre
It handles validation logic using the required data annotation types.

It uses Entity framework core for managing migrations, seeding database, and for general database queries.

It uses Razor Template for the views

# Installation and Setup
1. Run the command `dotnet restore to install application dependencies` 
2. Run the command `dotnet ef migrations add Initial Migration` to generate initial migrations
3. Run the command `dotnet ef database update` to update the migrations against the database. 
4. Run the command `dotnet run` to start the application