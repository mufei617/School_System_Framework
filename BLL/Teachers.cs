using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewForMidterm.DAL;

namespace ReviewForMidterm.BLL
{
    public class Teachers
    {
        public int teacherNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public List<Teachers> GetAllTeachers()
        {
            return TeacherDB.GetAllRecords();
        }
        public bool ValidateUser(int id, string password)
        {
            return TeacherDB.ValidateUser(id, password);
        }

        public Teachers SearchTeacherByID(int id)
        {
            return TeacherDB.SearchTeacherByID(id);
        }
    }
}