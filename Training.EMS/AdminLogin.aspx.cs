﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training.EMS
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="admin@gmail.com" && txtPassword.Text=="admin")
            {
                Session["Admin"] = "True";
                Response.Redirect("EmployeeList.aspx");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", "swal('Invalid Credentials..!','Please try again','error');", true);
            }
        }
    }
}