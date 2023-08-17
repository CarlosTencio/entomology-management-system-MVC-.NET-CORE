using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoSGCE.Models
{
    public class OrderModel
    {
        public async Task<List<Order>> GetOrdersAsync(string name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?order={name}");

                if (response.IsSuccessStatusCode)
                {
                   
                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Order> orders = json["lista"].ToObject<List<Order>>(); // Acceder a la propiedad "lista" y deserializarla a List<Order>


                    return orders;
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
        public async Task<List<Order>> GetOrdersDescAsync(string name)
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync($"http://proyectosgce.online/api.php?order-desc={name}");

                if (response.IsSuccessStatusCode)
                {

                    string content = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(content); // Analizar el contenido JSON

                    List<Order> orders = json["lista"].ToObject<List<Order>>(); // Acceder a la propiedad "lista" y deserializarla a List<Order>


                    return orders;
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
