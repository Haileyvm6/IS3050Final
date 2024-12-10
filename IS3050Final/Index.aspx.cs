using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IS3050Final
{
    public partial class Index : System.Web.UI.Page
    {
        protected void BtnWildCard_Click(object sender, EventArgs e)
        {
            Response.Redirect("RadclilrWildCard.aspx");
        }

        protected void BtnBasicCalc_Click(object sender, EventArgs e)
        {
            Response.Redirect("manuelhv224.aspx");
        }

        protected void BtnNQueens_Click(object sender, EventArgs e)
        {
           
        }

        protected void BtnStrongPair_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaximumStrongPair.aspx");
        }
    }
}