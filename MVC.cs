/* ---MVC(ModelViewController) Nedir?----
 * MVC,birbirinden baðýmsýz üç katmaný esas alan bir Mimarisel Desen(Architectural Pattern)'dir.
 * Özünde Observer,Decorator gibi design pattern'larý kullanan bir mimarisel desendir.
 * Microsoft bu desen üzerine oturtulmuþ Asp.NET Core MVC mimarisini geliþtirmiþtir.
 * Model:Ýþlenecek olan veriyi temsil eden katmandýr. Genellikle veritabaný iþlemlerinin yapýldýðý katmandýr. Örnek: Entity Framework Core, Entity Models, Ado.NET, Repository, Veritabaný iþlemleri.
 * View:Ýstek neticesinde elde edilen verileri görselleþtirecek, görsel çýktýsýný verecek katmandýr. Örnek: HTML,CSS,JavaScript, Resim,Müzik,Video
 * Controller: Gelen request'leri karþýlayacak olan ve request'in içeriðine göre gerekli model iþlemlerini üstlenecek olan katmandýr. Algoritmalarý, servisleri, veritabanýný'ý vs. çaðýrarak/çalýþtýrarak/sorgulayarak istenilen veriyi üretmekten ve ihtiyaç dahilinde üretilen bu veriyi View ile görselleþtirmekten sorumludur. Ýstek neticesinde elde edilen ve iþlenen veriyi client'a  response olarak döndürür.