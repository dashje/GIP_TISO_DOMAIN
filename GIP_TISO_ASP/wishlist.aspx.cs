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
    public partial class wishlist : System.Web.UI.Page
    {
        public Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            _controller = new Controller();
            fillControls();
        }

        private void fillControls()
        {
            lbxCadeau.DataSource = _controller.getCadeausFromDB();
            lbxCadeau.DataBind();
        }
    }
}