using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Book11._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Try to connect SQL Server...");
                SqlConnection sqlConn = new SqlConnection("server=localhost;database=db;uid=sa;pwd=123");
                sqlConn.Open();
                if (sqlConn.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connect SQL Server Succeed!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
