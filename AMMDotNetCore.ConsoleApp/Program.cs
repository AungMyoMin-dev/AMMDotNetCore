using AMMDotNetCore.ConsoleApp;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

Console.WriteLine("Hello, World!");

SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
stringBuilder.DataSource = "DESKTOP-GRVHDSJ\\MYMSQLSQL";
stringBuilder.InitialCatalog = "AMMDotNetCore";
stringBuilder.UserID = "sa";
stringBuilder.Password = "sa123";

SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
connection.Open();
Console.WriteLine("Connection Open.");

string query = "select * from Tbl_Blog";
 SqlCommand cmd = new SqlCommand(query, connection);
SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(cmd);
DataTable dt = new DataTable();
SqlDataAdapter.Fill(dt); 

connection.Close();
Console.WriteLine("Connection Close");

foreach (DataRow dr in dt.Rows)
{
    Console.WriteLine("Blog Id =>"+dr["BlogId"]);
    Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
    Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
    Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
    Console.WriteLine("-------------------------------");
} 

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(11, "test title", "test author", "test content");
//adoDotNetExample.Delete(11);
//adoDotNetExample.Edit(11);
//adoDotNetExample.Edit(1);

DapperExample dapperExaple = new DapperExample();
dapperExaple.Run();

Console.ReadKey();

