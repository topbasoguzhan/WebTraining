/*Razor Nedir?: Asp.NET Core MVC mimarisinde .cshtml uzantýlý dosyalarda HTML ile birlikte yazýlan C# kodlarýnýn server tarafýnda çalýþtýrýlmasýný saðlayan bir teknolojidir. Operatörü '@' dir.
 * ----Razor ile Deðiþken Oluþturma----
@{
    int a = 5;
    Console.WriteLine(a)
}
yukardaki süslü parantez içine yazacaðýmýz her þey C# kodu haline gelmektedir. */

/*---Razor ile Parçalý Scope Yapýsý---
 * Parçalý scope yapýlanmasýný yapabiliyoruz. Farklý bir Razor scope'unda tanýmlanan, esasýnda derleyici kýsmýnda ayný scope içinde görülen CSHTML dosyasýna da farklý bir Razor scope'undan eriþilebilmektedir. Bu özellik bize güzel bir esneklik saðlamaktadýr.
 
 * ---Razor Ýçerisinde HTML Kullanýmý---
 * Evet direk bir text basacaksak mesela eðer,bunu html þeklinde Razor içine yazarak da gerçekleþtirebiliyoruz.

 * ---Razor Ýle Tek Satýrlýk Ýþlemler---
 * Sayýsal Ýþlemler: <h3>@(33 % 5 == 3 ? "Evet" : "Hayýr" ) </h3>
 
 * ---Ternary Operatörü---
 * <h3>@(33 % 5 == 3 ? "Evet" : "Hayýr" ) </h3>. Ternary operatörü üç iþlem alan tek operatördür. Bir bakýma if 
   else yapýsýna da çok benzerlik göstermektedir.

 *---Koþul Yapýlarý---
 *if veya benzeri koþullu yapýlanmalarý,döngü yapabilmek için Razor scope bloklarýný kullanmamýza gerek yok Razor bunu algýlar.