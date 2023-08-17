using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Order
    {
        public Order(string nombre, int total_familias, int total_subfamilias, int total_generos, int total_especies, int total_general)
        {
            NameOrder = nombre;
            TotalFamilies = total_familias;
            TotalSubfamilies = total_subfamilias;
            TotalGenres = total_generos;
            TotalSpecies = total_especies;
            TotalGeneral = total_general;
        }

        [JsonPropertyName("nombre")]
        public string NameOrder { get; set; }

        [JsonPropertyName("total_familias")]
        public int TotalFamilies { get; set; }

        [JsonPropertyName("total_subfamilias")]
        public int TotalSubfamilies { get; set; }

        [JsonPropertyName("total_generos")]
        public int TotalGenres { get; set; }

        [JsonPropertyName("total_especies")]
        public int TotalSpecies { get; set; }

        [JsonPropertyName("total_general")]
        public int TotalGeneral { get; set; }
    }

}

