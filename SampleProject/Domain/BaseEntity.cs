
using Dapper.Contrib.Extensions;
using Dapper.Extensions.Linq.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Domain
{
    public class BaseEntity : IEntity
    {
        [Key]
        public int id { get; set; }
    }
}