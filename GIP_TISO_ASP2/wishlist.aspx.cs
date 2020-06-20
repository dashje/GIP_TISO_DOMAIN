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
    public partial class wishlist : System.Web.UI.Page
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
                int code = _controller.GetCode();
                lblCode.Text = "";
                fillControls();
            }
            
        }

        private void fillControls()
        {
            lbxAllCadeaus.DataSource = _controller.getCadeausFromDB();
            lbxAllCadeaus.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Gebruiker gebruiker = _controller.getActiveGebruiker();
            Lijst lijst = new Lijst(txtName.Text, lblCode.Text, "Ja", gebruiker.ID);
            Cadeau cadeau = new Cadeau(txtName.Text, txtDescription.Text, txtWebsite.Text);
            _controller.addCadeausToDB(cadeau);
            fillControls();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _controller.removeCadeauFromWishlist(LbxCurrentList.SelectedIndex);
            fillControls();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginscreen.aspx");
        }

        protected void BtnCreateList_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            BtnCreateList.Visible = false;
            BtnToMyList.Visible = true;
            BtnFromMyList.Visible = true;
            Lijst lijst = _controller.CreateList(txtNameList.Text);
            lblCode.Text = lijst.Code;
            //De lijst is nodig maar ik heb hem hier niet nodig.

        }

        protected void BtnToMyList_Click(object sender, EventArgs e)
        {
            int selectedGiftIndex = lbxAllCadeaus.SelectedIndex;
            Cadeau item = _controller.addCadeauToList(selectedGiftIndex);
            LbxCurrentList.Items.Add(item.ToString());

        }

        protected void BtnFromMyList_Click(object sender, EventArgs e)
        {
            int selectedGiftIndex = LbxCurrentList.SelectedIndex;
            _controller.removeCadeauFromWishlist(selectedGiftIndex);
            LbxCurrentList.Items.RemoveAt(selectedGiftIndex);
            
        }
    }
}