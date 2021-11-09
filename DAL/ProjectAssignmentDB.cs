using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.BLL;
using ReviewForMidterm.DAL;
using System.Data.SqlClient;

namespace ReviewForMidterm.DAL
{
    public static class ProjectAssignmentDB
    {
      //public static  List<Projects> listP(int sID)
      //  {
      //      List<Projects> List_P = new List<Projects>();
      //      return List_P;
      //  }
      //  public static  List<Students> listS(int pCode)
      //  {
      //      List<Students> List_S = new List<Students>();
      //      return List_S;
      //  }

        public static void SaveRecord(ProjectAssignments pa)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "INSERT INTO PROJECTASSIGNMENTS (StudentNumber,ProjectCode,AssignedDate,SubmittedDate)" + 
                                    "Values(@StudentNumber,@ProjectCode,@AssignedDate,@SubmittedDate)";
            cmdInsert.Parameters.AddWithValue("@StudentNumber", pa.StudentNumber);
            cmdInsert.Parameters.AddWithValue("@ProjectCode", pa.ProjectCode);
            cmdInsert.Parameters.AddWithValue("@AssignedDate", pa.AssignedDate);
            cmdInsert.Parameters.AddWithValue("@SubmittedDate", pa.SubmittedDate);
            cmdInsert.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();

        }

        public static List<ProjectAssignments> GetAllRecords()
        {
            List<ProjectAssignments> listAllProjectAssignments = new List<ProjectAssignments>();
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdSelectAll = new SqlCommand("Select* FROM ProjectAssignments", conn);
                SqlDataReader reader = cmdSelectAll.ExecuteReader();
                ProjectAssignments pa;
                while (reader.Read())
                {
                    pa = new ProjectAssignments();
                    pa.StudentNumber = Convert.ToInt32(reader["StudentNumber"]);
                    pa.ProjectCode = reader["ProjectCode"].ToString();
                    listAllProjectAssignments.Add(pa);
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();

            }

            return listAllProjectAssignments;
        }
    }
}