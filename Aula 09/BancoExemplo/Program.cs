using System;
using System.Data;
using System.Data.SqlClient;

string dataSource = @"CT-C-0018C\SQLEXPRESS";   

// SqlConnectionStringBuilder stringConnectionBuilder = new SqlConnectionStringBuilder();
// stringConnectionBuilder.DataSource = dataSource; // Nome do servidor
// stringConnectionBuilder.InitialCatalog = "example"; // Nome do banco
// stringConnectionBuilder.IntegratedSecurity = true;
// string stringConnection = stringConnectionBuilder.ConnectionString;

// SqlConnection conn = new SqlConnection(stringConnection);
// conn.Open();

// SqlCommand comm = new SqlCommand("insert Cliente values ('Pamella', '123', CONVERT(DATETIME, '30/12/2023'));");
// comm.Connection = conn;
// comm.ExecuteNonQuery();
// conn.Close();

//----------------------------------------------------------------------------------------------------------------------------

SqlConnectionStringBuilder stringConnectionBuilder = new SqlConnectionStringBuilder();
stringConnectionBuilder.DataSource = dataSource;
stringConnectionBuilder.InitialCatalog = "example";
stringConnectionBuilder.IntegratedSecurity = true;
string stringConnection = stringConnectionBuilder.ConnectionString;
SqlConnection conn = new SqlConnection(stringConnection);
conn.Open();

string nome = Console.ReadLine();
string senha = Console.ReadLine();

nome = "'; drop table Cliente; --";

SqlCommand comm = new SqlCommand($"select * from Cliente where Nome = '{nome}' and Senha = '{senha}'");
comm.Connection = conn;
var reader = comm.ExecuteReader();
DataTable dt = new DataTable();
dt.Load(reader);
if (dt.Rows.Count > 0)
    Console.WriteLine($"Usuário {dt.Rows[0].ItemArray[0]} Logado");
else
    Console.WriteLine("Conta inexistente");
conn.Close();