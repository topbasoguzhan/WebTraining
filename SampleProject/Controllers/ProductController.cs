using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    public class ProductController : Controller
    {
        #region ViewResult
        //public IActionResult GetProducts()
        //{
        //    ViewResult result = View();
        //    return View();
        //}
        #endregion
        #region PartialViewResult
        //Yine bir View dosyasını(.cshtml) render etmemizi sağlayan bir action türüdür. ViewResult'tan temel farkı,client tabanlı yapılan Ajax isteklerinde kullanıma yatkın olmasıdır. Client tabanlı isteklerde bunu kullanmak daha doğrudur. Teknik fark ise ViewResult _ViewStart.cshtml dosyasını baz alır. Lakin PartialViewResult ise ilgili dosyayı baz almadan render edilir. Bir internet sayfası üzerinden örnek verecek olursak, sayfanın tamamı yerine, belli bir parçasını render etmek istiyorsak PartialView kullanırız.

        //public PartialViewResult GetProducts()
        //{
        //    PartialViewResult result = PartialView();
        //    return result;
        //}
        #endregion
        #region JsonResult
        //Üretilen datayı JSON türüne dönüştürüp döndüren bir action türüdür.
        //public JsonResult GetProducts()
        //{
        //    JsonResult result = Json(new Product
        //    {
        //        Id = 5,
        //        ProductName = "Terlik",
        //        Quantity = 15
        //    });
        //    return result;
        //}
        #endregion
        #region EmptyResult
        //Bazen gelen istekler neticesinde herhangi bir şey döndürmek istemeyebiliriz. Böyle bir durumda EmptyResult action türü kullanılabilir.

        #endregion

    }
}
