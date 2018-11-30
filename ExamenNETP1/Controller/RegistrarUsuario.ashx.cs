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
            String nom = context.Request.Params["nombres"];
            String aPaterno = context.Request.Params["aPaterno"];
            String aMaterno = context.Request.Params["aMaterno"];
            String clave = context.Request.Params["clave"];

            //en este handles se hace el insert con linq
            Usuario u = new Usuario();
            u.correo_usuario = correo;
            u.nombres = nom;
            u.ap_paterno = aPaterno;
            u.ap_materno = aMaterno;
            u.clave = clave;
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