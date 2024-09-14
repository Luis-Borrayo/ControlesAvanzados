namespace ControlesAvanzados
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FormularioArchivo = new Archivo();
            FormularioArchivo.MdiParent = this;
            FormularioArchivo.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulariooproyecto = new FormularioProyeecto();
            Formulariooproyecto.Show();
        }
    }
}
