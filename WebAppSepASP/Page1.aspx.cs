﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSepASP
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndisplay_Click(object sender, EventArgs e)
        {
            lbldisplay.Visible = true;
            lbldisplay.Text = txtname.Text;
        }
    }
}