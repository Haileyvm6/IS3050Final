<!-- 
*Name: Leah Radcliffe
* email:  radclilr @mail.uc.edu
* Assignment Number: IS 3050 Final Project
    Due Date:   12/ 10 / 2024
* CoursSection:   IS3050-001
* Semester / Year:   Fall 2024
* Brief Description of the assignment:  Solving a leetcode problem under the hard category. To then collaborate through Github to connect all the Leetcode problems
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadclilrWildCard.aspx.cs" Inherits="IS3050Final.RadclilrWildCard" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>WildCard-String Match</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtString" runat="server" placeholder="Enter string"></asp:TextBox>
            <asp:TextBox ID="txtPattern" runat="server" placeholder="Enter pattern"></asp:TextBox>
            <asp:Button ID="btnMatch" runat="server" Text="Check Match" OnClick="btnMatch_Click" />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
