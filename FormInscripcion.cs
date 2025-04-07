using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroParcial2
{
    public partial class FormInscripcion : Form
    {
        AlumnoJson alumnoJson = new AlumnoJson();
        TallerJson tallerJson = new TallerJson();
        InscripcionJson inscripcionJson = new InscripcionJson();

        //Listas
        List<Alumno> alumnos = new List<Alumno>();
        List<Taller> talleres = new List<Taller>();
        List<Inscripcion> inscripciones = new List<Inscripcion>();

        //Archivos
        string archivoAlumno = @"../../../Alumnos.json";
        string archivoTaller = @"../../../Talleres.json";
        string archivoInscripcion = @"../../../Inscripciones.json";

        public FormInscripcion()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Inscripcion inscripcion = new Inscripcion();


            inscripcion.DpiEstudiante = comboBoxAlumno.SelectedValue.ToString();
            inscripcion.CodigoTaller = comboBoxTaller.SelectedValue.ToString();
            inscripcion.fechaInscripcion = DateTime.Now;

            inscripciones.Add(inscripcion);

            inscripcionJson.Guardar(archivoInscripcion, inscripciones);
            MessageBox.Show("Se ha inscrito exitosamente");
        }

        public void cargarDatos()
        {
            alumnos = alumnoJson.Leer(archivoAlumno);
            talleres = tallerJson.Leer(archivoTaller);

            comboBoxAlumno.ValueMember = "DPI";
            comboBoxAlumno.DisplayMember = "Nombre";
            comboBoxAlumno.DataSource = alumnos;

            comboBoxTaller.ValueMember = "CodigoTaller";
            comboBoxTaller.DisplayMember = "NombreTaller";
            comboBoxTaller.DataSource = talleres;
        }

        private void FormInscripcion_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
