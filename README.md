# Zust Social Media App - Getting Started Guide

Welcome to Zust Social Media App! This guide will help you get started with setting up and running the application using Visual Studio 2022. The app utilizes Entity Framework Code First approach and requires a SQL database with the necessary data. Before you proceed, ensure that you have the following prerequisites installed:

1. Visual Studio 2022 (or a compatible version).
2. SQL Server (Express Edition or higher) or SQL Server LocalDB.

## Clone the Repository

To get started, first, you need to clone the GitHub repository to your local machine. You can do this by following these steps:

1. Open a terminal or command prompt.
2. Change the current working directory to the location where you want to clone the repository.
3. Execute the following command:

```bash
git clone https://github.com/Drongo-J/Zust
```

## Set Up the Database

Next, we'll set up the SQL database for Zust Social Media App. The repository already includes SQL insert statements for database seeding. Follow these steps to create the database and populate it with initial data:

1. Open SQL Server Management Studio or any SQL Server client you prefer.
2. Connect to your local SQL Server or SQL Server LocalDB instance.
3. Execute the SQL script located in the `Database` directory of the cloned repository. You can do this by opening the `ZustSocialMediaApp.sql` file and running it in your SQL client.

The SQL script will create the database and tables required for the application, as well as insert some initial data.

## Set Connection String

After setting up the database, you need to configure the connection string in the application. Follow these steps to do so:

### Step 1: Update appsettings.json

1. Open the solution file (`Zust.sln`) using Visual Studio 2022.
2. Locate the `appsettings.json` file under the `Zust.Web` project.
3. In the `appsettings.json` file, find the `"ConnectionStrings"` section.
4. Replace the value of the `Default` key with your SQL Server connection string.

Example connection string:

```json
"ConnectionStrings": {
  "Default": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YourDatabaseName;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
},
```

Please ensure that your connection string points to the correct SQL Server instance and database name.

### Step 2: Update Constants.cs

1. In the Solution Explorer, locate the `Constants.cs` file under the `Zust.Web.Helpers.ConstantHelpers` namespace.
2. In the `Constants.cs` file, find the `ConnectionString` constant and replace its value with your SQL Server connection string.

Example connection string in Constants.cs:

```csharp
public const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YourDatabaseName;Integrated Security=True;";
```

Please ensure that your connection string points to the correct SQL Server instance and database name.

## Run the Application

Now that the database is set up, and the connection string is configured, you can run the application using Visual Studio 2022. Follow these steps:

1. Open the solution file (`Zust.sln`) in Visual Studio 2022.
2. Set the `Zust.Web` project as the startup project (right-click on the project in the Solution Explorer and select "Set as Startup Project").
3. Press F5 or click the "Start" button in Visual Studio to run the application.

The application will build, and a new browser window will open with Zust Social Media App up and running.

## Contributing

If you'd like to contribute to the project, feel free to fork the repository, make your changes, and submit a pull request.

## Issues and Support

If you encounter any issues or need support, please check the existing issues on the GitHub repository. If your issue isn't already reported, feel free to open a new one.

## License

Zust Social Media App is released under the [MIT License](LICENSE). Feel free to use, modify, and distribute the code as per the terms of the license.

---

Congratulations! You now have Zust Social Media App set up and ready to use with Visual Studio 2022. If you have any questions or need further assistance, please refer to the documentation or reach out to the community for support. Happy coding! 🚀