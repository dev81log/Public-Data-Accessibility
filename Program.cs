using System;
using Microsoft.Data.SqlClient;

const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$";

var connection = new SqlConnection(connectionString);
