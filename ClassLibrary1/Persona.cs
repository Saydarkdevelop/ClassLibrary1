using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        private int run;
        private string nombre;
        private int celular;
        private string email;
        private string clave;

        //asociacion 
        private Cliente cliente;
        private Trabajador trabajador;
       

        public void ReiniciarClave(Persona persona) {


        }

        public bool iniciarSecion (string parametro  ) {
            return true;
        }

    }
}
