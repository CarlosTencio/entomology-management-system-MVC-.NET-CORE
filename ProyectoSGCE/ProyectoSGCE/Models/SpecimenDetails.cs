using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class SpecimenDetails
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


        [JsonPropertyName("distrito")]
        public string District { get; set; }

        [JsonPropertyName("canton")]
        public string Canton { get; set; }

        [JsonPropertyName("provincia")]
        public string Province { get; set; }

        [JsonPropertyName("pais")]
        public string Country { get; set; }

        [JsonPropertyName("fecha")]
        public string Date { get; set; }

        [JsonPropertyName("recolector")]
        public string Collector { get; set; }

        [JsonPropertyName("orden")]
        public string Order { get; set; }

        [JsonPropertyName("familia")]
        public string Family { get; set; }

        [JsonPropertyName("subfamilia")]
        public string Subfamily { get; set; }

        [JsonPropertyName("etiqueta")]
        public int Label { get; set; }

        [JsonPropertyName("especimen")]
        public int Specimen2 { get; set; }

        public SpecimenDetails(int id_especimen, string Almacenaje, string Lugar, string Genero, string Especie, int id_genero, int id_especie,
        string distrito, string canton, string provincia, string pais, string fecha, string recolector, string orden,
        string familia, string subfamilia, int etiqueta, int especimen)
        {
            id_specimen = id_especimen;
            storage = Almacenaje;
            location = Lugar;
            gender = Genero;
            specie = Especie;
            id_gender = id_genero;
            id_specie = id_especie;
            District = distrito;
            Canton = canton;
            Province = provincia;
            Country = pais;
            Date = fecha;
            Collector = recolector;
            Order = orden;
            Family = familia;
            Subfamily = subfamilia;
            Label = etiqueta;
            Specimen2 = especimen;
        }
    }
}
