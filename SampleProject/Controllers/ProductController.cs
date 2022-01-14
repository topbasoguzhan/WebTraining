using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;
using SampleProject.Models.ViewModels;
using System.Collections.Generic;
using System.Text.Json;

namespace SampleProject.Controllers
{
    #region [NonController]
    //Böyle yaparsak bütün controller'ı sadece iş mantığında kullanmış olacağız. İşlevselliğini kaybedip normal bir sınıf gibi olacak ve request alamayacaktır.
    #endregion
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, ProductName = "A Product", Quantity = 10},
                new Product { Id = 2, ProductName = "B Product", Quantity = 15},
                new Product { Id = 3, ProductName = "C Product", Quantity = 20},

            };

            #region Model Bazlı Veri Gönderimi
            //return View(); kullanarak model bazlı veri gönderimini kullanabiliriz. Yalnız bunu kullanırken .cshtml dosyasında da yapmamız gereken bir ayar var onu orada açıkladım. (Products.Index)
            //return View(products); //direk göndermek istediğimiz modeli de belirtebiliriz.
            #endregion
            #region Veri Taşıma Kontrolleri
            #region ViewBag
            //View'e gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.
            ViewBag.products = products;
            #endregion
            #region ViewData
            //ViewBag'de olduğu gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür. ViewData datayı boxing ederek taşır. Haliyle bunu view'de unboxing etmeliyiz. 'as' diyip devamında yazdıklarımızla unboxing ediyoruz zaten
            //ViewData["products"] = products;
            #endregion
            #region TempData
            //ViewData'da olduğu gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür. Farkı ise bir actionda elde edilen dataları farklı bir action'a göndermek istiyorsak burada TempData'yı kullanabiliriz,diğerleriyle bu işlemi gerçekleştiremeyiz.
            string data = JsonSerializer.Serialize(products);
            TempData["products"] = data;

            //TempData["x"] = 5;
            //ViewBag.x = 5;
            //ViewData["x"] = 5;

            return RedirectToAction("Index2" , "Product");
            #endregion
            #endregion

            //return View();
        }

        public IActionResult Index2()
        {
            //var v1 = ViewBag.x;
            //var v2 = ViewData["x"];
            //var v3 = TempData["x"];

            var data = TempData["products"].ToString();
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);
            
            return View();
        }

        public IActionResult GetProduct()
        {
            Product product = new Product()
            {
                Id = 1,
                ProductName = "A Product",
                Quantity = 15,
            };

            User user = new User()
            {
                Id = 1,
                Name = "Gençay",
                LastName = "Yıldız"
            };

            //UserProduct userProduct = new UserProduct()
            //{
            //    User = user,
            //    Product = product,
            //};

            //return View(userProduct);

            var userProduct = (product, user);

            return View(userProduct);
        }        
    }
}
