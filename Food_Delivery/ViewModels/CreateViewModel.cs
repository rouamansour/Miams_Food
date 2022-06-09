using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Food_Delivery.ViewModels
{
    public class CreateViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Taille Max 50 cc")]
        public string Name { get; set; }
        public string Decription { get; set; }
        [Range(300, 5000, ErrorMessage = "Doit être entre 300 et 5000")]
        public int Price { get; set; }
        //public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
