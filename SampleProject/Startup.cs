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
        public void ConfigureServices(IServiceCollection services)//Bu uygulamada kullan�lacak servislerin eklendi�i/konfig�re edildi�i metottur.
            //Servis nedir? Belirli i�lere odaklanm�� ve o i�in sorumlulu�unu �stlenmi� k�t�phaneler/s�n�flar/mod�ller vs.
        {
            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>()); //Asp.NET Core uygulamas�nda MVC mimarisini kullanabilmek i�in uygulamada Controller ve View yap�lanmalar�n�n eklenmesi gerekmektedir. Bunun i�in �ncelikle bu servis uygulamaya ekleniyor. B�ylece uygulama MVC davran��� sergileyebilecektir.
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)//Bu metotta da uygulamada kullan�lacak middleware/ara katmanlar�/ara yaz�l�mlar� �a��rmaktay�z.
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting(); //Gelen iste�in rotas� bu middleware sayesinde belirleniyor.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("CustomRoute", "{controller=Home}/{action=Index}/{a}/{b}/{id}");//buradaki rotay� belirtirken de�erlerin isimlerinin s�ralamas� �nemli fakat controller'unda de�il.
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapDefaultControllerRoute(); //{controller=Home}/{action=Index}/{id?} => Default olan endpoint �emas�. Bu uygulamaya yap�lacak olan istekler bu �emaya uygun bir �ekilde yap�lacakt�r.
            });//Endpoint:Yap�lan iste�in var�� noktas�. Yani Url. Yani istek adresi.
            //Bu uygulamaya gelen isteklerin hangi rotalar/sablonlar esliginde gelebilece�ini buradan bildirece�iz
        }
    }
}
