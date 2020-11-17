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
    
    </div>
    </form>
</body>
</html>
