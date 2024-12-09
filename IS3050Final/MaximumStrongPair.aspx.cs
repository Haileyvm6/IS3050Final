/*
 * Name: Jay Powell
 * Email: powela9@mail.uc.edu
 * Assignment Title: Final Project
 * Due Date: 12/10/2024
 * Course: IS 3050
 * Semester/Year: Fall 2024
 * Brief Description: This webpage is the backing code for the button press
 * Citations: https://www.w3schools.com/cs/cs_exceptions.php
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IS3050Final
{
    public partial class MaximumStrongPair : System.Web.UI.Page
    {
        protected void BtnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the input from the TextBox
                string input = TxtInput.Text;
                string[] inputArray = input.Split(',');
                int[] nums = Array.ConvertAll(inputArray, int.Parse);

                powela9 solver = new powela9();
                int result = solver.FindMaxXorOfStrongPairs(nums);

                LblResult.Text = "Maximum XOR of strong pairs: " + result;
            }
            catch (FormatException)
            {
                LblError.Text = "Invalid input. Please enter a comma-separated list of integers.";
            }
            catch (Exception ex)
            {
                LblError.Text = $"An error occurred: {ex.Message}";
            }
        }
    }
}