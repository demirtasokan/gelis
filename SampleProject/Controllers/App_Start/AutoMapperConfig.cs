using AutoMapper;
using SampleProject.Domain;
using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Book, BookDto>();
                cfg.CreateMap<BookDto,Book >();
            });
        }
    }
}