using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Empleado
    {
        private DateTime horaIngreso;
        private DateTime horaSalida;
        private Trabajador trabajador;
        private Garzon garzon;
            
        //lo declare aqui ya que en ninguna otra parte lo necesitan
        public class chef
        {

        }

        public void registrarIngreso(DateTime Hora)
        {
            this.horaIngreso = Hora;
        }

        public void registrarSalida(DateTime hora ) {
            this.horaSalida = hora;
        }
    }
}
