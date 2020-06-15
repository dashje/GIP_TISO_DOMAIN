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
    public partial class loginscreen : System.Web.UI.Page
    {
        public Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            //_controller = new Controller
        }

        protected void btnCreateWishlist_Click(object sender, EventArgs e)
        { 
            Response.Redirect("wishlist.aspx");
        }
    }
}