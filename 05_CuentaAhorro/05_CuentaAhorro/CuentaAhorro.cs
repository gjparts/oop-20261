using _05_CuentaAhorro.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CuentaAhorro
{
    public class CuentaAhorro
    {
        //cuando una Propiedad menciona que tiene Private Set
        //no se hace campo privado para ella.
        public string NombreCliente {  get; set; }
        public string NumeroCuenta { get; set; }
        public float Saldo { get; private set; }
        public TipoCuenta Tipo {  get; set; }
        /*Observe que se ha colocado private set a Saldo esto
         significa que Saldo solo podra escribirse por
        medio de metodos que nosotros vamos a programar fuera
        del validador publico.
        A pesar que la propiedad deberia declararse private
        necesitamos que su acceso get sea publico y su acceso
        set sea privado por eso la propiedad es public y el set es
        private.*/

        //Constructores
        public CuentaAhorro(string nombreCliente, string numeroCuenta)
        {
            this.NombreCliente = nombreCliente;
            this.NumeroCuenta = numeroCuenta;
            this.Saldo = 0; //internamente dentro de la clase saldo puede cambiar
            this.Tipo = TipoCuenta.Ahorro;
        }

        //Metodos
        //Coming soon...
    }
}
