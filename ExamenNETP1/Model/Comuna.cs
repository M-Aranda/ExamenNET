using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Model
{
    public class Comuna
    {
        private int id_comuna;
        private String nombre_comuna;

        public int Id_comuna { get => id_comuna; set => id_comuna = value; }
        public string Nombre_comuna { get => nombre_comuna; set => nombre_comuna = value; }
    }
}