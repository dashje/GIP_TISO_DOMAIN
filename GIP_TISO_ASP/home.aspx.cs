using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using GIP_TISO_DOMAIN.Business;

namespace GIP_TISO_ASP
{
    public partial class home : System.Web.UI.Page
    {
        public Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            _controller = new Controller();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker = _controller.getLogin(txtnaam.Text, txtpaswoord.Text);
            if (gebruiker != null)
            {
                Response.Redirect("loginscreen.aspx");
            }
            else
            {
                btnLogin.Text = "Wrong combination.";
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("createaccount.aspx");
        }
    }
}