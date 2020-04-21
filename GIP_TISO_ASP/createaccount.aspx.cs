using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_ASP
{
    public partial class createaccount : System.Web.UI.Page
    {
        public Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            _controller = new Controller();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Gebruiker gebr = new Gebruiker(txtName.Text, txtMail.Text, Convert.ToInt16(txtAge.Text), rbnlGeslacht.SelectedItem.ToString(), txtPaswoord.Text);
            _controller.addGebruikersToDB(gebr);
            btnSubmit.Text = "User succesfully added.";
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}