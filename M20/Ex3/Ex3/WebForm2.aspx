<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Ex3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type ="text/javascript">
        var tam = 16;
        function IncText() {
            tam += 1;
            document.getElementById("p1").style.fontSize = tam + "px";
            document.getElementById("p2").style.fontSize = tam + "px";

        }

        function DecText() {
            tam -= 1;
            document.getElementById("p1").style.fontSize = tam + "px";
            document.getElementById("p2").style.fontSize = tam + "px";

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            +<asp:HyperLink ID="HyperLink2" runat="server" onClick="DecText()">Diminui</asp:HyperLink>
            <p id="p1"> Exemplo de como alterar o tamanho a fonte de um paragrafo </p>
             <p id="p2"> PSI - Módulo 19 </p>
        </div>
    </form>
</body>
</html>
