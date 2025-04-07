using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial2
{
    internal class InscripcionJson
    {
        //Guardar en archivo
        public void Guardar(string fileName, List<Inscripcion> inscripciones)
        {
            string json = JsonConvert.SerializeObject(inscripciones);
            System.IO.File.WriteAllText(fileName, json);
        }

        //Extraer del archivo
        public List<Inscripcion> Leer(string fileName)
        {
            List<Inscripcion> lista = new List<Inscripcion  >();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Inscripcion>>(json) ?? new List<Inscripcion>();
            return lista;
        }
    }
}
