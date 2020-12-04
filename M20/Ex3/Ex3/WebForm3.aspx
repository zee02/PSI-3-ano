<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Ex3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server"> 
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="111px" ImageUrl="~/Images/9e518b795195373dc89cc2a3b8d43461.png" OnClick="ImageButton1_Click" Width="146px" />
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="147px" ImageUrl="~/Images/img.jpg" OnClick="ImageButton2_Click" style="margin-right: 0px" Width="100px" />
                </asp:View>
                <asp:View ID="View2" runat="server">Olá eu sou o Fred&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Voltar</asp:LinkButton>
                </asp:View>
                <asp:View ID="View3" runat="server">&nbsp;Olá eu sou o Jonas&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Voltar</asp:LinkButton>
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
