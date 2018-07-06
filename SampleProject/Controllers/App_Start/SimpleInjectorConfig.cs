
using Npgsql;
using SampleProject.Repository;
using SampleProject.Service.Concrete;
using SampleProject.Service.Contracts;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace SampleProject.App_Start
{
    public static class SimpleInjectorConfig
    {
        public static void Register()
        {
            var container = new SimpleInjector.Container();  
            //Daha sonra config dosyasından alınacak.
            container.Register<IDbConnection>(() => new NpgsqlConnection("Host=localhost;Username=postgres;Password=1234;Database=postgres"),Lifestyle.Singleton);
            container.Register<IBookService, BookService>(Lifestyle.Transient);           
            container.Register<IBookRepository, BookRepository>(Lifestyle.Transient);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Store the container for use by the application
            GlobalConfiguration.Configuration.DependencyResolver =
                    new SimpleInjectorWebApiDependencyResolver(container);


        }
    }
}