using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab23_SWAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23_SWAPI.Controllers
{
    public class StarWarsController : Controller
    {
        public IActionResult Index(string personId, string planetId)
        {
            if(personId != null)
            {
                return RedirectToAction("Person", personId);
            }
            else if (planetId != null)
            {
                return RedirectToAction("Planet", planetId);
            }

            return View();
        }

        public async Task<IActionResult> Person(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"people/{id}/");
            //var response = await client.GetAsync($"people/1/");
            var person = await response.Content.ReadAsAsync<People>();

            return View(person);
        }

        public async Task<IActionResult> Planet(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"planets/1/");
            //var response = await client.GetAsync($"planet/{id}/");
            var planet = await response.Content.ReadAsAsync<Planet>();

            return View(planet);
        }



    }
}