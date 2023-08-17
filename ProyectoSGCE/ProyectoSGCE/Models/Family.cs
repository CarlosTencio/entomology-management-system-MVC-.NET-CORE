using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ProyectoSGCE.Models
{
    public class Family
    {
        public Family(string nombre, int total_subfamilias, int total_generos, int total_especies, int total_general)
        {
            this.nombre = nombre;
            this.total_subfamilias = total_subfamilias;
            this.total_generos = total_generos;
            this.total_especies = total_especies;
            this.total_general = total_general;
        }

        public string nombre { get; set; }
      
        public int total_subfamilias { get; set; }

       
        public int total_generos { get; set; }

        public int total_especies { get; set; }

        public int total_general { get; set; }

    }
}
