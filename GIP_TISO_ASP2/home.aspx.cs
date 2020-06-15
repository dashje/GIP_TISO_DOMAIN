using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using GIP_TISO_DOMAIN.Business;

namespace GIP_TISO_ASP2
{
    public partial class home : System.Web.UI.Page
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

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker = _controller.getLogin(txtnaam.Text, txtpaswoord.Text);
            if (gebruiker != null)
            {
                Response.Redirect("loginscreen.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Wrong combination.')", true);
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("createaccount.aspx");
        }
    }
}