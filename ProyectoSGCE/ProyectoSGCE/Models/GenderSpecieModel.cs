using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace ProyectoSGCE.Models
{
    public class GenderSpecieModel
    {
        public async Task<List<GenderSpecie>> GetGenderSpeciesync(string name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?gender={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<GenderSpecie> genderSpecies = json["genders"].ToObject<List<GenderSpecie>>(); // Acceder a la propiedad "lista" y deserializarla a List<Order>


                    return genderSpecies;
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

