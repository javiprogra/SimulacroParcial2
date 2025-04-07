using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial2
{
    internal class AlumnoJson
    {
        //Guardar en archivo
        public void Guardar(string fileName, List<Alumno> alumnos)
        {
            string json = JsonConvert.SerializeObject(alumnos);
            System.IO.File.WriteAllText(fileName, json);
        }

        //Extraer del archivo
        public List<Alumno> Leer(string fileName)
        {
            List<Alumno> lista = new List<Alumno>();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Alumno>>(json) ?? new List<Alumno>();
            return lista;
        }
    }
}
