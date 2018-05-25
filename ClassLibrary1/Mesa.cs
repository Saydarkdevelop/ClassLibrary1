using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mesa
    {
        private int numero;
        private int cantidadPersonas;
        private bool estado;

        public Mesa(int numero,
                    int cantidadPersonas,
                    bool estado) {
            this.numero = numero;
            this.cantidadPersonas = cantidadPersonas;
            this.estado = estado;
        }
        public void registrar(bool tipo)
        {

        }

        public bool consultaEstado()
        {
            return true;

        }   

        public List<Mesa> disponible ( Mesa mesa)
        {
            Cliente cliente = new Cliente ();
        }



    }
}
