A CRUD web application created in C# Core with the theme Zoo. 
I've used MVC architecture, Entity Framework 6 and ASP.NET Core. 
The approach used here is Database first which is the reverse engineering from an existing database, and I first ceated the database Zoo
, with 3 tables: Categorie, Ingrijitori(caretaker) and Sarcini(duties). 
Then I installed the necesary packages to use Entity Framework:
- Microsoft.EntityFrameworkCore 3.1.1;
- Microsoft.EntityFrameworkCore.SqlServer 3.1.1;
- Microsoft.EntityFrameworkCore.Design 3.1.1;
-------------------------------------------------------------------------------------------------------------------------------------------
  In the next step I've used the Scaffold technique to scaffold models for my database. Therefore I accessed the Package Manager Console and 
typed the following command: Scaffold-DbContext "Followed by the connection string from my database". Models had been created and a
derived context, ZooContext, that allow me to query and save instances of the entity classes(models).
  Next I Register my Context with Dependency Injection. First step here is to remove the inline context configuration from ZooContext:
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"...the connection string here");
        }
 For my MVC Controlles to make use of the ZooContext I am going to register it as a service and first I add the using statements at the top of the startup for using EntityFramework and the Models folder:
          using PracticeDatabaseFirst.Models;
          using Microsoft.EntityFrameworkCore;
Now I can use AddDbContext method to register it as a service. In the ConfigureServices method from Startup we add the following 2 lines:
        var connection = @"...the Connection String";
            services.AddDbContext<ZooContext>(options => options.UseSqlServer(connection));
Then I add controllers for Categorie and Ingrijitor. I add for categories the Controller using Entity Framework which is scaffolding all the CRUD methods on the controller 
and also add Views for each of them.
      Then I modify the name on the Layout and also added a view on the Navbar Brand.
