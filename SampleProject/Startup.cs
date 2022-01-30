using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)//Bu uygulamada kullanýlacak servislerin eklendiði/konfigüre edildiði metottur.
            //Servis nedir? Belirli iþlere odaklanmýþ ve o iþin sorumluluðunu üstlenmiþ kütüphaneler/sýnýflar/modüller vs.
        {
            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>()); //Asp.NET Core uygulamasýnda MVC mimarisini kullanabilmek için uygulamada Controller ve View yapýlanmalarýnýn eklenmesi gerekmektedir. Bunun için öncelikle bu servis uygulamaya ekleniyor. Böylece uygulama MVC davranýþý sergileyebilecektir.
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//Bu metotta da uygulamada kullanýlacak middleware/ara katmanlarý/ara yazýlýmlarý çaðýrmaktayýz.
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //Gelen isteðin rotasý bu middleware sayesinde belirleniyor.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("CustomRoute", "{controller=Home}/{action=Index}/{a}/{b}/{id}");//buradaki rotayý belirtirken deðerlerin isimlerinin sýralamasý önemli fakat controller'unda deðil.
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute(); //{controller=Home}/{action=Index}/{id?} => Default olan endpoint þemasý. Bu uygulamaya yapýlacak olan istekler bu þemaya uygun bir þekilde yapýlacaktýr.
            });//Endpoint:Yapýlan isteðin varýþ noktasý. Yani Url. Yani istek adresi.
            //Bu uygulamaya gelen isteklerin hangi rotalar/sablonlar esliginde gelebileceðini buradan bildireceðiz
        }
    }
}
