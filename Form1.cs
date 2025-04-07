namespace SimulacroParcial2
{
    public partial class Form1 : Form
    {
        InscripcionJson inscripcionJson = new InscripcionJson();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        string archivoInscripcion = @"../../../Inscripciones.json";
        List<Reporte> reportes = new List<Reporte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            FormInscripcion formInscripcion = new FormInscripcion();
            formInscripcion.Show();
        }

        public void cargarInscripciones()
        {
            inscripciones = inscripcionJson.Leer(archivoInscripcion);
            reportes = new List<Reporte>();

            foreach (var inscripcion in inscripciones)
            {
                Reporte reporte = new Reporte();
                reporte.nombre = inscripcion.NombreEstudiante;
                reporte.taller = inscripcion.NombreTaller;

                reportes.Add(reporte);
            }
            actualizarGrid(reportes);
        }

        public void actualizarGrid(List<Reporte> lista)
        {
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarInscripciones();
        }
    }
}
