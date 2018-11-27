<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="ExamenNETP1.View.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar</title>
    <style type="text/css">
        #form1 {
            height: 602px;
        }
    </style>
</head>
<body style="margin-bottom: 416px">
    <form id="form1" runat="server">
    <h1 style="width: 136px">Registrar</h1>

        <asp:Label ID="lblCorreo" runat="server" Text="Correo:"></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSexo" runat="server" Text="Sexo:"></asp:Label>
        <asp:RadioButtonList ID="rbtSexo" runat="server" Width="242px">
            <asp:ListItem>Hombre</asp:ListItem>
            <asp:ListItem>Mujer</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="lblTipoDeUsuario" runat="server" Text="Tipo de usuario:"></asp:Label>
        <br />
        <asp:Label ID="lblNombres" runat="server" Text="Nombres:"></asp:Label>
        <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellidoPaterno" runat="server" Text="Apellido paterno:"></asp:Label>
        <asp:TextBox ID="txtApellidoPaterno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblApellidoMaterno" runat="server" Text="Apellido materno:"></asp:Label>
        <asp:TextBox ID="txtApellidoMaterno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
        <asp:TextBox ID="txtClave" textMode="Password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblFechaDeNacimiento" runat="server" Text="Fecha de nacimiento:"></asp:Label>
        <asp:TextBox ID="txtFechaDeNacimiento" runat="server" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Calendar ID="calFNac" runat="server" OnSelectionChanged="fechaElegida"></asp:Calendar>
        <br />
        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" Width="104px" />
    </form>

</body>
</html>
