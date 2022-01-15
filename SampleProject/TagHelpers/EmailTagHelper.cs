using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SampleProject.TagHelpers
{
    public class EmailTagHelper : TagHelper //Bir sınıfın TagHelper olabilmesi için TagHelper sınıfından türemesi gerekmektedir.
    {
        //[HtmlTargetElement()] bununla TagHelper'imizi farklı bir şekilde isimlendirebiliriz.
        public string Mail { get; set; }
        public string Display { get; set; }
        public override void Process(TagHelperContext/*ilgili taghelper'ı getirmektedir(attributes,uniqueId)*/ context, TagHelperOutput/*İlgili attribute'un cıktısını bizlere vermektedir*/ output) 
            //TagHelper'inn işlevsellik gösterebilmesi için/operasyonunu gerçekleştirebilmesi için Process metodunun override edilmesi gerekmektedir.
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Display);
            //base.Process(context, output);
        }
    }
}
