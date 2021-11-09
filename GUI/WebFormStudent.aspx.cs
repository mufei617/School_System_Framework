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
    public partial class ProjectAssignmentForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Students aStudent = new Students();
            List<Students> listS = aStudent.GetAllStuedents();
            foreach(Students s in listS)
            {
                DropDownListStudent.Items.Add(s.StudentNumber.ToString() + "," + s.FirstName + "," + s.LastName);
            }
            Projects proj = new Projects();
            List<Projects> listProj = proj.GetAllProjects();
            foreach(Projects p in listProj)
            {
                DropDownListProject.Items.Add(p.ProjectCode.ToString() + "," + p.ProjectTitle + "," + p.DueDate);

            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonListStudent_Click(object sender, EventArgs e)
        {
            Students stu = new Students();
            List<Students> listS = stu.GetAllStuedents();
            if (listS.Count!=0)
            {
                GridViewStudent.DataSource = stu.GetAllStuedents();
                GridViewStudent.DataBind();

            }
            else
            {
                MessageBox.Show("no student in the db", "empty list", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}