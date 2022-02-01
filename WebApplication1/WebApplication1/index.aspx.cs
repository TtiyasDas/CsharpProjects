using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.DataConnection;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentIDBConnection studentIDBConnectionObj = new StudentIDBConnection();
            DataTable dtResult = studentIDBConnectionObj.SelectStudent();
            gvStudentDeatils.DataSource = dtResult;
            gvStudentDeatils.DataBind();
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            StudentIDBConnection studentIDBConnectionObj = new StudentIDBConnection();
            StudentModel studentModel = new StudentModel(); 
            studentModel.Roll = Convert.ToInt32(txtRoll.Text);
            studentModel.Name = txtName.Text;
            studentModel.Email = txtEmail.Text;
            studentModel.Age = Convert.ToInt32(txtAge.Text);

            string msg = studentIDBConnectionObj.InsertStudent(studentModel);
            lblResult.Text = msg;

            DataTable dtResult = studentIDBConnectionObj.SelectStudent();
            gvStudentDeatils.DataSource = dtResult;
            gvStudentDeatils.DataBind();
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
          
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            StudentIDBConnection studentIDBConnectionObj = new StudentIDBConnection();
            DataTable dtResult = studentIDBConnectionObj.EditStudentbyRoll(Convert.ToInt32(txtRoll.Text));
            txtName.Text = dtResult.Rows[0][1].ToString();
            txtEmail.Text = dtResult.Rows[0][2].ToString();
            txtAge.Text = dtResult.Rows[0][3].ToString();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}