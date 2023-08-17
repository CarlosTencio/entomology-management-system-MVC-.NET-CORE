using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Subfamily
    {
        public Subfamily(string nombre, int total_generos, int total_especies, int total_general)
        {
            NameSubfamily = nombre;
            TotalGenres = total_generos;
            TotalSpecies = total_especies;
            TotalGeneral = total_general;
        }

        [JsonPropertyName("nombre")]
        public string NameSubfamily { get; set; }
       
        [JsonPropertyName("total_generos")]
        public int TotalGenres { get; set; }

        [JsonPropertyName("total_especies")]
        public int TotalSpecies { get; set; }

        [JsonPropertyName("total_general")]
        public int TotalGeneral { get; set; }
    }
}
