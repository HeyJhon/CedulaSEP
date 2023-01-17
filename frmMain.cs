namespace CedulaSEP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Comprobamos si el formulario ya está abierto
            bool formOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmDatosAlumno")
                {
                    formOpen = true;
                    break;
                }
            }

            // Si no está abierto, lo abrimos
            if (!formOpen)
            {
                frmDatosAlumno frmDatosAlumno = new (null);
               // frmDatosAlumno.MdiParent = this;
                frmDatosAlumno.Show();
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Comprobamos si el formulario ya está abierto
            bool formOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmConsultaCedulas")
                {
                    formOpen = true;
                    break;
                }
            }

            // Si no está abierto, lo abrimos
            if (!formOpen)
            {
                frmConsultaCedulas frmConsultaCedulas = new ();
                //frmConsultaCedulas.MdiParent = this;
                frmConsultaCedulas.Name = "frmConsultaCedulas";
                frmConsultaCedulas.Show();
            }
        }
    }
}