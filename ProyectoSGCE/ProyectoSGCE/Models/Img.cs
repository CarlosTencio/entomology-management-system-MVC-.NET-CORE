using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Img
    {
        [JsonPropertyName("ruta_imagen")]
        public string rootImg { get; set; }

        public Img(string ruta_imagen)
        {
            this.rootImg = ruta_imagen;
        }
    }
}
