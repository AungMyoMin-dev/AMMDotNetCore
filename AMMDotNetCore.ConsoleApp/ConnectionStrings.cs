using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMMDotNetCore.ConsoleApp
{
    internal static class ConnectionStrings
    {
        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        { 
            DataSource = "DESKTOP-GRVHDSJ\\MYMSQLSQL",
            InitialCatalog="AMMDotNetCore",
            UserID="sa",
            Password ="sa123"
        };
    }
}
