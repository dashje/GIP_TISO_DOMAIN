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
    public partial class loginscreen : System.Web.UI.Page
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

        protected void btnCreateWishlist_Click(object sender, EventArgs e)
        {
            Response.Redirect("wishlist.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Lijst lijst = _controller.getLijst(txtLogin.Text);
            if (lijst != null)
            {
                _controller.setCurrentLijst(lijst);
                Response.Redirect("guestlist.aspx");
                //hij moet hier een verschil maken tussen deze knop en de knop voor een wishlist te maken. Hier moet hij de actieve gebruiker onthouden.
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Wrong combination.')", true);
            }
        }

        protected void btnSeeWishlist_Click(object sender, EventArgs e)
        {
            Response.Redirect("selectionScreen.aspx");
        }
    }
}