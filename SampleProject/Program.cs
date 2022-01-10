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
    public class Program // Asp.NET Core uygulamar� �z�nde bir console uygulamas�d�r.
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //Kendi dahilindeki uygulama sunucusunu aya�a kald�rmak i�in Program.cs'in i�inde aya�a kald�r�r. Bu Asp.NET'in kendi dahilindeki sunucudur.

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }); //Program.cs i�erisinde aya�a kald�r�lacak hostun kullanaca�� konfig�rasyonar nerden alaca��n� bildirmektedir(Startup'dan yani).
                    //Startup:Temel konfig�rasyon s�n�f�m�z.
        
    }
}
