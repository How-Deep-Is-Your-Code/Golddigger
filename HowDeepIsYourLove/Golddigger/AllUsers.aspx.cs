namespace Golddigger
{
    using System;
    using System.Web.UI;

    public partial class AllUsers : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }
    }
}