using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;

namespace ProyectoSGCE.Models
{
    public class SpecimenModel
    {
        public async Task<List<Specimen>> GetSpecimensBySpeciesAsync(int name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?specimens={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Specimen> specimens = json["specimens"].ToObject<List<Specimen>>();


                    return specimens;
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
        public async Task<List<SpecimenDetails>> GetSpecimenDetailAsync(int name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?specimen={name}");

                if (response.IsSuccessStatusCode)
                {


                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<SpecimenDetails> specimens = json["specimen"].ToObject<List<SpecimenDetails>>();


                    return specimens;
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
        public async Task<List<Img>> GetSpecimenIMGAsync(int name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?specimenImg={name}");

                if (response.IsSuccessStatusCode)
                {


                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Img> imgs = json["img"].ToObject<List<Img>>();


                    return imgs;
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
