using Microsoft.OpenApi;

namespace OrderFlow.API.Extensions
{
    public static class SwaggerConfigExtension
    {
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
        {
            //Configurando o Swagger
            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Overflow - API para gerenciamento de pedidos",
                    Description = "C# Arquiteto Formação DEVOPS"
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            //Executando o swagger
            app.UseSwagger();
            app.UseSwaggerUI();

            return app;
        }
    }
}