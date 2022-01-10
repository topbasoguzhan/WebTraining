using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject
{
    public class Program // Asp.NET Core uygulamarý özünde bir console uygulamasýdýr.
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //Kendi dahilindeki uygulama sunucusunu ayaða kaldýrmak için Program.cs'in içinde ayaða kaldýrýr. Bu Asp.NET'in kendi dahilindeki sunucudur.

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }); //Program.cs içerisinde ayaða kaldýrýlacak hostun kullanacaðý konfigürasyonar nerden alacaðýný bildirmektedir(Startup'dan yani).
                    //Startup:Temel konfigürasyon sýnýfýmýz.
        
    }
}
