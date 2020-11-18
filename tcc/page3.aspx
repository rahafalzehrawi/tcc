<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="tcc.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;:
        <asp:TextBox ID="nametextbox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
&nbsp;:<asp:TextBox ID="agetextbox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnviewstate" runat="server" OnClick="btnviewstate_Click" Text="Add View State" />
        <br />
        <br />
        <asp:Button ID="btnview" runat="server" OnClick="btnview_Click" Text="view" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnquerystring" runat="server" Text="go to page4(query string)" OnClick="btnquerystring_Click" />
    
        <br />
        <br />
        <br />
        <asp:Button ID="btnsession" runat="server" OnClick="btnsession_Click" Text="Set session" />
        <br />
        <br />
        <asp:Button ID="BtnCookie" runat="server" OnClick="BtnCookie_Click" Text="set Cookie" />
    <input type="hidden" value="welcom to ASP.net" />
        <br />
        <br />
        <asp:Button ID="btnApplication" runat="server" OnClick="btnApplication_Click" Text="Application" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
