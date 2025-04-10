namespace SimulacroParcial2
{
    public partial class Form1 : Form
    {
        InscripcionJson inscripcionJson = new InscripcionJson();
        List<Inscripcion> inscripciones = new List<Inscripcion>();
        string archivoInscripcion = @"../../../Inscripciones.json";
        List<Reporte> reportes = new List<Reporte>();
        int cantidadAlumnos = 0;

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
                cantidadAlumnos++;
                reportes.Add(reporte);
            }
            labelAlumnos.Text = cantidadAlumnos.ToString();
            actualizarGrid(reportes);
        }

        public void actualizarGrid(List<Reporte> lista)
        {
            dataGridViewReporte.AutoResizeColumns();
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarInscripciones();
        }

        private void buttonOrdenarAZ_Click(object sender, EventArgs e)
        {
            List<Reporte> alfabeticoAZ = reportes.OrderByDescending(a => a.taller).ToList();
            actualizarGrid(alfabeticoAZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Reporte> alfabeticoZA = reportes.OrderBy(a => a.taller).ToList();
            actualizarGrid(alfabeticoZA);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            cargarInscripciones();
        }
    }
}
