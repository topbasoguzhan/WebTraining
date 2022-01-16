using System;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Lütfen product name'i giriniz!")]//Validation işlemi için doğrulamaları burada belirtmemiz gerekmektedir. Bunu yapmamızı sağlayan attribute'lara annotation denilmektedir.
        [StringLength(100,ErrorMessage = "Lütfen product name'i en fazla 100 karakter giriniz.")]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen doğru bir e-mail adresi giriniz.")]
        public string Email { get; set; }

    }
}
