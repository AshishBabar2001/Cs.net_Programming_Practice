using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Insert_Update_Delete_Form
{
    public partial class Application_Form : System.Web.UI.Page
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Student_Register_DB;Integrated Security=True");
        
        void SCon_Open()
        {
            if (true)
            {
                Con.Open();
            }       
        }

        void SCon_Closed()
        {
           Con.Close();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(Auto_Incr());
        }

        int Auto_Incr()
        {
            SCon_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Students_Details ";

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(SID) From Students_Details ";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 1;

            }

            SCon_Closed();

            return Cnt;
        }

        void ShowMessage(string msg)  
        {  
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('" + msg + "');</script>");  
        }  
        void clear()  
        {  
            txtID.Text = Convert.ToString(Auto_Incr()); 
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";  
            txtEmail.Text = "";  
            txtName.Focus();  
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        { 
                SCon_Open();
                if (txtName.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && txtAddress.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Insert into Students_Details (SID,Name,Address,Mobile,Email ) values (@ID,@Name,@Address,@Mobile,@Email)", Con);
                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    cmd.ExecuteNonQuery();

                    cmd.Dispose();
                    ShowMessage("Registered successfully......!");

                    clear(); 
                }
                else
                {
                    ShowMessage("Please, Fill All The Records");
                }

                SCon_Closed();

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
              
                SCon_Open();  

                if (txtID.Text != "")
            	{
		        SqlCommand cmd = new SqlCommand("update Students_Details Set Name=@Name,Address=@Address,Mobile=@Mobile,Email=@Email where SID = @SID", Con);  
                cmd.Parameters.AddWithValue("@Name", txtName.Text);  
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);  
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);  
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);  
                cmd.Parameters.AddWithValue("@SID",txtID.Text);  
                cmd.ExecuteNonQuery();  
                cmd.Dispose(); 
 
                ShowMessage("Student Data update Successfully......!"); 
	            } 
                else
	            {
                    ShowMessage("Enter Roll No First");
	            }

                SCon_Closed();
            }
    }
}
