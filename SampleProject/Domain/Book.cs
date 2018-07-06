using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Domain
{
    [Table("Book")]
    public class Book : BaseEntity
    {
        public string name { get; set; }

        public DateTime? publishdate { get; set; }

        public string isbn { get; set; }



    }
}