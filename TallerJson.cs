using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial2
{
    internal class TallerJson
    {
        //Guardar en archivo
        public void Guardar(string fileName, List<Taller> talleres)
        {
            string json = JsonConvert.SerializeObject(talleres);
            System.IO.File.WriteAllText(fileName, json);
        }

        //Extraer del archivo
        public List<Taller> Leer(string fileName)
        {
            List<Taller> lista = new List<Taller>();
            StreamReader jsonStream = File.OpenText(fileName);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Taller>>(json) ?? new List<Taller>();
            return lista;
        }
    }
}
