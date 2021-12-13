using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Student_Registration_Form
{
    public partial class Student : System.Web.UI.Page
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Student_Register_DB;Integrated Security=True");

        void SCon_Open()
        {
            
                Con.Open();
            
        }

        void SCon_Closed()
        {
            
                Con.Close();
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void Clear()
        {
            tb_Name.Text = "";
            tb_Password.Text = "";
            tb_Confirm_Password.Text = "";
            tb_Gmail.Text = "";
            rb_Gender.SelectedValue = "";
            Ddl_City.SelectedValue = "";
            tb_Name.Focus();
        }
            
        protected void btn_Register_Click(object sender, EventArgs e)
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Insert Into tbllogin Values(@Name,@Password,@City,@Gender,@Mail)";
            Cmd.Parameters.AddWithValue("Name",tb_Name.Text);
            Cmd.Parameters.AddWithValue("Password", tb_Password.Text);
            Cmd.Parameters.AddWithValue("City", Ddl_City.SelectedValue);
            Cmd.Parameters.AddWithValue("Gender",rb_Gender.SelectedValue);
            Cmd.Parameters.AddWithValue("Mail",tb_Gmail.Text);

            Cmd.ExecuteNonQuery();

            Response.Write("<Script Language = 'JavaScirpt'>alert('Register Succesfully'</Script>)");

            Clear();


            
            SCon_Closed();
        }
    }
}