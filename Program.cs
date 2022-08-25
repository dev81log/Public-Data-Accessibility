using System;
using Dapper;
using Microsoft.Data.SqlClient;
using OpenDataAccess.Models;

namespace OpenDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True";

            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon AWS";
            category.Url = "amazonaws.com";
            category.Summary = "AWS Cloud";
            category.Order = 8;
            category.Description = "Amazon Web Services (AWS) is a web service that makes it easy to deploy";
            category.Featured = false;

            var insertSql = @"INSERT INTO [Category] 
                            VALUES(
                                @Id,
                                @Title,
                                @Url,
                                @Summary,
                                @Order,
                                @Description,
                                @Featured
                            )";

            using (var connection = new SqlConnection(connectionString))
            {
                var rows = connection.Execute(insertSql, new
                {
                    category.Id,
                    category.Title,
                    category.Url,
                    category.Summary,
                    category.Order,
                    category.Description,
                    category.Featured
                });
                Console.WriteLine($"{rows} rows inserted");

                var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");
                foreach (var item in categories)
                {
                    Console.WriteLine($"{item.Id} - {item.Title}");
                }
            }
        }


    }
}