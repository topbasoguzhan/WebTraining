#region ViewResult
//public IActionResult GetProducts()
//{
//    ViewResult result = View();
//    return View();
//}
#endregion
#region PartialViewResult
//Yine bir View dosyasýný(.cshtml) render etmemizi saðlayan bir action türüdür. ViewResult'tan temel farký,client tabanlý yapýlan Ajax isteklerinde kullanýma yatkýn olmasýdýr. Client tabanlý isteklerde bunu kullanmak daha doðrudur. Teknik fark ise ViewResult _ViewStart.cshtml dosyasýný baz alýr. Lakin PartialViewResult ise ilgili dosyayý baz almadan render edilir. Bir internet sayfasý üzerinden örnek verecek olursak, sayfanýn tamamý yerine, belli bir parçasýný render etmek istiyorsak PartialView kullanýrýz.

//public PartialViewResult GetProducts()
//{
//    PartialViewResult result = PartialView();
//    return result;
//}
#endregion
#region JsonResult
//Üretilen datayý JSON türüne dönüþtürüp döndüren bir action türüdür.
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
//Bazen gelen istekler neticesinde herhangi bir þey döndürmek istemeyebiliriz. Böyle bir durumda EmptyResult action türü kullanýlabilir.

//public EmptyResult/*EmptyResult yerine void de yazýlabilir*/ GetProducts()
//{
//    return new EmptyResult();
//}

#endregion
#region ContentResult
//Ýstek neticesinde cevap olarak metinsel bir deðer döndürmemizi saðlayan action türüdür.
//public ContentResult GetProducts()
//{
//    ContentResult result = Content("Güzel günlerim vardý,yaðmurlarla ýslanan...");
//    return result;
//}

#endregion
#region ActionResult
//Bütün result türlerinin base class'ýdýr. Tüm action türlerini karþýlayan ana türdür.Gelen bir istek neticesinde geriye dönecek action türleri deðiþkenlik gösterebildiði durumlarda kullanýldýðý bir action türüdür.
//public ActionResult GetProducts()
//{
//    if (true)
//    {
//        //.....
//        return Json(new object());
//    }
//    else
//    {
//        return Content("alkwdawþlkd");
//    }
//    return View(); //yukardaki gibi farklý türde deðerleri döndürebilmemizi saðlar.
//}
#endregion
#region IActionResult
//Bu da ortak tür kullanmamýzý saðlar ActionResult gibi.

#endregion