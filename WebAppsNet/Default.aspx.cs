using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppsNet
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hi, This is Default.aspx");
            Response.Write("Hi, This is Default.aspx,This is not yet staged");
        }
    }
}