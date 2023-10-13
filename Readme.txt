Author name : Shalil Dsilva
Program name : MvcLotion
Program purpose : Create an MVC ASP.NET application using .NET core 3.1 
Date created : 2023-10-10 7:00 pm EDT


2023-10-10

7:00 pm EDT 
Created the project
Project running without errors 
Created new Github Repository through visual studio and pushed the project.
Added a README.md file in the Github with brief information of the project.
Added another README.txt file in the project to document all the steps and actions taken to complete the project.

8:00 pm EDT
Updated the home page with name of my project i.e LuxeLotion
Added an Image in the homepage with its source
Also added a new link to go to the product catalogue page
Commited the code to github.

9:44 pm EDT
Added About Us button in the Navigation by making changes to the _layout.cshtml file
Created an About.cshtml file in the Home view with all the required information for the assignment.
Added a method in the home controller for the about us functionality to work.
Added some styling for the about us page
Updated the home page with some basic styling
commited to github


2023-10-13

2:00 pm EDT
Added a data model named Lotion.cs in the models folder. The Lotion class has six attributes which are the characteristics of lotion.
Added NuGet packages from the Package Manager Console. The command used is - Install-Package Microsoft.EntityFrameworkCore.SqlServer -version 3.1
Created a database context class named MvcContextLotion.cs
Registered the database context class in the StartUp.cs file.
Added the database connection string in appsettings.json
commited to github

2:37 pm EDT
Scaffolded the Lotion data using the built in tools of visual studio
CRUD files were created in Views folder
Ran initial migration commands - Add-Migration InitialCreate -context MvcLotionContext
								 Update-Database -context MvcLotionContext
App ran with no errors
Examined the newly created files
commited to github