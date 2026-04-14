using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_EntityFramework
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            //destruir el formulario de la memoria
            this.Dispose();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            //Validar que vengan llenas las cajas de texto
            try
            {
                if( Codigo.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Codigo no puede ir en blanco");
                    return; //salir del evento (no continua)
                }
                if (Nombre.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Nombre no puede ir en blanco");
                    return; //salir del evento (no continua)
                }
                if( double.Parse(Costo.Text) < 0)
                {
                    MessageBox.Show("Costo no puede ser un numero negativo");
                    return; //salir del evento (no continua)
                }
                if (double.Parse(PrecioVenta.Text) <= 0)
                {
                    MessageBox.Show("Precio de venta no puede ser <= 0");
                    return; //salir del evento (no continua)
                }
                if (Existencias.Text.Trim().Length == 0 || double.Parse(Existencias.Text) == double.NaN )
                {
                    MessageBox.Show("Existencias no puede ir en blanco");
                    return; //salir del evento (no continua)
                }
                //si llego hasta aqui todo salio bien, por lo tanto ocultamos el formulario
                //pero no lo destruimos de la memoria
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos digitados no son correctos.");
            }
        }
    }
}
