using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace ProyectoSGCE.Models
{
    public class FamilyModel
    {
        public async Task<List<Family>> GetFamilyAsync(string name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?family={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Family> families = json["lista"].ToObject<List<Family>>(); // Acceder a la propiedad "lista" y deserializarla a List<Order>


                    return families;
                }
                else
                {
                    // Manejar el caso en que la solicitud no fue exitosa
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error de la solicitud
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<List<Family>> GetFamiliesDescAsync(string name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?family-desc={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Family> families = json["lista"].ToObject<List<Family>>(); // Acceder a la propiedad "lista" y deserializarla a List<Order>


                    return families;
                }
                else
                {
                    // Manejar el caso en que la solicitud no fue exitosa
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error de la solicitud
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
