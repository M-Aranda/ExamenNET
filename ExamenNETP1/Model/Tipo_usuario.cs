using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Model
{
    public class Tipo_usuario
    {
        private int id_tipo_usuario;
        private String nombre_tipo_usuario;

        public int Id_tipo_usuario { get => id_tipo_usuario; set => id_tipo_usuario = value; }
        public string Nombre_tipo_usuario { get => nombre_tipo_usuario; set => nombre_tipo_usuario = value; }
    }
}