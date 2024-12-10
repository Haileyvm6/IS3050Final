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
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevalatoryRavens_FinalProject
{
    public class Solution
    {
        public bool isMatch(string s, string p)
        {
            int m = s.Length, n = p.Length; // Use Length with a capital 'L'
            bool[,] dp = new bool[m + 1, n + 1];
            dp[0, 0] = true;

            // Initialize dp[0,j] (when s is empty)
            for (int j = 1; j <= n; ++j)
            {
                if (p[j - 1] == '*')
                {
                    dp[0, j] = dp[0, j - 1];
                }
            }

            // Fill the DP table
            for (int i = 1; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (p[j - 1] == '*')
                    {
                        dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
                    }
                    else if (p[j - 1] == '?' || s[i - 1] == p[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                }
            }

            return dp[m, n];
        }
    }
}
