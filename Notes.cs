using System;

public class Notes
{
	public Notes()
	{
		{
			/*Asp.NET Nedir?:Microsoft tarafından geliştirilmiş bir Web Uygulama Geliştirme mimarısıdır.
			 * Asp.NET Core Nedir? Microsoft tarafından geliştirilen ücretsiz ve açık kaynak(open source) Web Geliştirme Mimarisidir. Open source olmasından dolayı gelişimine biz de katkı sağlayabiliyor ve dosyalarına erişim sağlayabiliyoruz. Asp.NET'in halefidir.
			 * Asp.NET Core'un Asp.NET'e göre farkları;
			 * Daha performanslıdır
			 * Cross Platformdur,heryerde çalışır.
			 * Modüler altyapıdadır,bütünlükten ziyade modüler yapıdadır.
			 * Bağımlılık Enjeksiyonu(Dependency Injection)
			 * Asenkron işlemler,Kolay bakım,Razor pages */
		}
		{
			/*-Web Mantığı-
			 * Bir sayfaya girmek ya da tıklamak bizim dilimizde yoktur.Biz bir siteye request atarız ve response alırız.
			 * -Temel Kavramlar-
			 * User: Web'e girmek isteyen kişidir
			 * Client: User'ın internete girmek için kullandığı uygulamadır. Örneğin bilgisayarımızdaki web browser. İstek atabilen her cihaza, akıllı bir pile veya kumandaya bile client denilebilir.
			 * Hosting: Siteyi 7/24 ulaşılabilir kılan yayıncıdır. Hosting firmaları web sitelerini 7/24 ulaşılabilir kılan, bakımını yapan ve sıkıntılara karşı önlemini alan sistemlere sahip firmalardır.
			 * Request: Client üzerinden User'ın yaptığı istektir. Request'in içinde nereye gideceğinin bilgisi bulunur(IP,server vs.).
			 * Response: Response sunucu tarafından client'a dönülen cevaptır. Bu cevap server tarafında üretilen result'u barındırabilir. Bulundurabilir diyoruz çünkü her zaman bir result bulundurmak zorunda değil.
			 * www ile başlayan domainler ile adlandırmak daha akılda kalıcı olduğu için IP numaralarını kullanmıyoruz isimlendirmede. */
		}
        {
			/*-HTTP protokolü-
			 * Client ile server arasındaki ilişkiyi ve haberleşmeyi sağlayan protokoldür.
			 * HTTP,client iile arasındaki ilişkiyi 9 farklı fonksiyon ile gerçekleştiriyor:
			 * Get,Head,Post,Put,Delete,Trace,Options,Connect,Patch
			 * İş hayatında sık sık kullanılan Get,Post,Put(Patch) ve Delete.
			 * Get: Sunucudan verileri listelemek,elde etmek için kullanılır. Verilere başka etkisi yoktur.
			 * Post: Sunucuya ilk defa bir veri göndermek, eklemek için kullanılır.
			 * Put: Var olan bir veriyi değiştirmek, güncellemek için kullanılır. (Bir verinin bütününü değil kısmi bir alanını güncelliyorsak eğer bu Patch isteğidir.)
			 * Delete: Var olan veriyi silmek için kullanılır. */
        }
        {
			/*-Server-
			 * IIS(Internet Information Services): Asp.NET Core dahil olmak üzere web uygulamarını barnadırmak için esnek, güvenli ve yönetilebilir bir Web sunucusudur.
			 * Kestrel: Asp.NET Core uygulamalarında dahili olarak gelen bir web sunucusudur.
			 * NginX: Ubuntu/Linux sistemlerde Asp.NET Core uygulamarını çalıştırabilmemizi sağlayan bir sunucudur. Reverse Proxy olarak Asp.NET Core uygulamarındaki dahili sunucuyla(Kestrel) işlevsellik gösterir.
			 * Apache: Aynı NginX gibi.
			 * Docker: Yazılım geliştiriciler ve sistem yöneticileri için geliştirilmiş açık kaynak olan bir yeni nesil sanallaştırma platformudur.
			 * HTTP.sys: Yalnızca Windows üzerinde çalışan Asp.NET Core için bir web sunucusudur. Kestrel'in bir alternatifidir. */
        }
        {
			/*-Web Geliştirme Yaklaşımları-
			 * Olay Tabanlı Programlama Yaklaşımı: Programın akışını kullanıcı eylemlerine göre yönlendiren bir programlama yaklaşamıdır. Kullanıcı eylemlerine uygun bir şekilde olaylar tanımlanmıştır. Bu olaylar çalıştırılacak kodu barındırmaktadır. Uygulama hızlı bir şekilde inşa edilebilir fakat bakım ve sonraki gelişim süreci oldukça maliyetli olan bir yaklaşım olduğu için günümüzde pek tercih edilmemektedir.
			 * MVC(Model View Controller): MVC patter'ini kullanan bir yaklaşımdır. Bir framework değildir. Üretilen veri ile gösterim arasında bir soyutlama esas alınmıştır.
			 * API(Application Programming Interface): Web'de çalışabilen ve web uygulamaları,işletim sistemleri,veritabanları, donanımlar yahut yazılı kütüphaneleri ile iletişim kurabilen bir arayüzdür. Direkt olarak Web Uygulaması yaklaşımıdır diyemeyiz. Lakin genellikle web tabanlı uygulamalarda client ve server arasındaki iletişimi sağlayan bir sözleşme olarak kullanılmaktadır. Bu forma Web API ismi verilmektedir.
        }
	}
}
