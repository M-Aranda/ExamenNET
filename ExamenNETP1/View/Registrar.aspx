<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="ExamenNETP1.View.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar usuario</title>
    <script type="text/javascript" src="../JavaScript/js.js"></script><!-- Ojo con la ruta -->

    <script>
            function agregar() {
                var cor = $("#correo").val();
                var nom = $("#nombre").val();
                var aPat = $("#aPaterno").val();
                var aMat = $("#aMaterno").val();
                var la_clave = $("#clave").val();
                var fNac = $("#fechaDeNacimiento").val();
                //en data, el nombre que esta a la izquierda es el que hay que solicitar
                $.ajax({
                    type: 'POST',
                    url: '../Controller/RegistrarUsuario.ashx',
                    data: {
                        correo_usuario: cor,
                        nombres: nom,
                        aPaterno: aPat,
                        aMaterno: aMat,
                        clave: la_clave,
                        fechaNacimento: fNac
                    }
                })
            }
        </script>



</head>
<body>
    <h1>Registro de usuarios</h1>
    <form id="f1" method="post" action="" runat="server">

        <input type="text" id="correo" name="correo"  placeholder="Correo:" >
        <br>

        <input type="text" id="nombre" name="nombre" placeholder="Nombre:" >
        <br>
        <input type="text" id="aPaterno"  name="aPaterno" placeholder="Apellido paterno:" >
        <br>
        <input type="text"  id="aMaterno" name="aMaterno" placeholder="Apellido materno:" >
        <br>
        <input type="password" id="clave" name ="clave"  placeholder="Clave" >
        <br>
        <h3>Fecha de nacimiento: </h3><input type="date" id="fechaDeNacimiento" name="fechaDeNacimiento">
        <br>
        <input type="submit" value="Registrar" onclick="agregar()">

    </form>

</body>
</html>
