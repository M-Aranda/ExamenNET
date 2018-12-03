using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace ExamenNETP1.Controller
{
    /// <summary>
    /// Summary description for RegistrarDenuncia
    /// </summary>
    public class RegistrarDenuncia : IHttpHandler, IRequiresSessionState
    {

        private BDEXAMDataContext bd = new BDEXAMDataContext();

        public void ProcessRequest(HttpContext context)
        {
            String correo = context.Request.Params["correo_usuario"];
            String descripcion = context.Request.Params["descripcion"];
            int idComuna = int.Parse(context.Request.Params["comuna"]);

            Usuario u=bd.Usuarios.Where(usu => usu.correo_usuario == correo).FirstOrDefault();
            Estado_Denuncia e=bd.Estado_Denuncias.Where(estado => estado.nombre_estado == "Ingresado").FirstOrDefault();
            Comuna c= bd.Comunas.Where(com => com.id_comuna == idComuna).FirstOrDefault();

            Denuncia d = new Denuncia();
            d.Usuario = u;
            d.Comuna = c;
            d.descripcion_caso = descripcion;
            d.Estado_Denuncia = e;
            d.fecha_ingreso = DateTime.Now;
            d.fecha_cierre = DateTime.Now.AddDays(30);


            if (u != null)
            {
                bd.Denuncias.InsertOnSubmit(d);
                bd.SubmitChanges();

               /* Denuncia den = bd.Denuncias.OrderByDescending(de => de.id_denuncia).FirstOrDefault();
                context.Session["numeroDeSeguimiento"] = den.id_denuncia;*/
            }


            context.Response.Redirect("../View/Denunciar.aspx");

        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}