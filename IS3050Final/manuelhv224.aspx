<!-- 
# Name: Hailey Manuel
# email: manuelhv@mail.uc.edu
# Assignment Title: Final Assignment
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project is designing a website to show off leetcode problems
# Citations: My team!
# Anything else that's relevant: Nothing
    -->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="manuelhv224.aspx.cs" Inherits="RevalatoryRavens_FinalProject.manuelhv224" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>"Basic Calculator" </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <asp:TextBox ID="txtExpression" runat="server"></asp:TextBox>

            <asp:Button ID="btnCalculate" runat="server" Text="Solve" OnClick="btnCalculate_Click" />

            <br />

            <asp:Label ID="lblResult" runat="server" Text="Result: "></asp:Label>

        </div>
    </form>
</body>
</html>
