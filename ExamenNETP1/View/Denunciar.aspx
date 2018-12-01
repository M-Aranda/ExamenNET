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
                var desc = $("#descripcion").val();
 
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
                alert("Hecho");
            }
        </script>

</head>
<body>
    <h2>Denunciar</h2>
    <br>
    <input type="text" id="correo" name="correo" placeholder="Correo de usuario:" required>
    <br>
    <%  BDEXAMDataContext bd = new BDEXAMDataContext();
       // List<ExamenNETP1.Model.Comuna> listadoDeComunas= new List<ExamenNETP1.Model.Comuna>();
        List<ExamenNETP1.Controller.Comuna> listadoDeComunas =bd.Comunas.Select(x => x).ToList();
     /*   ExamenNETP1.Model.Comuna c;
        foreach (ExamenNETP1.Controller.Comuna i in listadoDeComunas2)
        {
            c = new ExamenNETP1.Model.Comuna();
            int id = i.id_comuna;
            String nom=i.nombre_comuna;
            listadoDeComunas.Add(c);
        }*/
        %>

    <select id="comuna" name="comuna">
    <%foreach (ExamenNETP1.Controller.Comuna com in listadoDeComunas)
        {%>

        <option value="<%=com.id_comuna%>"> <%=com.nombre_comuna%> </option>

      <%  } %>
    
    </select>
    <br>
    <input type="text" id="descripcion" name="descripcion" placeholder="Descripcion de caso:" required>
    <br>
    <input type="submit" value="Denunciar" onclick="prepararDenuncia()">



</body>
</html>
