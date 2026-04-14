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
        }
    }
}
