using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenNETP1.Model
{
    public class Sexo
    {

        private int id_sexo;
        private String nomre_sexo;

        public int Id_sexo { get => id_sexo; set => id_sexo = value; }
        public string Nomre_sexo { get => nomre_sexo; set => nomre_sexo = value; }
    }
}