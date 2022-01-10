using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    //Bir sınıfı request alabilir ve response döndürebilir, yani controller yapabilmek için o sınıfı Controller class'ından türetmemiz gerekmektedir.
    //Controller sınıfları içerisinde istekleri karşılayan ve gerekli operasyonları gerçekleştiren metotlara action metot denir. Control sınıfları içerisinde tanımlanan tüm metotlar artık action metot olarak nitelendirilecektir.
    public class HomeController : Controller 
    {
        public IActionResult Index() 
        {
            Product product = new Product(); //Böyle model'a gidip veriyi almayı yapıyoruz aslında.

            return View();
            // View fonksiyonu bu actiona ait view(.cshtml) dosyasını tetikleyecek olan fonksiyondur.
            //ViewResult result = View(); Bunu direk kullanırsak ilgili action ismiyle birebir olan view'i tetikler.
            //ViewResult result = View("ahmet"); Lakin böyle kullanırsak içine yazdığımız view'i tetikleyecektir.
            //return result; bu iki şekilde de çağırabiliyoruz view'i



        } //Action metot: Controller'a gelen isteği karşılayan ve gerekli operasyonları gerçekleştiren metotlardır.
    }
}
