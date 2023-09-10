using ApiJson.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ApiJson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitsController : Controller
    {
        private static readonly List<Produit> produitsData = new List<Produit>();

        static ProduitsController()
        {
            // Charger les données des produits à partir d'un fichier JSON
            string jsonData = System.IO.File.ReadAllText("wwwroot/produits.json");
            produitsData = JsonConvert.DeserializeObject<List<Produit>>(jsonData);
        }

        // Obtenir tous les produits
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(produitsData);
        }

        // Obtenir un produit par son ID
        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var produit = produitsData.FirstOrDefault(p => p.Id == id) ?? (Produit)NotFound();

            if (produit == null)
            {
                return NotFound();
            }

            return Ok(produit);
        }
    }
}