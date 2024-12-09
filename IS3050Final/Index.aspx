<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="IS3050Final.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Final Leet Code Problems</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Final Leet Code Problems</h1>
            <h2> Select a problem to solve: </h2>

            <h3> Leah's Problem: </h3>
            <p> Determine if a given input string matches a pattern, where ? can match any single character, and * can 
                match any sequence of characters, including an empty sequence. The pattern must match the entire string, 
                not just a part of it. Examples demonstrate cases where a single character or wildcard character either 
                matches or does not match the input string. The solution handles strings and patterns up to a 
                length of 2000 characters, containing only lowercase English letters, ?, or *.
            </p>
            <asp:Button ID="BtnWildCard" runat="server" Text="Wild Card" OnClick="BtnWildCard_Click" />

            <h3> Hailey's Problem:</h3>
            <p> Evaluate a simple math expression given as a string. It can handle numbers, addition (+), subtraction (-), and parentheses to 
                group operations. For example, if the input is "1 + (2 - 3)", the calculator returns 0. It does not include multiplication, 
                division, or more advanced math operations.</p>
            <asp:Button ID="BtnBasicCalc" runat="server" Text="Basic Calculator" OnClick="BtnBasicCalc_Click" />

            <h3>Liam's Problem: </h3>
            <p>Place n queens on an n x n chessboard so that no two queens can attack each other. The goal is to return all unique configurations
                of the board where the queens are safely positioned. The board is represented with 'Q' for queens and '.' for empty spaces.</p>
            <asp:Button ID="BtnNQueens" runat="server" Text="N Queens" OnClick="BtnNQueens_Click" />

            <h3> Jay's Problem: </h3>
            <p>Given a 0-indexed integer array nums, identify two integers that form a "strong pair." A pair (x, y) is strong if the condition 
                |x - y| ≤ min(x, y) is satisfied. Among all possible strong pairs, find the one with the maximum bitwise XOR value and return 
                that value. The solution handles arrays of up to 50,000 integers
            </p>
            <asp:Button ID="BtnStrongPair" runat="server" Text="Maximum Strong Pair" OnClick="BtnStrongPair_Click" />
        </div>
    </form>
</body>
</html>
