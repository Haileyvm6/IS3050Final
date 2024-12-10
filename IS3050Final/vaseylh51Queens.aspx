<!--
Name: Liam Vasey
* email:  vaseylh@mail.uc.edu
* Assignment Number: IS3050 Final
* Due Date:   12/10/2024
* Course #/Section:   IS3050-001
* Semester/Year:   Fall 2024
* Brief Description of the assignment:  Solving a leetcode problem that is hard and collaborating with other members using GitHub.
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vaseylh51Queens.aspx.cs" Inherits="RevalatoryRavens_FinalProject.vaseylh51Queens" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:Label ID="Label1" runat="server" Text="Enter a number (1-9)"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Solve N-Queens" OnClick="Button_Click" />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
