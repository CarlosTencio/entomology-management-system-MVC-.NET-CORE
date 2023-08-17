using Microsoft.CodeAnalysis;
using System.Reflection;
using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Specimen
    {
        [JsonPropertyName("id_especimen")]
        public int id_specimen { get; set; }

        [JsonPropertyName("Almacenaje")]
        public string storage { get; set; }
        [JsonPropertyName("Lugar")]
        public string location { get; set; }
        [JsonPropertyName("Genero")]
        public string gender { get; set; }
        [JsonPropertyName("Especie")]
        public string specie { get; set; }
        [JsonPropertyName("id_genero")]
        public int id_gender { get; set; }
        [JsonPropertyName("id_especie")]
        public int id_specie { get; set; }

        [JsonPropertyName("Orden")]
        public string order { get; set; }
        [JsonPropertyName("Familia")]
        public string family { get; set; }
        [JsonPropertyName("Subfamilia")]
        public string subfamily { get; set; }

        
        public Specimen(int id_especimen, string Almacenaje, string Lugar,
            string Genero, string Especie, int id_genero, int id_especie,string orden,string familia,string subfamilia)
        {
            id_specimen = id_especimen;
            storage = Almacenaje;
            location = Lugar;
            gender = Genero;
            specie = Especie;
            id_gender = id_genero;
            this.id_specie = id_especie;
            order = orden;
            family = familia;
            subfamily = subfamilia;
        }
    }
}
   

