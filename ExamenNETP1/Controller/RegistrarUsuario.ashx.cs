using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Controller
{
    /// <summary>
    /// Summary description for RegistrarUsuario
    /// </summary>
    public class RegistrarUsuario : IHttpHandler
    {
        private BDEXAMDataContext bd = new BDEXAMDataContext();

        public void ProcessRequest(HttpContext context)
        {
            String correo = context.Request.Params["correo_usuario"];
            String sex = context.Request.Params["sexo"];
            String tip = context.Request.Params["tipo_usuario"];
            String nom = context.Request.Params["nombres"];
            String aPaterno = context.Request.Params["aPaterno"];
            String aMaterno = context.Request.Params["aMaterno"];
            String clave = context.Request.Params["clave"];
            String fechaNac= context.Request.Params["fechaNacimento"];
            /*Este no me sirve; entrega datos erroneos
            DateTime d; 
            DateTime.TryParseExact(fechaNac, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out d);
            */
            DateTime d = Convert.ToDateTime(fechaNac);

            Sexo s=bd.Sexos.Where(se => se.nombre_sexo == sex).FirstOrDefault();
            Tipo_usuario t = bd.Tipo_usuarios.Where(ti => ti.nombre_tipo_usuario == tip).FirstOrDefault();

            //en este handles se hace el insert con linq
            Usuario u = new Usuario();
            u.correo_usuario = correo;
            u.Sexo = s;
            u.Tipo_usuario = t;
            u.nombres = nom;
            u.ap_paterno = aPaterno;
            u.ap_materno = aMaterno;
            u.clave = clave;
            u.fecha_nacimiento = d;
            bd.Usuarios.InsertOnSubmit(u);
            bd.SubmitChanges();
            //context.Response.Redirect("../View/Registrar.aspx");

        }



        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}