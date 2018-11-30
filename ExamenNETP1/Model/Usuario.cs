using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Model
{
    public class Usuario
    {
        private String correo_usuario;
        private Sexo sexo;
        private Tipo_usuario tipoDeUsuario;
        private String nombres;
        private String a_paterno;
        private String a_materno;
        private String clave;
        private DateTime fecha_nacimiento;

        public string Correo_usuario { get => correo_usuario; set => correo_usuario = value; }
        public Sexo Sexo { get => sexo; set => sexo = value; }
        public Tipo_usuario TipoDeUsuario { get => tipoDeUsuario; set => tipoDeUsuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string A_paterno { get => a_paterno; set => a_paterno = value; }
        public string A_materno { get => a_materno; set => a_materno = value; }
        public string Clave { get => clave; set => clave = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
    }
}