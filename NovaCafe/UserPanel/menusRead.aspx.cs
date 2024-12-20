﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NovaCafe.UserPanel
{
    public partial class menusRead : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack && Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["pid"]);
                Products p = dm.GetProduct(id);
                if (p.IsActive)
                {
                    ltrl_breakfastName.Text = p.Name;
                    ltrl_content.Text = p.Content;
                    ltrl_breakfastPrice.Text = p.Price.ToString();
                    ltrl_img.Text = "<img class=\"text-center w-100\"  src='../Images/" + p.Photo + "'/>";
                }
                else
                {
                    Response.Redirect("Index.aspx");
                }
               

            }

        }
    }
}