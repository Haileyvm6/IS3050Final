/*
*Name: Leah Radcliffe
* email:  radclilr @mail.uc.edu
* Assignment Number: IS 3050 Final Project
    Due Date:   12 / 10 / 2024
* CoursSection:   IS3050 - 001
* Semester / Year:   Fall 2024
* Brief Description of the assignment:  Solving a leetcode problem under the hard category. To then collaborate through Github to connect all the Leetcode problems
*/
using System;
using System.Web.UI;

namespace RevalatoryRavens_FinalProject
{
    public partial class RadclilrWildCard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnMatch_Click(object sender, EventArgs e)
        {
            string s = txtString.Text;
            string p = txtPattern.Text;

            Solution solution = new Solution();
            bool isMatch = solution.isMatch(s, p);

            lblResult.Text = isMatch ? "Pattern matches the string!" : "Pattern does not match the string.";
        }
    }
}
