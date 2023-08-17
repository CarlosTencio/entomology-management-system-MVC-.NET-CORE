using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProyectoSGCE.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoSGCE.Controllers
{
    public class SpecimenController : Controller
    {
        private readonly UserModel model2;

        public SpecimenController(IConfiguration configuration)
        {

            model2 = new UserModel(configuration);
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                return View();
            }
            return RedirectToAction("Login", "User");

        }
        [HttpGet]
        public async Task<IActionResult> RedirectSearch(int specimen)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                 SpecimenModel model = new SpecimenModel();


                var specimens = await model.GetSpecimensBySpeciesAsync(specimen);
                 ViewBag.Specimens = specimens; // Asignar los especimenes a ViewBag.Specimens

                List<List<CommentSpecimen>> specimensComment = new List<List<CommentSpecimen>>();
    
             foreach (var specimenloop in specimens)
             {
                var comments = await model2.GetComments(specimenloop.id_specimen); // Obtener los comentarios del especimen
                specimensComment.Add(comments);
             }

                ViewBag.SpecimensComment = specimensComment; // Asignar los comentarios a ViewBag.SpecimensComment

             return View("SearchSpecimenView");
            }
            return RedirectToAction("RedirectLogin", "User");
           
        }
        [HttpPost]
        public async Task<IActionResult> SearchSpecimenView(int specimen)
        {
            if (HttpContext.Session.GetString("User") != null)
            {
                SpecimenModel model = new SpecimenModel();


            var specimens = await model.GetSpecimensBySpeciesAsync(specimen);
            ViewBag.Specimens = specimens; // Asignar los especimenes a ViewBag.Specimens

            List<List<CommentSpecimen>> specimensComment = new List<List<CommentSpecimen>>();

            foreach (var specimenloop in specimens)
            {
                var comments =await model2.GetComments(specimenloop.id_specimen); // Obtener los comentarios del especimen
                specimensComment.Add(comments);
            }

            ViewBag.SpecimensComment = specimensComment; // Asignar los comentarios a ViewBag.SpecimensComment
               
            return View();
            }

            return RedirectToAction("Login", "User");
           
        }

        public async Task<IActionResult> SpecimenDetailsView(int specimen,int gender)
        {
            SpecimenModel model = new SpecimenModel();
            PlantModel modelP=new PlantModel();
            var specimens = await model.GetSpecimenDetailAsync(specimen);
            var plants = await modelP.GetPlantsByGenderAsync(gender);
            var img = await model.GetSpecimenIMGAsync(specimen);
            List<String> imagenesRuta = new List<String>();
            foreach (var image in img)
            {
                var rutaCompleta = "https://proyectosgce.online" + image.rootImg.Substring(1);
                imagenesRuta.Add(rutaCompleta);
            }


            ViewBag.Img = imagenesRuta;
            ViewBag.Plants = plants;
            ViewBag.Specimens = specimens;


            return View();
        }

    }
}
