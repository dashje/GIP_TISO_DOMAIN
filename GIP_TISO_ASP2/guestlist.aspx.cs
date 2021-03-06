﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_TISO_DOMAIN.Business;
using MySql.Data.MySqlClient;

namespace GIP_TISO_ASP2
{
    public partial class guestlist : System.Web.UI.Page
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
            Lijst oldLijst = _controller.getCurrentLijst();
            lblInformatie.Text = "Je zit in de lijst: " + oldLijst.Name;
            List<string> hulpLijst = new List<string>();
            foreach(Cadeau item in _controller.getCadeausFromCode(oldLijst.ID))
            {
                hulpLijst.Add(item.ToString(2));
            }
            lbxWishlist.DataSource = hulpLijst;
            lbxWishlist.DataBind();
           
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("loginscreen.aspx");
        }

        protected void btnBought_Click(object sender, EventArgs e)
        {
            _controller.changeStatus(lbxWishlist.SelectedIndex,"Ja");
        }
    }
}