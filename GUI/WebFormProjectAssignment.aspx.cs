using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ReviewForMidterm.BLL;
using ReviewForMidterm.DAL;
using System.Windows.Forms;

namespace ReviewForMidterm.GUI
{
    public partial class WebFormProjectAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Students aStudent = new Students();
            List<Students> listS = aStudent.GetAllStuedents();
            foreach (Students s in listS)
            {
                DropDownListStudent.Items.Add(s.StudentNumber.ToString() + "," + s.FirstName + "," + s.LastName);
            }
            Projects proj = new Projects();
            List<Projects> listProj = proj.GetAllProjects();
            foreach (Projects p in listProj)
            {
                DropDownListProject.Items.Add(p.ProjectCode.ToString() + "," + p.ProjectTitle + "," + p.DueDate);

            }
        }

        protected void ButtonAssigned_Click(object sender, EventArgs e)
        {

            string input = DropDownListStudent.SelectedValue;
            string[] field = input.Split(',');
            int id = Convert.ToInt32(field[0]);

            string input2 = DropDownListProject.SelectedValue;
            string[] field2 = input2.Split(',');
            string code = field2[0];
            ProjectAssignments proas = new ProjectAssignments();
            List<ProjectAssignments> listpa = proas.GetProjectAssignments();

            foreach(ProjectAssignments pa in listpa)
            {
                if((id ==pa.StudentNumber)&&(code == pa.ProjectCode))
                {
                    MessageBox.Show("This project has been assigned to this student.", "Already assigned");
                    return;
                }
            }

            proas.StudentNumber = id;
            proas.ProjectCode = code;
            proas.AssignedDate = CalendarAssignDate.SelectedDate.ToString();
            proas.SubmittedDate = " ";
            proas.AssignedProject(proas);
            MessageBox.Show("project ASsigned");
        }

        protected void DropDownListProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}