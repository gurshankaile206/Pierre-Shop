# Pierre's Flavored Treats Shop

## Description 

This is an MVC web application for a ficitonal client. I've built this project in order to work with Many to Many relationships and User Authentication. Users are able to login or create an account in order to create, update, and delete functionality. User who aren't logged in are only able to read pages that don't reqiure being logged in. Using many to many relationship, once logged in, a user can create treats than can have many different flavors and a flavor can be associated with as many treats. 

## Technologies Used 

* C#
* ASP.NET 5.0
* MVC 
* MySQL migrations
* Identity framework
* Entity framework
* Razor pages

## Installion and Setup Instructions 

* Download and install the most recent version of .NET SDK for your device.

* Download and install MySQL workbench

* Follow the MySQL installation requirements and setup your password

* Clone this Repository to your local machine

* Setup an SQL database using MySql

  * Create an appsettings.json file in the ``` PierreShop ``` directory

  * Copy and paste the text below and paste into the ``` appsettings.json ``` file. Replace ``` your_db_name ``` with your database name and ``` password with your MySQL password.

  ```
   {
     "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=<your_db_name_here>;uid=root;pwd=<password>;"
      }
  }

  ```
* navigate to the ``` PierreShop ``` directory then run command ``` dotnet restore ```

* In the ``` PierreShop ``` directory run command ``` dotnet ef migrations add Initial ``` to build Migrations Folder, then run ``` dotnet ef database update ``` to update the database.

* Run ``` dotnet ef migrations addIdentity ``` command 

* Run ``` dotnet ef database uodate ``` command to update database

* Run ``` dotnet ef migrations add Authorization ``` command

* Run ``` dotnet ef database update ```

* Run ``` dotnet watch run ``` to open the application in your browser's local server. 

## Contact Info

Gurshan Kaile

gurshankaile206@gmail.com

## License Information

__MIT__


