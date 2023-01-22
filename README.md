![Asher_Duarte_image_database_code_connect_driver_for_SQL_Server_9dab22a1-dcc0-489c-a411-e52ac3dc57bc (1)](https://user-images.githubusercontent.com/105469529/213921125-ed8789b2-5dbb-4b1d-84ad-617d48f696e1.png)
# OpenDataAccess
A simple C# project that demonstrates how to use the Dapper library to perform CRUD operations on a SQL Server database using the ADO.NET approach.

## Requirements
+ .NET Core 3.1 +
+ SQL Server

## Getting Started
1. Clone the repository
2. `git clone https://github.com/dev81log/OpenDataAccess.git`
3. Open the solution in Visual Studio
4. Update the connection string in the `Program.cs` file to match your SQL Server setup
5. Run the application

## Functionality
The application demonstrates the following functionality:

+ Retrieving data from a SQL Server table and displaying it on the console
+ Inserting data into a SQL Server table
+ Updating data in a SQL Server table

## Libraries used
+ [Dapper](https://github.com/DapperLib/Dapper): A simple object mapper for .NET
+ [Microsoft.Data.SqlClient](https://www.nuget.org/packages/Microsoft.Data.SqlClient): ADO.NET driver for SQL Server

### Note
You may have to adjust the query according to your database structure or create a new category table before running the code.
