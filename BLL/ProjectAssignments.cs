using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.DAL;

namespace ReviewForMidterm.BLL
{
    public class ProjectAssignments
    {
        public int StudentNumber { get; set; }
        public string ProjectCode { get; set; }
        public string AssignedDate { get; set; }
        public string SubmittedDate { get; set; }


        public List<ProjectAssignments> GetProjectAssignments()
        {
            return ProjectAssignmentDB.GetAllRecords();
        }

        public void AssignedProject(ProjectAssignments proAs)
        {
            ProjectAssignmentDB.SaveRecord(proAs);

        }
        //public List<Students> ListStudentsByProjectCode(string pCode)
        //{
        //    return ProjectAssignmentDB.listS(pCode);

        //}
        //public List<Projects> ListProjectsByStudentId(string sId)
        //{
        //    return ProjectAssignmentDB.listP(sID);

        //}


    }
}