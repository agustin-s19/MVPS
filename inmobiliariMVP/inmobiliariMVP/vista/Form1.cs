using inmobiliariMVP;
using inmobiliariMVP.presenter;

namespace inmobiliariMVP
{
    public partial class Form1 : Form, IVista, ILocal, IPiso
    {
        private readonly Presenter presenter;
        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numPiso.Enabled = true;
            cantVentanas.Enabled = false;
            Tipo = "Piso";
            if (nuevoTxt.Checked || viejoTxt.Checked == true)
            {
                button1.Enabled = true;
            }
            Piso piso = new Piso();
            piso.Cotizar();

        }

        public string Direccion
        {
            set { direccionTxt.Text = value.ToString(); }
        }

        public int Numeromt2
        {
            get { return !string.IsNullOrEmpty(metrosTxt.Text) ? Convert.ToInt32(metrosTxt.Text) : 0; }
            set { metrosTxt.Text = value.ToString(); }
        }

        public bool esNuevo
        {
            set { nuevoTxt.Checked = true; }
        }
        public int NumeroPiso
        {
            get { return !string.IsNullOrEmpty(numPiso.Text) ? Convert.ToInt32(numPiso.Text) : 0; }
            set { numPiso.Text = value.ToString(); }
        }
        public int NumeroVentanas
        {
            get { return !string.IsNullOrEmpty(cantVentanas.Text) ? Convert.ToInt32(cantVentanas.Text) : 0; }
            set { cantVentanas.Text = value.ToString(); }

        }

        public int Resultado
        {
            set { finalPrice.Text = value.ToString(); }
        }

        public bool esNuevoText { get { return nuevoTxt.Checked; } set { nuevoTxt.Checked = value; } }
        public string metrosText { get { return metrosTxt.Text; } set { metrosTxt.Text = value; } }
        public string direccionText { get { return direccionTxt.Text; } set { direccionTxt.Text = value; } }
        public string precioFinalText { get { return finalPrice.Text; } set { finalPrice.Text = value; } }

        public string numPisoText { get { return numPiso.Text; } set { numPiso.Text = value; } }
        public string cantVentanasText { get { return cantVentanas.Text; } set { cantVentanas.Text = value; } }

        public string Tipo { get { return tipoPiso.Text; } set { } }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            cantVentanas.Enabled = true;
            numPiso.Enabled = false;
            
            if (nuevoTxt.Checked || viejoTxt.Checked == true)
            {
                button1.Enabled = true;
            }
            Local local = new Local();  
            local.Cotizar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Presenter presentador = new Presenter(this);
            presenter.CalcularPrecioInicial();
        }

        private void nuevoTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (nuevoTxt.Checked || viejoTxt.Checked == true)
            {
                button1.Enabled = true;
            }
        }

        private void viejoTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (nuevoTxt.Checked || viejoTxt.Checked == true)
            {
                button1.Enabled = true;
            }
        }
    }
}