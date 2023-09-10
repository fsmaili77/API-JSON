using Microsoft.AspNetCore.Mvc;

namespace ApiJson.Models
{
    public class Produit
    {
        // Identifiant du produit
        public int Id { get; set; }

        // Nom du produit
        public string? Nom { get; set; }

        // Prix du produit
        public decimal Prix { get; set; }

        public static explicit operator Produit(NotFoundResult v)
        {
            throw new NotImplementedException();
        }
    }
}
