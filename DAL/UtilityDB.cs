using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;


namespace ReviewForMidterm.DAL
{
    public class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
         SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=LAPTOP-4BRTEML7\\SQLEXPRESS;database=ProjectAssignmentsDB;user=sa;password=limufei617";
            //conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectProjectAssignmentsDB"].ConnectionString;
            conn.Open();
         return conn;

        }
    }
}