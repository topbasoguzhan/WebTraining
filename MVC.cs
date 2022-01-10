/* ---MVC(ModelViewController) Nedir?----
 * MVC,birbirinden ba��ms�z �� katman� esas alan bir Mimarisel Desen(Architectural Pattern)'dir.
 * �z�nde Observer,Decorator gibi design pattern'lar� kullanan bir mimarisel desendir.
 * Microsoft bu desen �zerine oturtulmu� Asp.NET Core MVC mimarisini geli�tirmi�tir.
 * Model:��lenecek olan veriyi temsil eden katmand�r. Genellikle veritaban� i�lemlerinin yap�ld��� katmand�r. �rnek: Entity Framework Core, Entity Models, Ado.NET, Repository, Veritaban� i�lemleri.
 * View:�stek neticesinde elde edilen verileri g�rselle�tirecek, g�rsel ��kt�s�n� verecek katmand�r. �rnek: HTML,CSS,JavaScript, Resim,M�zik,Video
 * Controller: Gelen request'leri kar��layacak olan ve request'in i�eri�ine g�re gerekli model i�lemlerini �stlenecek olan katmand�r. Algoritmalar�, servisleri, veritaban�n�'� vs. �a��rarak/�al��t�rarak/sorgulayarak istenilen veriyi �retmekten ve ihtiya� dahilinde �retilen bu veriyi View ile g�rselle�tirmekten sorumludur. �stek neticesinde elde edilen ve i�lenen veriyi client'a  response olarak d�nd�r�r.