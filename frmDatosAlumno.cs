using iTextSharp.text.pdf;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CedulaSEP
{
    public partial class frmDatosAlumno : Form
    {
        CedulaContext cedulaContext;
        DataInfo cedulaSeleccionada = null;
        public frmDatosAlumno(DataInfo cedulaSeleccionadaOut)
        {
            InitializeComponent();
            cedulaContext = new();
            cedulaContext.Database.EnsureCreated();
            if (cedulaSeleccionadaOut != null)
            {
                cedulaSeleccionada = cedulaSeleccionadaOut;
                CargarCedulaSeleccionada();
            }
        }
        private void CargarCedulaSeleccionada()
        {
            txt1_CicloEscolar.Text = cedulaSeleccionada.Texto1_CicloEscolar;
            txt2_Fecha.Value = cedulaSeleccionada.Texto2_Fecha.Value;
            txt3_Nia.Text = cedulaSeleccionada.Texto3_Nia.ToString();
            txt4_ApellidoPaterno.Text = cedulaSeleccionada.Texto4_ApellidoPaterno;
            txt4_ApellidoMaterno.Text = cedulaSeleccionada.Texto4_ApellidoMaterno;
            txt4_Nombre.Text = cedulaSeleccionada.Texto4_Nombre;
            txt5_GeneroH.Checked = cedulaSeleccionada.Texto5_GeneroH == "1";
            txt6_GeneroM.Checked = cedulaSeleccionada.Texto6_GeneroM == "1";
            txt7_FechaNacimiento.Value = cedulaSeleccionada.Texto7_FechaNacimiento.Value;
            txt8_EntidadNacimiento.Text = cedulaSeleccionada.Texto8_EntidadNacimiento;
            txt9_Curp.Text = cedulaSeleccionada.Texto9_Curp;
            txt10_Sangre.Text = cedulaSeleccionada.Texto10_TipoSangre;
            txt11_Lengua.Text = cedulaSeleccionada.Texto11_LenguaMaterna;
            txt12_Discapacidad.Text = cedulaSeleccionada.Texto12_DiscapacidadAptitudDiferenciada;
            txt13_Entidad.Text = cedulaSeleccionada.Texto13_Entidad;
            txt14_Municipio.Text = cedulaSeleccionada.Texto14_Municipio;
            txt15_Localidad.Text = cedulaSeleccionada.Texto15_Localidad;
            txt16_Domicilio.Text = cedulaSeleccionada.Texto16_Domicilio;
            txt17_Colonia.Text = cedulaSeleccionada.Texto17_Colonia;
            txt18_CP.Text = cedulaSeleccionada.Texto18_Cp;
            txt19_Telefono.Text = cedulaSeleccionada.Texto19_Telefono;
            txt20_Celular.Text = cedulaSeleccionada.Texto20_Celular;
            txt21_Email.Text = cedulaSeleccionada.Texto21_Email;
            txt22_CurpTutor.Text = cedulaSeleccionada.Texto22_CurpTutor;
            txt23_ApellidoPaternoTutor.Text = cedulaSeleccionada.Texto23_ApellidoPaternoTutor;
            txt23_ApellidoMaternoTutor.Text = cedulaSeleccionada.Texto23_ApellidoMaternoTutor;
            txt23_NombreTutor.Text = cedulaSeleccionada.Texto23_NombreTutor;
            txt24_EntidadTutor.Text = cedulaSeleccionada.Texto24_EntidadTutor;
            txt25_MunicipioTutor.Text = cedulaSeleccionada.Texto25_MunicipioTutor;
            txt26_LocalidadTutor.Text = cedulaSeleccionada.Texto26_LocalidadTutor;
            txt27_DomicilioTutor.Text = cedulaSeleccionada.Texto27_DomicilioTutor;
            txt28_Colonia.Text = cedulaSeleccionada.Texto28_ColoniaTutor;
            txt29_CPTutor.Text = cedulaSeleccionada.Texto29_CpTutor;
            txt30_TelefonoTutor.Text = cedulaSeleccionada.Texto30_TelefonoTutor;
            txt31_ParentescoTutor.Text = cedulaSeleccionada.Texto31_ParentescoConElAlumnoTutor;
            txt32_OcupacionTutor.Text = cedulaSeleccionada.Texto32_OcupacionTutor;
            txt33_NivelEstudiosTutor.Text = cedulaSeleccionada.Texto33_NivelDeEstudiosTutor;
            txt34_EmailTutor.Text = cedulaSeleccionada.Texto34_EmailTutor;
            txt35_Nacionalidad.Text = cedulaSeleccionada.Texto35_Nacionalidad;
            txt36_EntidadFedRegistro.Text = cedulaSeleccionada.Texto36_EntidadFedRegistro;
            txt37_ActaNacimiento.Checked = cedulaSeleccionada.Texto37_ActaNacimiento == "1";
            txt38_DocumentoMigratorio.Checked = cedulaSeleccionada.Texto38_DocumentoMigratorio == "1";
            txt39_DocumentoNaturalizacionSRE.Checked = cedulaSeleccionada.Texto39_DocumentoNaturalizacionSRE == "1";
            txt40_FichaSignaletica.Checked = cedulaSeleccionada.Texto40_FichaSignaletica == "1";
            txt41_NoLibro.Text = cedulaSeleccionada.Texto41_NoLibro;
            txt42_NoActa.Text = cedulaSeleccionada.Texto42_NoActa;
            txt43_Crip.Text = cedulaSeleccionada.Texto43_Crip;
            txt44_NoRegistroNacionalExt.Text = cedulaSeleccionada.Texto44_NoRegistroNacionalExtranjeros;
            txt45_FolioDeLaCarta.Text = cedulaSeleccionada.Texto45_FolioCarta;
            txt47_NoJuzgado.Text = cedulaSeleccionada.Texto47_NoJuzgado;
            txt48_FolioFicha.Text = cedulaSeleccionada.Texto48_FolioFicha;
            txt53_NoEntregoDocProbatorio.Checked  = cedulaSeleccionada.Texto53_NoEntregoDocumentoAprobatorio == "1";
            txt54_Observaciones.Text = cedulaSeleccionada.Texto54_Observaciones;
            txt55_MunicipioRegistro.Text = cedulaSeleccionada.Texto55_MunicipioRegistro;
            txt56_AnioRegistro.Text = cedulaSeleccionada.Texto56_AñoRegistro;
            txt49_NombreYFirmaPadre.Text = cedulaSeleccionada.Texto49_NombrePadreOTutor;
            txt50_Cct.Text = cedulaSeleccionada.Texto50_Cct;
            txt51_Turno.Text = cedulaSeleccionada.Texto51_Turno;
            string gradoGrupo = cedulaSeleccionada.Texto52_GradoYGrupo;
            txt52_Grado.Text = gradoGrupo.Substring(0, 1);
            txt52_Grupo.Text = gradoGrupo.Substring(3, 1);
            txt54_NombreDirector.Text = cedulaSeleccionada.NombreDirector;
            txt53_InscritoEn.Text = cedulaSeleccionada.InscritoEn;

        }
        private void frmDatosAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private DataInfo GetDataInfo(int Nia)
        {
            return cedulaContext.DataInfos.SingleOrDefault(cd => cd.Texto3_Nia == Nia);
        }

        private void AgregarAlumno(int nia)
        {
            try
            {
                DataInfo cedula = new DataInfo()
                {
                    DataInfoId = Guid.NewGuid(),
                    Texto1_CicloEscolar = txt1_CicloEscolar.Text,
                    Texto2_Fecha = txt2_Fecha.Value,
                    Texto3_Nia = nia,
                    Texto4_ApellidoPaterno = txt4_ApellidoPaterno.Text,
                    Texto4_ApellidoMaterno = txt4_ApellidoMaterno.Text,
                    Texto4_Nombre = txt4_Nombre.Text,
                    Texto5_GeneroH = txt5_GeneroH.Checked ? "1" : "0",
                    Texto6_GeneroM = txt6_GeneroM.Checked ? "1" : "0",
                    Texto7_FechaNacimiento = txt7_FechaNacimiento.Value,
                    Texto8_EntidadNacimiento = txt8_EntidadNacimiento.Text,
                    Texto9_Curp = txt9_Curp.Text,
                    Texto10_TipoSangre = txt10_Sangre.Text,
                    Texto11_LenguaMaterna = txt11_Lengua.Text,
                    Texto12_DiscapacidadAptitudDiferenciada = txt12_Discapacidad.Text,
                    Texto13_Entidad = txt13_Entidad.Text,
                    Texto14_Municipio = txt14_Municipio.Text,
                    Texto15_Localidad = txt15_Localidad.Text,
                    Texto16_Domicilio = txt16_Domicilio.Text,
                    Texto17_Colonia = txt17_Colonia.Text,
                    Texto18_Cp = txt18_CP.Text,
                    Texto19_Telefono = txt19_Telefono.Text,
                    Texto20_Celular = txt20_Celular.Text,
                    Texto21_Email = txt21_Email.Text,
                    Texto22_CurpTutor = txt22_CurpTutor.Text,
                    Texto23_ApellidoPaternoTutor = txt23_ApellidoPaternoTutor.Text,
                    Texto23_ApellidoMaternoTutor = txt23_ApellidoMaternoTutor.Text,
                    Texto23_NombreTutor = txt23_NombreTutor.Text,
                    Texto24_EntidadTutor = txt24_EntidadTutor.Text,
                    Texto25_MunicipioTutor = txt25_MunicipioTutor.Text,
                    Texto26_LocalidadTutor = txt26_LocalidadTutor.Text,
                    Texto27_DomicilioTutor = txt27_DomicilioTutor.Text,
                    Texto28_ColoniaTutor = txt28_Colonia.Text,
                    Texto29_CpTutor = txt29_CPTutor.Text,
                    Texto30_TelefonoTutor = txt30_TelefonoTutor.Text,
                    Texto31_ParentescoConElAlumnoTutor = txt31_ParentescoTutor.Text,
                    Texto32_OcupacionTutor = txt32_OcupacionTutor.Text,
                    Texto33_NivelDeEstudiosTutor = txt33_NivelEstudiosTutor.Text,
                    Texto34_EmailTutor = txt34_EmailTutor.Text,
                    Texto35_Nacionalidad = txt35_Nacionalidad.Text,
                    Texto36_EntidadFedRegistro = txt36_EntidadFedRegistro.Text,
                    Texto37_ActaNacimiento = txt37_ActaNacimiento.Checked ? "1" : "0",
                    Texto38_DocumentoMigratorio = txt38_DocumentoMigratorio.Checked ? "1" : "0",
                    Texto39_DocumentoNaturalizacionSRE = txt39_DocumentoNaturalizacionSRE.Checked ? "1" : "0",
                    Texto40_FichaSignaletica = txt40_FichaSignaletica.Checked ? "1" : "0",
                    Texto41_NoLibro = txt41_NoLibro.Text,
                    Texto42_NoActa = txt42_NoActa.Text,
                    Texto43_Crip = txt43_Crip.Text,
                    Texto44_NoRegistroNacionalExtranjeros = txt44_NoRegistroNacionalExt.Text,
                    Texto45_FolioCarta = txt45_FolioDeLaCarta.Text,
                    Texto47_NoJuzgado = txt47_NoJuzgado.Text,
                    Texto48_FolioFicha = txt48_FolioFicha.Text,
                    Texto53_NoEntregoDocumentoAprobatorio = txt53_NoEntregoDocProbatorio.Checked ? "1" : "0",
                    Texto54_Observaciones = txt54_Observaciones.Text,
                    Texto55_MunicipioRegistro = txt55_MunicipioRegistro.Text,
                    Texto56_AñoRegistro = txt56_AnioRegistro.Text,
                    Texto49_NombrePadreOTutor = txt49_NombreYFirmaPadre.Text,
                    Texto50_Cct = txt50_Cct.Text,
                    Texto51_Turno = txt51_Turno.Text,
                    Texto52_GradoYGrupo = txt52_Grado.Text +" \"" + txt52_Grupo.Text + "\"",
                    NombreDirector = txt54_NombreDirector.Text,
                    InscritoEn = txt53_InscritoEn.Text

                };
                cedulaContext.DataInfos.Add(cedula);
                cedulaContext.SaveChanges();
                this.cedulaSeleccionada = cedula;
                }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al consultar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarAlumno(DataInfo cedulaEncontrada)
        {
            try
            {
                cedulaEncontrada.Texto1_CicloEscolar = txt1_CicloEscolar.Text;
                cedulaEncontrada.Texto2_Fecha = txt2_Fecha.Value;
                cedulaEncontrada.Texto3_Nia =Convert.ToInt32(txt3_Nia.Text);
                cedulaEncontrada.Texto4_ApellidoPaterno = txt4_ApellidoPaterno.Text;
                cedulaEncontrada.Texto4_ApellidoMaterno = txt4_ApellidoMaterno.Text;
                cedulaEncontrada.Texto4_Nombre = txt4_Nombre.Text;
                cedulaEncontrada.Texto5_GeneroH = txt5_GeneroH.Checked ? "1" : "0";
                cedulaEncontrada.Texto6_GeneroM = txt6_GeneroM.Checked ? "1" : "0";
                cedulaEncontrada.Texto7_FechaNacimiento = txt7_FechaNacimiento.Value;
                cedulaEncontrada.Texto8_EntidadNacimiento = txt8_EntidadNacimiento.Text;
                cedulaEncontrada.Texto9_Curp = txt9_Curp.Text;
                cedulaEncontrada.Texto10_TipoSangre = txt10_Sangre.Text;
                cedulaEncontrada.Texto11_LenguaMaterna = txt11_Lengua.Text;
                cedulaEncontrada.Texto12_DiscapacidadAptitudDiferenciada = txt12_Discapacidad.Text;
                cedulaEncontrada.Texto13_Entidad = txt13_Entidad.Text;
                cedulaEncontrada.Texto14_Municipio = txt14_Municipio.Text;
                cedulaEncontrada.Texto15_Localidad = txt15_Localidad.Text;
                cedulaEncontrada.Texto16_Domicilio = txt16_Domicilio.Text;
                cedulaEncontrada.Texto17_Colonia = txt17_Colonia.Text;
                cedulaEncontrada.Texto18_Cp = txt18_CP.Text;
                cedulaEncontrada.Texto19_Telefono = txt19_Telefono.Text;
                cedulaEncontrada.Texto20_Celular = txt20_Celular.Text;
                cedulaEncontrada.Texto21_Email = txt21_Email.Text;
                cedulaEncontrada.Texto22_CurpTutor = txt22_CurpTutor.Text;
                cedulaEncontrada.Texto23_ApellidoPaternoTutor = txt23_ApellidoPaternoTutor.Text;
                cedulaEncontrada.Texto23_ApellidoMaternoTutor = txt23_ApellidoMaternoTutor.Text;
                cedulaEncontrada.Texto23_NombreTutor = txt23_NombreTutor.Text;
                cedulaEncontrada.Texto24_EntidadTutor = txt24_EntidadTutor.Text;
                cedulaEncontrada.Texto25_MunicipioTutor = txt25_MunicipioTutor.Text;
                cedulaEncontrada.Texto26_LocalidadTutor = txt26_LocalidadTutor.Text;
                cedulaEncontrada.Texto27_DomicilioTutor = txt27_DomicilioTutor.Text;
                cedulaEncontrada.Texto28_ColoniaTutor = txt28_Colonia.Text;
                cedulaEncontrada.Texto29_CpTutor = txt29_CPTutor.Text;
                cedulaEncontrada.Texto30_TelefonoTutor = txt30_TelefonoTutor.Text;
                cedulaEncontrada.Texto31_ParentescoConElAlumnoTutor = txt31_ParentescoTutor.Text;
                cedulaEncontrada.Texto32_OcupacionTutor = txt32_OcupacionTutor.Text;
                cedulaEncontrada.Texto33_NivelDeEstudiosTutor = txt33_NivelEstudiosTutor.Text;
                cedulaEncontrada.Texto34_EmailTutor = txt34_EmailTutor.Text;
                cedulaEncontrada.Texto35_Nacionalidad = txt35_Nacionalidad.Text;
                cedulaEncontrada.Texto36_EntidadFedRegistro = txt36_EntidadFedRegistro.Text;
                cedulaEncontrada.Texto37_ActaNacimiento = txt37_ActaNacimiento.Checked ? "1" : "0";
                cedulaEncontrada.Texto38_DocumentoMigratorio = txt38_DocumentoMigratorio.Checked ? "1" : "0";
                cedulaEncontrada.Texto39_DocumentoNaturalizacionSRE = txt39_DocumentoNaturalizacionSRE.Checked ? "1" : "0";
                cedulaEncontrada.Texto40_FichaSignaletica = txt40_FichaSignaletica.Checked ? "1" : "0";
                cedulaEncontrada.Texto41_NoLibro = txt41_NoLibro.Text;
                cedulaEncontrada.Texto42_NoActa = txt42_NoActa.Text;
                cedulaEncontrada.Texto43_Crip = txt43_Crip.Text;
                cedulaEncontrada.Texto44_NoRegistroNacionalExtranjeros = txt44_NoRegistroNacionalExt.Text;
                cedulaEncontrada.Texto45_FolioCarta = txt45_FolioDeLaCarta.Text;
                cedulaEncontrada.Texto47_NoJuzgado = txt47_NoJuzgado.Text;
                cedulaEncontrada.Texto48_FolioFicha = txt48_FolioFicha.Text;
                cedulaEncontrada.Texto53_NoEntregoDocumentoAprobatorio = txt53_NoEntregoDocProbatorio.Checked ? "1" : "0";
                cedulaEncontrada.Texto54_Observaciones = txt54_Observaciones.Text;
                cedulaEncontrada.Texto55_MunicipioRegistro = txt55_MunicipioRegistro.Text;
                cedulaEncontrada.Texto56_AñoRegistro = txt56_AnioRegistro.Text;
                cedulaEncontrada.Texto49_NombrePadreOTutor = txt49_NombreYFirmaPadre.Text;
                cedulaEncontrada.Texto50_Cct = txt50_Cct.Text;
                cedulaEncontrada.Texto51_Turno = txt51_Turno.Text;
                cedulaEncontrada.Texto52_GradoYGrupo = txt52_Grado.Text + " \"" + txt52_Grupo.Text + "\"";
                cedulaEncontrada.InscritoEn = txt53_InscritoEn.Text;
                cedulaEncontrada.NombreDirector = txt54_NombreDirector.Text;
                cedulaContext.DataInfos.Update(cedulaEncontrada);
                cedulaContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al consultar los datos" + ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cedulaSeleccionada != null)
                {
                    ActualizarAlumno(cedulaSeleccionada);
                    MessageBox.Show("Se actualizaron los datos correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int nia = Convert.ToInt32(txt3_Nia.Text);
                    DataInfo cedulaEncontrada = GetDataInfo(nia);
                    if (cedulaEncontrada == null)
                    {
                        AgregarAlumno(nia);
                        MessageBox.Show("Se guardo correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El NIA debe contener solo numeros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cedulaSeleccionada != null)
            {
                try
                {
                    string nombreCedulaEdit = "CedulaV2.pdf";
                    PdfReader pdfReader = new PdfReader(nombreCedulaEdit);

                    string nombreCedula = cedulaSeleccionada.Texto52_GradoYGrupo.Trim().Replace("\"","").Replace(" ","") +"\\"+ cedulaSeleccionada.Texto3_Nia + "_Cedula.pdf";

                    Directory.CreateDirectory(Path.GetDirectoryName(nombreCedula));

                    PdfStamper stamper = new PdfStamper(pdfReader, new FileStream(nombreCedula, FileMode.Create));


                    stamper.AcroFields.SetField("Texto1", cedulaSeleccionada.Texto1_CicloEscolar);
                    stamper.AcroFields.SetField("Texto2", cedulaSeleccionada.Texto2_Fecha.Value.ToString("yyyy/MM/dd"));
                    stamper.AcroFields.SetField("Texto3", cedulaSeleccionada.Texto3_Nia.ToString());

                    string nombreCompleto = $"{cedulaSeleccionada.Texto4_ApellidoPaterno}                                             " +
                                            $"{cedulaSeleccionada.Texto4_ApellidoMaterno}                                   " +
                                            $"{cedulaSeleccionada.Texto4_Nombre}";

                    stamper.AcroFields.SetField("Texto4", nombreCompleto);
                    stamper.AcroFields.SetField("Texto5", cedulaSeleccionada.Texto5_GeneroH == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto6", cedulaSeleccionada.Texto6_GeneroM == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto7", cedulaSeleccionada.Texto7_FechaNacimiento.Value.ToString("yyyy/MM/dd"));
                    stamper.AcroFields.SetField("Texto8", cedulaSeleccionada.Texto8_EntidadNacimiento);
                    stamper.AcroFields.SetField("Texto9", cedulaSeleccionada.Texto9_Curp);
                    stamper.AcroFields.SetField("Texto10", cedulaSeleccionada.Texto10_TipoSangre);
                    stamper.AcroFields.SetField("Texto11", cedulaSeleccionada.Texto11_LenguaMaterna);
                    stamper.AcroFields.SetField("Texto12", cedulaSeleccionada.Texto12_DiscapacidadAptitudDiferenciada);
                    stamper.AcroFields.SetField("Texto13", cedulaSeleccionada.Texto13_Entidad);
                    stamper.AcroFields.SetField("Texto14", cedulaSeleccionada.Texto14_Municipio);
                    stamper.AcroFields.SetField("Texto15", cedulaSeleccionada.Texto15_Localidad);
                    stamper.AcroFields.SetField("Texto16", cedulaSeleccionada.Texto16_Domicilio);
                    stamper.AcroFields.SetField("Texto17", cedulaSeleccionada.Texto17_Colonia);
                    stamper.AcroFields.SetField("Texto18", cedulaSeleccionada.Texto18_Cp);
                    stamper.AcroFields.SetField("Texto19", cedulaSeleccionada.Texto19_Telefono);
                    stamper.AcroFields.SetField("Texto20", cedulaSeleccionada.Texto20_Celular);
                    stamper.AcroFields.SetField("Texto21", cedulaSeleccionada.Texto21_Email);
                    stamper.AcroFields.SetField("Texto22", cedulaSeleccionada.Texto22_CurpTutor);

                    string nombreCompletoTutor = $"{cedulaSeleccionada.Texto23_ApellidoPaternoTutor}                                             " +
                                                    $"{cedulaSeleccionada.Texto23_ApellidoMaternoTutor}                                   " +
                                                    $"{cedulaSeleccionada.Texto23_NombreTutor}";

                    stamper.AcroFields.SetField("Texto23", nombreCompletoTutor);

                    stamper.AcroFields.SetField("Texto24", cedulaSeleccionada.Texto24_EntidadTutor);
                    stamper.AcroFields.SetField("Texto25", cedulaSeleccionada.Texto25_MunicipioTutor);
                    stamper.AcroFields.SetField("Texto26", cedulaSeleccionada.Texto26_LocalidadTutor);
                    stamper.AcroFields.SetField("Texto27", cedulaSeleccionada.Texto27_DomicilioTutor);
                    stamper.AcroFields.SetField("Texto28", cedulaSeleccionada.Texto28_ColoniaTutor);
                    stamper.AcroFields.SetField("Texto29", cedulaSeleccionada.Texto29_CpTutor);
                    stamper.AcroFields.SetField("Texto30", cedulaSeleccionada.Texto30_TelefonoTutor);
                    stamper.AcroFields.SetField("Texto31", cedulaSeleccionada.Texto31_ParentescoConElAlumnoTutor);
                    stamper.AcroFields.SetField("Texto32", cedulaSeleccionada.Texto32_OcupacionTutor);
                    stamper.AcroFields.SetField("Texto33", cedulaSeleccionada.Texto33_NivelDeEstudiosTutor);
                    stamper.AcroFields.SetField("Texto34", cedulaSeleccionada.Texto34_EmailTutor);
                    stamper.AcroFields.SetField("Texto35", cedulaSeleccionada.Texto35_Nacionalidad);
                    stamper.AcroFields.SetField("Texto36", cedulaSeleccionada.Texto36_EntidadFedRegistro);
                    stamper.AcroFields.SetField("Texto37", cedulaSeleccionada.Texto37_ActaNacimiento == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto38", cedulaSeleccionada.Texto38_DocumentoMigratorio == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto39", cedulaSeleccionada.Texto39_DocumentoNaturalizacionSRE == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto40", cedulaSeleccionada.Texto40_FichaSignaletica == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto41", cedulaSeleccionada.Texto41_NoLibro);
                    stamper.AcroFields.SetField("Texto42", cedulaSeleccionada.Texto42_NoActa);
                    stamper.AcroFields.SetField("Texto43", cedulaSeleccionada.Texto43_Crip);
                    stamper.AcroFields.SetField("Texto44", cedulaSeleccionada.Texto44_NoRegistroNacionalExtranjeros);
                    stamper.AcroFields.SetField("Texto45", cedulaSeleccionada.Texto45_FolioCarta);
                    stamper.AcroFields.SetField("Texto47", cedulaSeleccionada.Texto47_NoJuzgado);
                    stamper.AcroFields.SetField("Texto48", cedulaSeleccionada.Texto48_FolioFicha);
                    stamper.AcroFields.SetField("Texto53", cedulaSeleccionada.Texto53_NoEntregoDocumentoAprobatorio == "1" ? "X" : "");
                    stamper.AcroFields.SetField("Texto54", cedulaSeleccionada.Texto54_Observaciones);
                    stamper.AcroFields.SetField("Texto55", cedulaSeleccionada.Texto55_MunicipioRegistro);
                    stamper.AcroFields.SetField("Texto56", cedulaSeleccionada.Texto56_AñoRegistro);
                    stamper.AcroFields.SetField("Texto49", cedulaSeleccionada.Texto49_NombrePadreOTutor);
                    stamper.AcroFields.SetField("Texto50_1", cedulaSeleccionada.Texto50_Cct);
                    stamper.AcroFields.SetField("Texto51_1", cedulaSeleccionada.Texto51_Turno);
                    stamper.AcroFields.SetField("Texto52_1", cedulaSeleccionada.Texto52_GradoYGrupo);
                    stamper.AcroFields.SetField("Texto53_1", cedulaSeleccionada.InscritoEn);
                    stamper.AcroFields.SetField("Texto54_1", "          " + cedulaSeleccionada.NombreDirector);

                    // Cerramos el PdfStamper
                    stamper.Close();

                    MessageBox.Show($"Cedula generado correctamente con el nombre: {nombreCedula}", "Cedula Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"No se pudo generar o actualizar el documento, verifique que tenga los permisos o que el documento este cerrado. {ex.Message}", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Primero debe guardar la cedula", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
