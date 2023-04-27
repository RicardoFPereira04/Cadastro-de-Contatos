

    using Cadastro_de_Contatos.Data;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;

    namespace Cadastro_de_Contatos
    {
        public class Startup
        {
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;


            }

            public IConfiguration Configuration { get; }

            // Este método é usado para configurar os serviços necessários para o aplicativo
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddControllersWithViews();
                services.AddEntityFrameworkSqlServer().AddDbContext<BancoContext>(o => o.UseSqlServer(Configuration.GetConnectionString("DataBase")));


                // Aqui você pode adicionar outras configurações de serviços necessários
            }

            // Este método é usado para configurar o pipeline de execução do aplicativo

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                    app.UseExceptionHandler("/Home/Error");
                    app.UseHsts();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthorization();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
                });
            }
        }
    }







