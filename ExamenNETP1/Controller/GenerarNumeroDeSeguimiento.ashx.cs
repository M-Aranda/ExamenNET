using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace ExamenNETP1.Controller
{
    /// <summary>
    /// Summary description for GenerarNumeroDeSeguimiento
    /// </summary>
    public class GenerarNumeroDeSeguimiento : IHttpHandler, IRequiresSessionState
    {
        private BDEXAMDataContext bd = new BDEXAMDataContext();

        public void ProcessRequest(HttpContext context)
        {
            
            /* String correo = context.Request.Params["correo"];
             Usuario u= bd.Usuarios.Where(us => us.correo_usuario == correo).FirstOrDefault();
             */

            Denuncia den = bd.Denuncias.OrderByDescending(d => d.id_denuncia).FirstOrDefault();


            context.Session["numeroDeSeguimiento"] = den.id_denuncia;
            context.Response.Redirect("../View/Denunciar.aspx");







            /*}
            else if (u == null)
            {
                context.Response.Redirect("../View/Denunciar.aspx");
            }*/


        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}