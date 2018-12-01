<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="ExamenNETP1.View.Registrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registrar usuario</title>
    <script type="text/javascript" src="../JavaScript/js.js"></script><!-- Ojo con la ruta -->

    <script>
            function agregar() {
                var cor = $("#correo").val();
                var sex = $(".sexo:checked").val();
                var tipo = $(".tipo:checked").val();
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
                        tipo_usuario: tipo,
                        sexo: sex,
                        aPaterno: aPat,
                        aMaterno: aMat,
                        clave: la_clave,
                        fechaNacimento: fNac
                    }
                })
                alert("Usuario registrado");
                document.getElementById('correo').value = '';
                document.getElementById('nombre').value = '';
                document.getElementById('aPaterno').value = '';
                document.getElementById('aMaterno').value = '';
                document.getElementById('clave').value = '';
            }
        </script>
    <!--  la fecha de nacimiento no debiese ser null-->


</head>
<body>
    <h1>Registro de usuarios</h1>
    

        <input type="text" id="correo" name="correo"  placeholder="Correo:" required>
        <br>
        <h4>Sexo: </h4>
        Masculino <input type="radio" class="sexo" name="sexo" value="Hombre" checked>
        <br>
        Femenino <input type="radio" class="sexo" name="sexo" value="Mujer">
        <h4>Tipo de usuario: </h4>
        Denunciante <input type="radio" class="tipo" name="tipo" value="Denunciante" checked>
        <br>
        Profesional <input type="radio" class="tipo" name="tipo" value="Profesional">
        <br>
        <input type="text" id="nombre" name="nombre" placeholder="Nombre:" required >
        <br>
        <input type="text" id="aPaterno"  name="aPaterno" placeholder="Apellido paterno:" required >
        <br>
        <input type="text"  id="aMaterno" name="aMaterno" placeholder="Apellido materno:" required>
        <br>
        <input type="password" id="clave" name ="clave"  placeholder="Clave" required>
        <br>
        <h3>Fecha de nacimiento: </h3><input type="date" id="fechaDeNacimiento" name="fechaDeNacimiento">
        <br>
        <input type="submit" value="Registrar" onclick="agregar()">
        
    <br>
    <a href="Default.aspx">Volver</a>

</body>
</html>
