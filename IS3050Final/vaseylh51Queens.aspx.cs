/*
* Name: Liam Vasey
*email:  vaseylh @mail.uc.edu
* Assignment Number: IS3050 Final
* Due Date:   12 / 10 / 2024
* Course #/Section:   IS3050-001
* Semester / Year:   Fall 2024
* Brief Description of the assignment:  Solving a leetcode problem that is hard and collaborating with other members using GitHub.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RevalatoryRavens_FinalProject
{
    public partial class vaseylh51Queens : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Optionally initialize anything here 
            }
        }
        // Add the N-Queens solving logic here 
        public IList<IList<string>> SolveNQueens(int n)
        {
            var results = new List<IList<string>>();
            var board = new char[n][];
            for (int i = 0; i < n; i++)
            {
                board[i] = new string('.', n).ToCharArray();
            }
            Solve(results, board, 0, n);
            return results;
        }
        private void Solve(List<IList<string>> results, char[][] board, int row, int n)
        {
            if (row == n)
            {
                var solution = new List<string>();
                for (int i = 0; i < n; i++)
                {
                    solution.Add(new string(board[i]));
                }
                results.Add(solution);
                return;
            }
            for (int col = 0; col < n; col++)
            {
                if (IsValid(board, row, col, n))
                {
                    board[row][col] = 'Q';
                    Solve(results, board, row + 1, n);
                    board[row][col] = '.';
                }
            }
        }
        private bool IsValid(char[][] board, int row, int col, int n)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i][col] == 'Q')
                {
                    return false;
                }
            }
            for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }
            for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
            {
                if (board[i][j] == 'Q')
                {
                    return false;
                }
            }
            return true;
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(TextBox1.Text, out n) && n >= 1 && n <= 9)
            {
                var solutions = SolveNQueens(n);
                Literal1.Text = "<br/>";
                foreach (var solution in solutions)
                {
                    foreach (var row in solution)
                    {
                        Literal1.Text += row + "<br/>";
                    }
                    Literal1.Text += "<br/>";
                }
            }
            else
            {
                Literal1.Text = "Please enter a valid number between 1 and 9.";
            }
        }
    }
}
