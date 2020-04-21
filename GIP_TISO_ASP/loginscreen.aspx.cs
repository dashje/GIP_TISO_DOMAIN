using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIP_TISO_ASP
{
    public partial class loginscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreateWishlist_Click(object sender, EventArgs e)
        {
            Response.Redirect("wishlist.aspx");
        }
    }
}