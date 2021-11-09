using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.BLL;
using System.Data.SqlClient;

namespace ReviewForMidterm.DAL
{
     public static class ProjectDB
    {
        public static List<Projects> GetAllRecords()
        {
            List<Projects> listP = new List<Projects>();
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("Select* FROM Projects", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
            Projects prj;
            while (reader.Read())
            {
                prj = new Projects();
                prj.ProjectCode = reader["ProjectCode"].ToString();
                prj.ProjectTitle = reader["ProjectTitle"].ToString();
                prj.DueDate =  Convert.ToDateTime(reader["DueDate"]);
                listP.Add(prj);
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

            return listP;
        }
    }
}