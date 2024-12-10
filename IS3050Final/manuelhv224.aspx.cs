/*
# Name: Hailey Manuel
# email: manuelhv@mail.uc.edu
# Assignment Title: Final Assignment
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project is designing a website to show off leetcode problems
# Citations: My team!
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
    public partial class manuelhv224 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            string expression = txtExpression.Text;
            int result = new manuelhv224class().Calculate(expression);
            lblResult.Text = "Result: " + result.ToString();

        }
    }
}