using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPageWithAspNetMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Discription { get; set; }
        public int Pages { get; set; }
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Update Image")]
        public IFormFile ImageFile { get; set; }


    }
}
