using _19_EntityFramework.Models;

namespace _19_EntityFramework
{
    public partial class Form1 : Form
    {
        //metodo para cargar datos en el grid
        public void CargarDatos()
        {
            try
            {
                //crear un objeto para tener acceso al contexto de la BD
                Data.GerardoContext contexto = new Data.GerardoContext();

                //Recuperar todos los datos de la tabla Productos asi como todas sus columnas
                Grid1.DataSource = contexto.Productos.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //evento que sucede cuando se dibuja el Form en pantalla
            this.CargarDatos();

            //personalizar el Grid
            Grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //seleccionar toda fila
            Grid1.RowHeadersVisible = false; //selector de filas oculto
            Grid1.ReadOnly = true; //evitar poder editar desde el Grid
            Grid1.AllowUserToResizeRows = false; //evitar que se puede hacer mas altas las filas

            //colocar etiquetas en los titulos de algunas columnas
            Grid1.Columns["ProductoID"].HeaderText = "Numero";
            Grid1.Columns["PrecioVenta"].HeaderText = "Precio de Venta";

            Grid1.AutoResizeColumns(); //autoajustar el ancho de las columnas de acuerdo al contenido
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //crear una nueva instancia de Detalle
            Detalle d = new Detalle();
            d.ShowDialog(); //mostrar en pantalla

            //se ha cerrado el form de Detalle, verificamos si el form
            //fue destruido de la memoria o no.
            if (d.IsDisposed == false)
            {
                try
                {
                    //el form no fue destruido de la memoria o sea hizo click en Aceptar
                    Producto registro = new Producto();
                    //no olvide colocar a las cajas de texto en Detalle la propiedad
                    //Modifiers como Public
                    //apuntar cada campo del registro a cada caja de texto:
                    registro.Codigo = d.Codigo.Text.Trim();
                    registro.Nombre = d.Nombre.Text.Trim();
                    registro.Costo = decimal.Parse(d.Costo.Text);
                    registro.PrecioVenta = decimal.Parse(d.PrecioVenta.Text);
                    registro.Existencias = int.Parse(d.Existencias.Text);
                    registro.Comentarios = d.Comentarios.Text.Trim();

                    //conectar a la base de datos
                    Data.GerardoContext contexto = new Data.GerardoContext();

                    //Escribir el producto en la base de datos
                    contexto.Productos.Add(registro);
                    //ejecutar la escritura
                    contexto.SaveChanges();
                    //refresar el contenido del DataGrid
                    this.CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            //validar si ha seleccionado una fila
            if (Grid1.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item.");
                return; //salir del evento
            }

            try
            {
                //Recuperar el producto seleccionado desde la BD y para llenar el Form de Detalle
                Data.GerardoContext contexto = new Data.GerardoContext(); //conectar
                //buscar el producto a editar por medio de su ProductoID (llave primaria)
                Producto registro = contexto.Productos.Find(Grid1.CurrentRow.Cells["ProductoID"].Value);

                //instanciar form de detalle
                Detalle d = new Detalle();
                //llenar las cajas de texto con el registro recuperado de la BD
                d.Codigo.Text = registro.Codigo;
                d.Nombre.Text = registro.Nombre;
                d.Costo.Text = registro.Costo.ToString();
                d.PrecioVenta.Text = registro.PrecioVenta.ToString();
                d.Existencias.Text = registro.Existencias.ToString();
                d.Comentarios.Text = registro.Comentarios;

                d.ShowDialog(); //mostrar form de Detalle

                //se ha cerrado el Form de Detalle, si hizo click en Aceptar se guarda el registro
                if (d.IsDisposed == false)
                {
                    //colocar los nuevos datos desde Detalle hacia el registro recuperado
                    registro.Codigo = d.Codigo.Text.Trim();
                    registro.Nombre = d.Nombre.Text.Trim();
                    registro.Costo = decimal.Parse(d.Costo.Text);
                    registro.PrecioVenta = decimal.Parse(d.PrecioVenta.Text);
                    registro.Existencias = int.Parse(d.Existencias.Text);
                    registro.Comentarios = d.Comentarios.Text.Trim();
                    //cambiar el estado del registro a modificado
                    contexto.Entry(registro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    //escribir en la BD
                    contexto.SaveChanges();
                    //cargar de nuevo el GridView
                    this.CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            //validar si ha seleccionado una fila
            if (Grid1.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un item.");
                return; //salir del evento
            }

            //preguntar al usuario si desea eliminar
            DialogResult respuesta = MessageBox.Show("Desea eliminar el item?","Eliminar",MessageBoxButtons.YesNo);
            if( respuesta == DialogResult.Yes)
            {
                try
                {
                    //conectar a la bd
                    Data.GerardoContext contexto = new Data.GerardoContext();
                    //recuperar el producto desde la bd
                    Producto registro = contexto.Productos.Find(Grid1.CurrentRow.Cells["ProductoID"].Value);

                    //marcar el objeto para du eliminacion
                    contexto.Productos.Remove(registro);
                    //escribir los cambios en la BD
                    contexto.SaveChanges();
                    //volver a cargar los datos del GridView
                    this.CargarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
