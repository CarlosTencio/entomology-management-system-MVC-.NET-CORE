using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Specie
    {
        public Specie(int id_especie, string especie, string orden, string familia,
            string subfamilia, string genero, int id_gedero)
        {
            this.id_specie = id_especie;
            this.specie = especie;
            this.order = orden;
            this.family = familia;
            this.subfamily = subfamilia;
            this.gender = genero;
            this.id_gender = id_gedero;
        }

        [JsonPropertyName("id_especie")]
        public int id_specie { get; set; }
        [JsonPropertyName("especie")]
        public string specie { get; set; }
        [JsonPropertyName("orden")]
        public string order { get; set; }
        [JsonPropertyName("familia")]
        public string family { get; set; }
        [JsonPropertyName("subfamilia")]
        public string subfamily { get; set; }
        [JsonPropertyName("genero")]
        public string gender { get; set; }
        [JsonPropertyName("id_genero")]
        public int id_gender { get; set; }

        
    }
}
