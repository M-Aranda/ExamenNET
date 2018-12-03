<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Denunciar.aspx.cs" Inherits="ExamenNETP1.View.Denunciar" %>
<%@ Import Namespace="ExamenNETP1.Model" %>
<%@ Import Namespace="ExamenNETP1.Controller" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hacer una denuncia</title>
    <script type="text/javascript" src="../JavaScript/js.js"></script><!-- Ojo con la ruta -->

    <script>
            function prepararDenuncia() {
                var cor = $("#correo").val();
                var com = $("#comuna option:selected").val();
                //var desc = $("#descripcion").val();
               var desc = $('textarea#descripcion').val();
                

                //en data, el nombre que esta a la izquierda es el que hay que solicitar
                $.ajax({
                    type: 'POST',
                    url: '../Controller/RegistrarDenuncia.ashx',
                    data: {
                        correo_usuario: cor,
                        descripcion: desc,
                        comuna: com
                    }
                })
                document.getElementById('correo').value = '';
                document.getElementById('descripcion').value = '';
                alert("Solicitud procesada");
                if (cor === "" || cor == null) {
                    alert("Debe ingresar un correo ya registrado.");
                }
                window.location = "../Controller/GenerarNumeroDeSeguimiento.ashx";//esta linea la pongo para generar el numero de seguimiento
        }

       /* function redirigirAHandlerDeNDeSeguimiento(){
                var cor = $("#correo").val();
                $.ajax({
                    type: 'POST',
                    url: '../Controller/GenerarNumeroDeSeguimiento.ashx',
                    data: {
                        correo: cor
                    }
                })
            window.location = "../Controller/GenerarNumeroDeSeguimiento.ashx";
        }
        */
        </script>
    
</head>
<body>
    <h2>Denunciar</h2>
    <br>
   
    <input type="text" id="correo" name="correo" placeholder="Correo de usuario:" required>
    <br>
    <%  BDEXAMDataContext bd = new BDEXAMDataContext();
        List<ExamenNETP1.Controller.Comuna> listadoDeComunas =bd.Comunas.Select(x => x).ToList();

        %>

  
    <select id="comuna" name="comuna">
    <%foreach (ExamenNETP1.Controller.Comuna com in listadoDeComunas)
        {%>

        <option value="<%=com.id_comuna%>"> <%=com.nombre_comuna%> </option>

      <%  } %>
    
    </select>
    <br>
    <h3>Descripción del caso</h3>
    <textarea rows="10" cols="50" id="descripcion" name="descripcion"></textarea>
    <!-- <input type="text" id="descripcion" name="descripcion" placeholder="Descripcion de caso:" required> -->
    <br />
    <input type="submit" value="Denunciar" onclick="prepararDenuncia();redirigirAHandlerDeNDeSeguimiento()"><!-- ;redirigirAHandlerDeNDeSeguimiento() -->
    <br>
   

    <%
       
        if (Context.Session["numeroDeSeguimiento"] != null)
        {        
            %>
            <h3>Su número de seguimiento es: <%=Context.Session["numeroDeSeguimiento"]%></h3>
    <%
            Context.Session.Remove("numeroDeSeguimiento");
        }
        %>

    <a href="Default.aspx">Volver</a>
</body>
</html>
