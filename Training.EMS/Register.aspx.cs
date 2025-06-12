using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.EMS
{
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("insert into EmpRegister values (@name,@email,@contact,@dept,@pwd)", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@dept", ddldept.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
            con.Open();
            cmd.ExecuteNonQuery();

            txtContact.Text = "";
            txtEmail.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            ddldept.SelectedIndex = 0;

            this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Registered Successfully..!','You can login now','success');", true);
        }





        //        CREATE TABLE[dbo].[EmpRegister]
        //        (

        //    [Srno][int] IDENTITY(1,1) NOT NULL,

        //    [Name] [nvarchar] (50) NULL,
        //	[Email][nvarchar] (50) NULL,
        //	[Contact][nvarchar] (50) NULL,
        //	[Dept][nvarchar] (50) NULL,
        //	[Password][nvarchar] (50) NULL,
        // CONSTRAINT[PK_EmpRegister] PRIMARY KEY CLUSTERED
        //(
        //    [Srno] ASC
        //)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON[PRIMARY]
        //) ON[PRIMARY]
    }
}