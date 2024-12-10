/*
 * Name: Jay Powell
 * Email: powela9@mail.uc.edu
 * Assignment Title: Final Project
 * Due Date: 12/10/2024
 * Course: IS 3050
 * Semester/Year: Fall 2024
 * Brief Description: This webpage solves the leet code problem on button press
 * Citations: Gemini
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RevalatoryRavens_FinalProject
{
    public class powela9
    {
        /// <summary>
        /// Finds the maximum XOR value among all strong pairs in the input array.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>The maximum XOR value of any strong pair.</returns>
        public int FindMaxXorOfStrongPairs(int[] nums)
        {
            int maxXor = 0;

            // Iterate through each pair of numbers
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // Check if the current pair is a strong pair
                    if (IsStrongPair(nums[i], nums[j]))
                    {
                        // Calculate the XOR and update the maximum if needed
                        int currentXor = nums[i] ^ nums[j];
                        maxXor = Math.Max(maxXor, currentXor);
                    }
                }
            }

            return maxXor;
        }

        /// <summary>
        /// Determines if two numbers form a strong pair based on the given condition.
        /// </summary>
        /// <param name="x">First number.</param>
        /// <param name="y">Second number.</param>
        /// <returns>True if the pair is a strong pair, otherwise false.</returns>
        private bool IsStrongPair(int x, int y)
        {
            return Math.Abs(x - y) <= Math.Min(x, y);
        }
    }
}