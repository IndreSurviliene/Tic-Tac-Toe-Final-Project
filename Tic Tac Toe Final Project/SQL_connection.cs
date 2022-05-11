using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Tic_Tac_Toe_Final_Project
{
    public class SQL_connection
    {
        string Nickname { get; set; }
        string Nickname2 { get; set; }
        public static void Main2()
        {
            Console.WriteLine("Getting Connection ...");
            
            var datasource = @"LAPTOP-V1DUSTDQ";
            var database = "TicTacToe_database";

            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Trusted_Connection = True;";
            Console.WriteLine(connString);

            string query = $"INSERT INTO [Players] VALUES('nickname', 'nickname2')";

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format($"{reader["nickname"]} {reader["nickname2"]}"));
                    }
                    Console.WriteLine("Command executed");
                }
                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();
        }
    }
}




        /*string datasource { get; set; }//your server
        string database { get; set; } //your database name
        string connString { get; set; }
        public SqlConnection conn { get; set; }
        string Nickname { get; set; }
        string Nickname2 { get; set; }
        public SQL_connection()
        {
            Console.WriteLine("Getting Connection....");
            var datasource = @"LAPTOP-V1DUSTDQ";
            var database = "TicTacToe_database";

            //var dbConnection = new SqlConnection(datasource);


            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Trusted_Connection = True;";

            Console.WriteLine(connString);
            conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening connection....");
                conn.Open();
                Console.WriteLine("Connection is successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            Console.Read();
            {
                try
                {
                    string query = $"INSERT INTO Players ( Nickname) VALUES('{Nickname}', '{Nickname2}'); ";
                    //SqlCommand cmd = new SqlCommand(query, dbConnection.conn);
                    SqlCommand cmd = new SqlCommand(query,conn);

                    var number = cmd.ExecuteNonQuery();
                    Console.WriteLine("Rows affected : " + number);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
                //conn.Close();
            }
        }
    }
}*/
