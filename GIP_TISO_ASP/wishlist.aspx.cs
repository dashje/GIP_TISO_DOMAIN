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
            Random r = new Random();
            int num = r.Next(1,9999);
            lblCode.Text = num.ToString();
            fillControls();
        }

        private void fillControls()
        {
            lbxCadeau.DataSource = _controller.getCadeausFromDB();
            lbxCadeau.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Cadeau cadeau = new Cadeau(txtName.Text, txtDescription.Text, txtWebsite.Text);
            _controller.addCadeausToDB(cadeau);
            fillControls();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _controller.deleteCadeauToDB(lbxCadeau.SelectedIndex);
            fillControls();
        }
    }
}