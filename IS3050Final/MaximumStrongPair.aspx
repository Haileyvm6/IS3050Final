<%-- 
Name: Jay Powell
Email: powela9@mail.uc.edu
Assignment Title: Final Project
Due Date: 12/10/2024
Course: IS 3050
Semester/Year: Fall 2024
Brief Description: This webpage has a button linking to a C# code to solve a MaximumStrongPair 
Citations: 
 --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaximumStrongPair.aspx.cs" Inherits="RevalatoryRavens_FinalProject.MaximumStrongPair" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Maximum Strong Pair</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Maximum Strong Pair Solver</h1>
            <p>
                Enter a list of numbers, and this tool will find the largest XOR value of any strong pair. A strong pair is two numbers (x,y) such that ∣x−y∣ ≤ min⁡(x,y).
            </p>
            <p>Enter numbers separated by commas:</p>
            <asp:TextBox ID="TxtInput" runat="server" Width="300px" />
            <br /><br />
            <asp:Button ID="BtnSolve" runat="server" Text="Solve" OnClick="BtnSolve_Click" />
            <br /><br />
            <asp:Label ID="LblResult" runat="server" Text="" ForeColor="Green"></asp:Label>
            <br />
            <asp:Label ID="LblError" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
