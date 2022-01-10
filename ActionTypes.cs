#region ViewResult
//public IActionResult GetProducts()
//{
//    ViewResult result = View();
//    return View();
//}
#endregion
#region PartialViewResult
//Yine bir View dosyas�n�(.cshtml) render etmemizi sa�layan bir action t�r�d�r. ViewResult'tan temel fark�,client tabanl� yap�lan Ajax isteklerinde kullan�ma yatk�n olmas�d�r. Client tabanl� isteklerde bunu kullanmak daha do�rudur. Teknik fark ise ViewResult _ViewStart.cshtml dosyas�n� baz al�r. Lakin PartialViewResult ise ilgili dosyay� baz almadan render edilir. Bir internet sayfas� �zerinden �rnek verecek olursak, sayfan�n tamam� yerine, belli bir par�as�n� render etmek istiyorsak PartialView kullan�r�z.

//public PartialViewResult GetProducts()
//{
//    PartialViewResult result = PartialView();
//    return result;
//}
#endregion
#region JsonResult
//�retilen datay� JSON t�r�ne d�n��t�r�p d�nd�ren bir action t�r�d�r.
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
//Bazen gelen istekler neticesinde herhangi bir �ey d�nd�rmek istemeyebiliriz. B�yle bir durumda EmptyResult action t�r� kullan�labilir.

//public EmptyResult/*EmptyResult yerine void de yaz�labilir*/ GetProducts()
//{
//    return new EmptyResult();
//}

#endregion
#region ContentResult
//�stek neticesinde cevap olarak metinsel bir de�er d�nd�rmemizi sa�layan action t�r�d�r.
//public ContentResult GetProducts()
//{
//    ContentResult result = Content("G�zel g�nlerim vard�,ya�murlarla �slanan...");
//    return result;
//}

#endregion
#region ActionResult
//B�t�n result t�rlerinin base class'�d�r. T�m action t�rlerini kar��layan ana t�rd�r.Gelen bir istek neticesinde geriye d�necek action t�rleri de�i�kenlik g�sterebildi�i durumlarda kullan�ld��� bir action t�r�d�r.
//public ActionResult GetProducts()
//{
//    if (true)
//    {
//        //.....
//        return Json(new object());
//    }
//    else
//    {
//        return Content("alkwdaw�lkd");
//    }
//    return View(); //yukardaki gibi farkl� t�rde de�erleri d�nd�rebilmemizi sa�lar.
//}
#endregion
#region IActionResult
//Bu da ortak t�r kullanmam�z� sa�lar ActionResult gibi.

#endregion