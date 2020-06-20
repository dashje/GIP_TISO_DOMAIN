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
    public partial class selectionScreen : System.Web.UI.Page
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
                    fillControls();
                }
            }
            private void fillControls()
            {
                lbxSelectionLists.DataSource = _controller.getCadeausFromGebruiker();
                lbxSelectionLists.DataBind();
            }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginscreen.aspx");
        }

        protected void lbxSelectionLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Lijst> ListsActiveUser = _controller.getCadeausFromGebruiker();
            LijstHasCadeau item = _controller.getLijstFromID(ListsActiveUser[lbxSelectionLists.SelectedIndex].ID);

            _controller.setCurrentLijstID(item);
            Response.Redirect("ownList.aspx");
        }


    }
}