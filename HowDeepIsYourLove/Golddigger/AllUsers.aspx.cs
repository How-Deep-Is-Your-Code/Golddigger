﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Golddigger
{
    public partial class AllUsers : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}