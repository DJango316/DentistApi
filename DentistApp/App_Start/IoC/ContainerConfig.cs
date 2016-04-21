using Autofac;
using DentistApp.DAL.DbFactory;
using DentistApp.DAL.Repositories.Patient;
using DentistApp.DAL.Repositories.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using Autofac.Integration.WebApi;
using DentistApp.DAL.Repositories.Company;

namespace DentistApp.App_Start.IoC
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<DbFactory>().As<IDbFactory>()
                .WithParameter("connectionString", "DentistContext");
            builder.RegisterType<TaskRepository>().As<ITaskRepository>();
            builder.RegisterType<PatientRepository>().As<IPatientRepository>();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();

            return container;
        }
    }
}