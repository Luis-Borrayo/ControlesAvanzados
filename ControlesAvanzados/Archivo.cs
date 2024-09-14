using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAvanzados
{
    public partial class Archivo : Form
    {
        List<Venta> ListVentas = new List<Venta>();
        public Archivo()
        {   
            InitializeComponent();
            AgregarVentas();
            MostrarInformacion();
            MostrarInfoAnio();
            MostrarInfoMeses();
            InicializarListBox();
            InicializarComboBoxAnios();
            InicializarComboBoxMeses();
        }

        private void Archivo_Load(object sender, EventArgs e)
        {

        }
        public void AgregarVentas()
        {
            ListVentas.Add(new Venta(2024, 1, "Guatemala", 100000));
            ListVentas.Add(new Venta(2024, 2, "Guatemala", 80000));
            ListVentas.Add(new Venta(2024, 4, "Guatemala", 120000));
            ListVentas.Add(new Venta(2024, 5, "Guatemala", 100000));
            ListVentas.Add(new Venta(2024, 6, "Guatemala", 110000));
            ListVentas.Add(new Venta(2024, 1, "Jutiapa", 50000));
            ListVentas.Add(new Venta(2024, 2, "Jutiapa", 80000));
            ListVentas.Add(new Venta(2024, 3, "Jutiapa", 67000));
            ListVentas.Add(new Venta(2024, 4, "Jutiapa", 55000));
            ListVentas.Add(new Venta(2024, 5, "Jutiapa", 67000));
            ListVentas.Add(new Venta(2024, 6, "Jutiapa", 45000));
            ListVentas.Add(new Venta(2024, 1, "Chiquimula", 43000));
            ListVentas.Add(new Venta(2024, 2, "Chiquimula", 55000));
            ListVentas.Add(new Venta(2024, 3, "Chiquimula", 23000));
            ListVentas.Add(new Venta(2024, 4, "Chiquimula", 34000));
            ListVentas.Add(new Venta(2024, 5, "Chiquimula", 56000));
            ListVentas.Add(new Venta(2024, 6, "Chiquimula", 78000));
            ListVentas.Add(new Venta(2024, 1, "Escuintla", 86000));
            ListVentas.Add(new Venta(2024, 2, "Escuintla", 75000));
            ListVentas.Add(new Venta(2024, 3, "Escuintla", 64000));
            ListVentas.Add(new Venta(2024, 4, "Escuintla", 78000));
            ListVentas.Add(new Venta(2024, 5, "Escuintla", 79000));
            ListVentas.Add(new Venta(2024, 6, "Escuintla", 90000));
        }

        public void MostrarInformacion()
        {
            ListadodeVentarArch.Controls.Clear();
            if (SelectorDepartamento.SelectedItems.Count == 0)
            {
                foreach (Venta venta in ListVentas)
                {
                    Label labelventa = CrearEtiquetaVenta(venta);
                    ListadodeVentarArch.Controls.Add(labelventa);
                }
            }
            else
            {
                foreach (Venta venta in ListVentas)
                {
                    if (SelectorDepartamento.SelectedItems.Contains(venta.Departamento))
                    {
                        Label labelventa = CrearEtiquetaVenta(venta);
                        ListadodeVentarArch.Controls.Add(labelventa);
                    }
                }
            }
        }

        public void MostrarInfoAnio()
        {
            ListadodeVentarArch.Controls.Clear();
            if (comboBoxAnios.SelectedItem != null)
            {
                int anioSeleccionado = int.Parse(comboBoxAnios.SelectedItem.ToString());
                foreach (Venta venta in ListVentas)
                {
                    if (venta.Anio == anioSeleccionado)
                    {
                        Label labelventa = CrearEtiquetaVenta(venta);
                        ListadodeVentarArch.Controls.Add(labelventa);
                    }
                }
            }
        }

        public void MostrarInfoMeses()
        {
            ListadodeVentarArch.Controls.Clear();
            if (comboBoxMeses.SelectedItem != null)
            {
                int mesSeleccionado = obtenerNumeroMesPorNombre(comboBoxMeses.SelectedItem.ToString());
                foreach (Venta venta in ListVentas)
                {
                    if (venta.Mes == mesSeleccionado)
                    {
                        Label labelventa = CrearEtiquetaVenta(venta);
                        ListadodeVentarArch.Controls.Add(labelventa);
                    }
                }
            }
        }

        private int obtenerNumeroMesPorNombre(string nombreMes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return Array.IndexOf(meses, nombreMes) + 1;
        }

        private string obtenerNombreMesPorNumero(int numeroMes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return numeroMes >= 1 && numeroMes <= 12 ? meses[numeroMes - 1] : "Desconocido";
        }

        private Label CrearEtiquetaVenta(Venta venta)
        {
            Label labelventa = new Label();
            string ventasFormateadas = venta.NumVentas.ToString("C", new CultureInfo("es-GT"));
            string nombreMes = obtenerNombreMesPorNumero(venta.Mes);

            labelventa.Text = $"Año: {venta.Anio}\nMes: {nombreMes}\nDepartamento: {venta.Departamento}\nVentas: {ventasFormateadas}";
            labelventa.AutoSize = true;
            labelventa.Font = new Font("Arial", 12, FontStyle.Bold);
            labelventa.Padding = new Padding(10);
            labelventa.BorderStyle = BorderStyle.FixedSingle;
            labelventa.Margin = new Padding(10);
            labelventa.BackColor = Color.LightGray;
            labelventa.AutoSize = false;
            labelventa.Size = new Size(250, 150);
            labelventa.TextAlign = ContentAlignment.MiddleLeft;

            return labelventa;
        }

        private void InicializarListBox()
        {
            List<string> departamentos = new List<string>();
            foreach (Venta venta in ListVentas)
            {
                if (!departamentos.Contains(venta.Departamento))
                {
                    departamentos.Add(venta.Departamento);
                }
            }
            SelectorDepartamento.Items.AddRange(departamentos.ToArray());
        }

        private void InicializarComboBoxAnios()
        {
            List<int> anios = new List<int>();
            foreach (Venta venta in ListVentas)
            {
                if (!anios.Contains(venta.Anio))
                {
                    anios.Add(venta.Anio);
                }
            }
            comboBoxAnios.Items.AddRange(anios.Select(a => (object)a).ToArray());
            if (comboBoxAnios.Items.Count > 0)
            {
                comboBoxAnios.SelectedIndex = 0;
            }
        }

        private void InicializarComboBoxMeses()
        {
            List<string> meses = new List<string> { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            comboBoxMeses.Items.AddRange(meses.ToArray());
            if (comboBoxMeses.Items.Count > 0)
            {
                comboBoxMeses.SelectedIndex = 0;
            }
        }

        private void SelectorDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarInformacion();
        }

        private void comboBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarInfoMeses();
        }

        private void comboBoxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarInfoAnio();
        }
    }
}