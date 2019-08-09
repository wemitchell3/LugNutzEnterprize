# LugNutzbPremium

Welcome to the LugNutzbPremium!

## Project links to Initial Proposale, Mock Up, and ERD. 

After building LugNutz for my front-end capstone and spending the second half of my time at NSS learning the fundamentals of C#, MVC, .NET Core, Entity Framework, and SQL technologies, I determined there was much more I could add to LugNutz, so I decided to create LugNutz 2.0, premium edition.

LugNutz Premium is primarily designed to be a Desktop Web Application, geared towards garage warriors and part-time mechanics. Additional functionality includes automatic vehicle creation using the Vehicle Identification Number to fetch vehicle specifications through the National Highway Traffic Safety Administration API and vehicle specific VIN decoded reports. 

This project was built using C#, .Net Core, Entity Framework, Identity Framework, MVC, ASP.net, ADO.net, HTML, CSS.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine.

### Installing

First, you'll need to clone down the repo into a directory. Open your terminal and enter.

```
git clone git@github.com:wemitchell3/LugNutzPremium.git
```
Open up your editor such as Visual Studio 2019, or whichever you prefer to use, through the terminal by running the following commands

```
cd LugNutzPremium
```

```
start LugNutzPremium.sln
```

Now, you'll be taken to Visual Studio with the project opened up. The next thing you'll want to do is to go to Tools and open the NuGet Package Manager and select the Package Manager Console. Once that is open, type in: Add-Migration SeedData and hit enter. Once that has completed, type in: Update-Database and hit enter. Once the database has been successfully updated, go to View and select SQL Server Object Explorer. Select your local database and click refresh. Now, for the fun part! Let's run our application. Make sure you've selected LugNutzPremium before running the app.

###### You are now ready to use LugNutzPremium. 


## User instructions
My attempt with this app was to make it super user friendly so there really isn't much instruction need. 

First thing you will want to do is add your cars to your garage. I prefer the automatic way (you will need to have your VIN handy to use this feature). Once you have added a vehicle or vehicles to your garage, you can now begin to add past a future tasks to those vehicles along with wish list items. There is also a community chat feature to help diagnose problems and share ideas.

### I hope you enjoyed my app! :)

## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) - The language we used
* [Azure Data Studio](https://docs.microsoft.com/en-us/sql/azure-data-studio/download?view=sql-server-2017) - Cloud for database
* [ASP.NET MVC](https://dotnet.microsoft.com/apps/aspnet/mvc) - MVC Framework for Web app 
* [Entity Framework](https://dotnet.microsoft.com/apps/aspnet/entity-framework) - Object Relational Mapper
* [Identity Framework](https://dotnet.microsoft.com/apps/aspnet/identity) - Authentication and user related data in ASP.NET MVC

## Author
* **William E. Mitchell III**
