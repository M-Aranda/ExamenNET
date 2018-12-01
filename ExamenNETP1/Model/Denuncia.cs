using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Model
{
    public class Denuncia
    {
        private int id_denuncia;
        private Usuario usuario;
        private Comuna comuna;
        private Estado_denuncia estado;
        private DateTime fechaIngreso;
        private String descripcion;
        private DateTime fechaCierre;

        public int Id_denuncia { get => id_denuncia; set => id_denuncia = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }
        public Comuna Comuna { get => comuna; set => comuna = value; }
        public Estado_denuncia Estado { get => estado; set => estado = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaCierre { get => fechaCierre; set => fechaCierre = value; }
    }
}