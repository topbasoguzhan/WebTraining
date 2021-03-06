using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;
using SampleProject.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace SampleProject.Controllers
{
    #region [NonController]
    //Böyle yaparsak bütün controller'ı sadece iş mantığında kullanmış olacağız. İşlevselliğini kaybedip normal bir sınıf gibi olacak ve request alamayacaktır.
    #endregion
    public class ProductController : Controller
    {

        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(Product model)
        {
            //ModelState: MVC'de bir type'ın data annotationlarını kontrol eden ve geriye sonuç dönen bir property.
            if (!ModelState.IsValid)
            {
                //Loglama
                //Kullanıcı bilgilendirme
                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;//Bu şekilde modelstate'de hangisinin hata verdiğini alabiliyoruz.Ama bu kadar uzun yazmaya gerek tabiki de yok. Aşağıda tanımladığımız var messages  satırı ile view'da yaptığımız span işlemiyle birlikte hataları bize kolay bir şekilde geri döndürebiliyoruz.

                var messages = ModelState.ToList();

                return View(model);
            }
            //İşlem/Operasyon/Algoritmaya tabi tutulur.
            #region SecondWay
            //if (ModelState.IsValid) //yukardaki yazdığımı kontrol böyle de yazılabilir
            //{
            //İşlem/Operasyon/Algoritmaya tabi tutulur.


            //}
            //else
            //{

            //}
            #endregion
            //if(!string.IsNullOrEmpty(model.ProductName) && model.ProductName.Length <= 100 && model.Email) doğrulamayı böyle koşul yöntemiyle yapmak hiç doğru olmayacak ve maliyetli olacaktır.

            return View();
        }      
    }
}

#region ProductDenemesi
//public IActionResult Index()
//{
//    var products = new List<Product>
//    {
//        new Product { Id = 1, ProductName = "A Product", Quantity = 10},
//        new Product { Id = 2, ProductName = "B Product", Quantity = 15},
//        new Product { Id = 3, ProductName = "C Product", Quantity = 20},

//    };
#endregion
#region Model Bazlı Veri Gönderimi
//return View(); kullanarak model bazlı veri gönderimini kullanabiliriz. Yalnız bunu kullanırken .cshtml dosyasında da yapmamız gereken bir ayar var onu orada açıkladım. (Products.Index)
//return View(products); //direk göndermek istediğimiz modeli de belirtebiliriz.
#endregion
#region Veri Taşıma Kontrolleri
#region TempData
//ViewData'da olduğu gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür. Farkı ise bir actionda elde edilen dataları farklı bir action'a göndermek istiyorsak burada TempData'yı kullanabiliriz,diğerleriyle bu işlemi gerçekleştiremeyiz.
//string data = JsonSerializer.Serialize(products);
//TempData["products"] = data;

//TempData["x"] = 5;
//ViewBag.x = 5;
//ViewData["x"] = 5;

//return RedirectToAction("Index2" , "Product");
#endregion
#region ViewBag
//View'e gönderilecek/taşınacak datayı dynamic şekilde tanımlanan bir değişkenle taşımamızı sağlayan bir veri taşıma kontrolüdür.
//ViewBag.products = products;
#endregion
#region ViewData
//ViewBag'de olduğu gibi actiondaki datayı view'e taşımamızı sağlayan bir kontroldür. ViewData datayı boxing ederek taşır. Haliyle bunu view'de unboxing etmeliyiz. 'as' diyip devamında yazdıklarımızla unboxing ediyoruz zaten
//ViewData["products"] = products;
#endregion
#endregion
#region Uygulama
//public IActionResult Index2()
//{
//    //var v1 = ViewBag.x;
//    //var v2 = ViewData["x"];
//    //var v3 = TempData["x"];

//    var data = TempData["products"].ToString();
//    List<Product> products = JsonSerializer.Deserialize<List<Product>>(data);

//    return View();
//}

//public IActionResult GetProducts()
//{
//    Product product = new Product()
//    {
//        Id = 1,
//        ProductName = "A Product",
//        Quantity = 15,
//    };

//    User user = new User()
//    {
//        Id = 1,
//        Name = "Gençay",
//        LastName = "Yıldız"
//    };

//    //UserProduct userProduct = new UserProduct()
//    //{
//    //    User = user,
//    //    Product = product,
//    //};

//    //return View(userProduct);

//    var userProduct = (product, user);

//    return View(userProduct);
//}
#endregion
#region Partial Deneme
/*public IActionResult GetProducts()
{
    ViewBag.Message = "Merhaba";
    User u = new User
    {
        LastName = "TOPBAŞ" //Burdan gönderildi model bazlı mesela(açıklama devamı orada)
    };
}*/
#endregion
#region ModelBinding Denemesi
/*public IActionResult CreateProduct() //CreateProduct'a get isteği gelirse bunu tetikleyecek
{
    var product = new Product()
    {
        ProductName = "DefaultName",
        Quantity = 25
    };
    return View(product);
}

[HttpPost]
public IActionResult CreateProduct(Product product)
//public IActionResult CreateProduct(string txtProductName, string txtQuantity /*Request neticesinde gelen dataların hepsi Action fonksiyonlarda parametrelerden yakalanmaktadır.)*///Post isteği gelirse bunu tetikleyecektir.
#endregion
#region Methods of getting data from user with form
/*public class Model
        {
            public string txtValue1 { get; set; }
            public string txtValue2 { get; set; }
            public string txtValue3 { get; set; }

        }
public IActionResult VeriAl(Model model)
public IActionResult VeriAl(Product model)
public IActionResult VeriAl(string txtValue1, string txtValue2, string txtValue3)
public IActionResult VeriAl(IFormCollection datas)
{
    //var value1 = datas["txtValue1"].ToString();
    //var value2 = datas["txtValue2"].ToString();
    //var value3 = datas["txtValue3"]; //ToString'ler string olarak değerleri yakalayabilmek için.
}*/
#endregion
#region Get Data with QueryString
/*public IActionResult VeriAl(string a, string b)
public IActionResult VeriAl()
{
    var queryString = Request.QueryString; //Request yapılan endpoint'e query string parametresi eklemeli mi eklenmemeli mi bununla ilgili bilgi verir.
    var a = Request.Query["a"].ToString();
    var b = Request.Query["b"].ToString();
    return View();
}*/
#endregion
#region Get Data with Route
//public IActionResult VeriAl(string id, string a, string b)
//public IActionResult VeriAl(RouteData datas)

//{
//    var values = Request.RouteValues; //rota değerlerini görebilmek için yazdık.
//    return View();
//}
#endregion
#region Get Data with Header
//public IActionResult VeriAl()
//{
//    var headers = Request.Headers.ToList();
//    return View();
//}
#endregion
#region Get Data with Ajax
//public class AjaxData
//{
//    public string A { get; set; }
//    public string B { get; set; }
//}
//[HttpPost]
//public IActionResult VeriAl(AjaxData ajaxData)
//{
//    return View();
//}

#endregion
#region Tuple Object
//public IActionResult CreateProduct()
//{
//    var tuple = (new Product(), new User());
//    return View(tuple); //bunu yaparak tuple nesnemizin null olmamasını sağladık. Bunu da post ettiğimiz Action'ın Get'ine yapmamız gerekiyor.
//}
//[HttpPost]
//public IActionResult CreateProduct([Bind(Prefix = "Item1")] Product product, [Bind(Prefix = "Item2")] User user) //Prefix kullanmadan tuple nesneyi yakalayamadık.
//{
//    return View();
//}
#endregion
