/*
# Name: Jay Powell
# email: powela9@mail.uc.edu
# Assignment Title: Final Assignment
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: The backing code to the index file that handles the button clicks
# Citations: https://stackoverflow.com/questions/5142341/how-can-i-link-two-asp-pages-in-net
# Anything else that's relevant: Nothing
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RevalatoryRavens_FinalProject
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
            Response.Redirect("vaseylh51Queens.aspx");
        }

        protected void BtnStrongPair_Click(object sender, EventArgs e)
        {
            Response.Redirect("MaximumStrongPair.aspx");
        }
    }
}