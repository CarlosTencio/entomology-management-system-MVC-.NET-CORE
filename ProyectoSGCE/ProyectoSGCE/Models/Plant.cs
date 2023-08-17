using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Plant

    {
        [JsonPropertyName("orden")]
        public string Order { get; set; }
        [JsonPropertyName("familia")]
        public string Family { get; set; }

        [JsonPropertyName("Subfamilia")]
        public string Subfamily { get; set; }

        [JsonPropertyName("Genero")]
        public string Gender { get; set; }
        [JsonPropertyName("id_genero")]
        public int id_gender { get; set; }
        [JsonPropertyName("Especies")]
        public string Species { get; set; }//cantidad de especies

        public Plant(string orden, string familia, string Subfamilia, string Genero, int id_genero, string Especies)
        {
            Order = orden;
            Family = familia;
            Subfamily = Subfamilia;
            Gender = Genero;
            this.id_gender = id_genero;
            Species = Especies;
        }
    }
    public class PlantName
    {
        [JsonPropertyName("nombre_planta")]
        public string Name { get; set; }

        public PlantName(string nombre_planta)
        {
            Name = nombre_planta;
        }
    }
}
