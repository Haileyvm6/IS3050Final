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

namespace RevalatoryRavens_FinalProject
{
    public class manuelhv224class
    {
        public int Calculate(string s)
        {
            Stack<int> stack = new Stack<int>();
            int sign = 1, num = 0, res = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    num = num * 10 + (c - '0');
                }
                else if (c == '+')
                {
                    res += sign * num;
                    num = 0;
                    sign = 1;
                }
                else if (c == '-')
                {
                    res += sign * num;
                    num = 0;
                    sign = -1;
                }
                else if (c == '(')
                {
                    stack.Push(res);
                    stack.Push(sign);
                    res = 0;
                    sign = 1;
                }
                else if (c == ')')
                {
                    res += sign * num;
                    res *= stack.Pop(); 
                    res += stack.Pop(); 
                    num = 0;
                }
            }

            res += sign * num;
            return res;
        }

    }
}