<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ex3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type = "text/javascript">
        function ExibeMensagem() {
            alert("Olá Mundo");
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">    
    <asp:Image ID="Image1" runat="server" style="margin-right: 0px" /><img src="Images/img.jpg" style="height: 163px; width: 169px" />
          <div>
              <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
