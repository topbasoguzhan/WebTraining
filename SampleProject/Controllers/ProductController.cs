using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controllers
{
    #region [NonController]
    //Böyle yaparsak bütün controller'ı sadece iş mantığında kullanmış olacağız. İşlevselliğini kaybedip normal bir sınıf gibi olacak ve request alamayacaktır.
    #endregion
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region [NonAction] 
        //Aşağıdaki örnek olarak verdiğimiz X metodunu Action olarak kullanmayacaksak sadece bir iş mantığı yürüten operasyonel fonksiyon ise NonAction olduğunu belirtmeliyiz. Böyle işaretlenen metotlar dışarıdan request karşılamazlar. Bunu MVC tabanında yapılan uygulamalarda(Web gibi) çok da iyi değildir. Başka bir sınıftan çağırmak daha iyidir.
        #endregion
        public void X()
        {

        }

    }
}
