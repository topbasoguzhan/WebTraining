/*Razor Nedir?: Asp.NET Core MVC mimarisinde .cshtml uzant�l� dosyalarda HTML ile birlikte yaz�lan C# kodlar�n�n server taraf�nda �al��t�r�lmas�n� sa�layan bir teknolojidir. Operat�r� '@' dir.
 * ----Razor ile De�i�ken Olu�turma----
@{
    int a = 5;
    Console.WriteLine(a)
}
yukardaki s�sl� parantez i�ine yazaca��m�z her �ey C# kodu haline gelmektedir. */

/*---Razor ile Par�al� Scope Yap�s�---
 * Par�al� scope yap�lanmas�n� yapabiliyoruz. Farkl� bir Razor scope'unda tan�mlanan, esas�nda derleyici k�sm�nda ayn� scope i�inde g�r�len CSHTML dosyas�na da farkl� bir Razor scope'undan eri�ilebilmektedir. Bu �zellik bize g�zel bir esneklik sa�lamaktad�r.
 
 * ---Razor ��erisinde HTML Kullan�m�---
 * Evet direk bir text basacaksak mesela e�er,bunu html �eklinde Razor i�ine yazarak da ger�ekle�tirebiliyoruz.

 * ---Razor �le Tek Sat�rl�k ��lemler---
 * Say�sal ��lemler: <h3>@(33 % 5 == 3 ? "Evet" : "Hay�r" ) </h3>
 
 * ---Ternary Operat�r�---
 * <h3>@(33 % 5 == 3 ? "Evet" : "Hay�r" ) </h3>. Ternary operat�r� �� i�lem alan tek operat�rd�r. Bir bak�ma if 
   else yap�s�na da �ok benzerlik g�stermektedir.

 *---Ko�ul Yap�lar�---
 *if veya benzeri ko�ullu yap�lanmalar�,d�ng� yapabilmek i�in Razor scope bloklar�n� kullanmam�za gerek yok Razor bunu alg�lar.