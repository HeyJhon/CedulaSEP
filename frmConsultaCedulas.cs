using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.IdentityModel.Tokens;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace CedulaSEP
{
    public partial class frmConsultaCedulas : Form
    {
        CedulaContext cedulaContext;
        List<DataInfo> resultado = null;
        public frmConsultaCedulas()
        {
            InitializeComponent();
            cedulaContext = new();
            cedulaContext.Database.EnsureCreated();
        }

        private void frmConsultaCedulas_Load(object sender, EventArgs e)
        {

        }
        private bool validarCampos()
        {
            return txt3_Nia.Text.IsNullOrEmpty() &&
                txt4_Nombre.Text.IsNullOrEmpty() &&
                txt4_ApellidoPaterno.Text.IsNullOrEmpty() &&
                txt4_ApellidoMaterno.Text.IsNullOrEmpty() &&
                txt9_Curp.Text.IsNullOrEmpty();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(validarCampos()) {
                MessageBox.Show("Debe especificar al menos un campo para buscar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int nia = 0;
            if (!txt3_Nia.Text.IsNullOrEmpty())
            {
                nia = Convert.ToInt32(txt3_Nia.Text);
            }
            string apellidoPaterno = txt4_ApellidoPaterno.Text;
            string apellidoMaterno = txt4_ApellidoMaterno.Text;
            string nombre = txt4_Nombre.Text;
            string curp = txt9_Curp.Text;

            try
            {
               var cedulas = cedulaContext.DataInfos.Where(cd =>
               cd.Texto3_Nia == nia ||
               cd.Texto4_ApellidoPaterno.Contains(apellidoPaterno) &&
               cd.Texto4_ApellidoMaterno.Contains(apellidoMaterno) &&
               cd.Texto4_Nombre.Contains(nombre) &&
               cd.Texto9_Curp.Contains(curp)
               ).ToList();

               dgvCedulas.DataSource = cedulas;
                this.resultado = cedulas;
                ActivarVerCedula(cedulas);

            }
            catch (Exception)
            {
                btnVerCedula.Enabled = false;

                MessageBox.Show("Ocurrio un error al consultar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCedulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataInfo cedulaSeleccionada = (DataInfo)dgvCedulas.CurrentRow.DataBoundItem;
            if (cedulaSeleccionada != null)
            {
                txt3_Nia.Text = cedulaSeleccionada.Texto3_Nia.ToString();
                txt4_ApellidoPaterno.Text = cedulaSeleccionada.Texto4_ApellidoPaterno;
                txt4_ApellidoMaterno.Text = cedulaSeleccionada.Texto4_ApellidoMaterno;
                txt4_Nombre.Text = cedulaSeleccionada.Texto4_Nombre;
                txt9_Curp.Text = cedulaSeleccionada.Texto9_Curp;
            }            
        }

        private void btnVerCedula_Click(object sender, EventArgs e)
        {
            DataInfo cedulaSeleccionada = (DataInfo)dgvCedulas.CurrentRow.DataBoundItem;
            if (cedulaSeleccionada != null)
            {
                frmDatosAlumno frmDatosAlumno = new(cedulaSeleccionada);
                frmDatosAlumno.MdiParent = this.MdiParent;
                frmDatosAlumno.Show();
            }
        }

        private void dgvCedulas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataInfo cedulaSeleccionada = (DataInfo)dgvCedulas.CurrentRow.DataBoundItem;
            if (cedulaSeleccionada != null)
            {
                frmDatosAlumno frmDatosAlumno = new(cedulaSeleccionada);
                frmDatosAlumno.MdiParent = this.MdiParent;
                frmDatosAlumno.Show();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(resultado != null && resultado.Count>0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook excel = new XLWorkbook())
                            {
                                excel.Worksheets.Add(resultado.ToDataTable(),"Alumnos");
                                excel.SaveAs(sfd.FileName);
                                MessageBox.Show("Datos exportados correctametne" , "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocurrio un error al exportar los datos:" + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay resultados para exportar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActivarVerCedula(List<DataInfo> cedulas)
        {
            if (cedulas.Count > 0)
            {
                btnVerCedula.Enabled = true;
            }
            else
            {
                btnVerCedula.Enabled = false;
            }
        }
        private void btnBuscaPorGrupos_Click(object sender, EventArgs e)
        {
            if(txtTodos.Checked)
            {
                try
                {
                    var cedulas = cedulaContext.DataInfos.ToList();
                    dgvCedulas.DataSource = cedulas;
                    this.resultado = cedulas;

                    ActivarVerCedula(cedulas);

                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al consultar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string grado = txtGrado.Text;
                string grupo = txtGrupo.Text;

                string gradoYGrupo = txtGrado.Text + " \"" + txtGrupo.Text + "\"";
                var cedulas = cedulaContext.DataInfos.Where(
                    cd => cd.Texto52_GradoYGrupo.Contains(gradoYGrupo)
                ).ToList();
                dgvCedulas.DataSource = cedulas;
                this.resultado = cedulas;

                ActivarVerCedula(cedulas);

            }
        }

        private void txtTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTodos.Checked)
            {
                txtGrado.Enabled= false;
                txtGrupo.Enabled= false;
            }
            else { 
                txtGrupo.Enabled= true;
                txtGrado.Enabled= true; 
            }
        }
    }
}
