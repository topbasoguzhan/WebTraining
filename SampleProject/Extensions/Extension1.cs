using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SampleProject.Extensions
{
    static public class Extension1
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value, string placeHolder) =>
            htmlHelper.TextBox(name, value, new
            {
                style = "background-color:green;color:white;font-size:11px",
                @class = "form-input", //class özel bir keyword olduğu için isim olarak kullanabilmek için başına @ koyduk.
                a = "a",
                b = "b",
                placeHolder = placeHolder
            });
    }
}
