using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ByParcial2Pro3.Models;

namespace ByParcial2Pro3.Models
{
    public class ArchivoPersonajes
    {
        string ruta = "personajes.json";

        public void Guardar(List<Personaje> lista)
        {
            string json = JsonConvert.SerializeObject(
                lista,
                Newtonsoft.Json.Formatting.Indented
            );

            File.WriteAllText(ruta, json);
        }

        public List<Personaje> Leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Personaje>();
            }

            string json = File.ReadAllText(ruta);

            return JsonConvert.DeserializeObject<List<Personaje>>(json)
                   ?? new List<Personaje>();
        }
    }
}
