using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.BLL;
using System.Data.SqlClient;

namespace ReviewForMidterm.DAL
{
    public static class StudentDB
    {
        public static List<Students> GetAllRecords()
        {
            List<Students> listS = new List<Students>();
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("Select* FROM Students", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                Students stu;
                while(reader.Read())
                {
                    stu = new Students();
                    stu.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    stu.FirstName = reader["FirstName"].ToString();
                    stu.LastName = reader["LastName"].ToString();
                    stu.Password = reader["Password"].ToString();
                    listS.Add(stu);
                }

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
     
            }
       

            return listS;
        }
    }
}