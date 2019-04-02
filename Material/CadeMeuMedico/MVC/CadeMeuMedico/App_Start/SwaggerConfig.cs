using System.Web.Http;
using WebActivatorEx;
using CadeMeuMedico;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace CadeMeuMedico
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c => {                    
                    c.SingleApiVersion("v1", "CadeMeuMedico");
                })                
                .EnableSwaggerUi();
        }
    }
}
