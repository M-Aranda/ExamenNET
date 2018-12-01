using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Model
{
    public class Estado_denuncia
    {
        private int id_estado;
        private String nombre_estado;

        public int Id_estado { get => id_estado; set => id_estado = value; }
        public string Nombre_estado { get => nombre_estado; set => nombre_estado = value; }
    }
}