using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.DAL;

namespace ReviewForMidterm.BLL
{
    public class Students
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public List<Students> GetAllStuedents()
        {
            return StudentDB.GetAllRecords();
        }
    }
}