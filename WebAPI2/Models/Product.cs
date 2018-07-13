using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Product()
        {
            ImageName = "default.png";
        }
    }
}