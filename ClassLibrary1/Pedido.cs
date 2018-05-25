using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pedido
    {
        private Cliente cliente;
        private Garzon garzon;
        private List<Alimento> _alimento;
        private List<Menu> _menu;
        private Mesa mesa;
        private DateTime fecha;
        private DateTime hora;
        private bool estado;


        
        public bool registrarse(string[] parametro)
        {
            Administrador administrador = new Administrador();

            return true;

        }



    }
}
