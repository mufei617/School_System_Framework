using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.DAL;

namespace ReviewForMidterm.BLL
{
    public class Projects
    {
        public string ProjectCode { get; set; }
        public string ProjectTitle { get; set; }
        public DateTime DueDate { get; set; }
        
        public List<Projects> GetAllProjects()
        {
            return ProjectDB.GetAllRecords();
        }
    }
}