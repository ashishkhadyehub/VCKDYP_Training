using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.EMS
{
    public partial class EmployeeProfile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
           if(Request.QueryString["id"]!=null)
            {
                getData();
            }
           else
            {
                Response.Redirect("EmployeeList.aspx");
            }
        }

        protected void getData()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from EmpRegister where Srno=@EmployeeId", con);
            cmd.Parameters.AddWithValue("@EmployeeId", Request.QueryString["id"]);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                txtName.Text = sdr.GetValue(1).ToString();
                txtEmail.Text = sdr.GetValue(2).ToString();
                txtContact.Text = sdr.GetValue(3).ToString();
                ddldept.SelectedItem.Text = sdr.GetValue(4).ToString();

            }
        }
    }
}