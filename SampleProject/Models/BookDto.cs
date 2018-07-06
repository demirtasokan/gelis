using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class BookDto
    {
        public long id { get; set; }
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Isbn { get; set; }
    }
}