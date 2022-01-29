using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models.ModelMetadataTypes
{
    public class ProductMetadata //Bu sınıf ile Product içinde validation yapmamıza gerek kalmadı, buraya taşıdık. Validation gerektiren protertileri taşıyoruz.
    {
        [Required(ErrorMessage = "Lütfen product name'i giriniz!")]
        [StringLength(100, ErrorMessage = "Lütfen product name'i en fazla 100 karakter giriniz.")]
        public string ProductName { get; set; }

        [EmailAddress(ErrorMessage = "Lütfen doğru bir e-mail adresi giriniz.")]
        public string Email { get; set; }
    }
}
