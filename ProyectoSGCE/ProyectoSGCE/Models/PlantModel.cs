using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace ProyectoSGCE.Models
{
    public class PlantModel
    {
        public async Task<List<Plant>> GetPlantsAsync(string name) {

            
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?plant={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Plant> plants = json["lista"].ToObject<List<Plant>>();


                    return plants;
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
        public async Task<List<PlantName>> GetPlantsByGenderAsync(int name)
        {


            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?plantsGender={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<PlantName> plants = json["plants"].ToObject<List<PlantName>>();


                    return plants;
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
