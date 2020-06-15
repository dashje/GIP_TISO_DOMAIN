using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_ASP2
{
    public partial class createaccount : System.Web.UI.Page
    {
         Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                _controller = (Controller)HttpContext.Current.Session["_controller"];
            }
            else
            {
                if (HttpContext.Current.Session["_controller"] == null)
                {
                    _controller = new Controller();
                    HttpContext.Current.Session["_controller"] = _controller;
                }
                else
                {
                    _controller = (Controller)HttpContext.Current.Session["_controller"];
                }
            }
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