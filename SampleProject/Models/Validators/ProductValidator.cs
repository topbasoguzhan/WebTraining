using FluentValidation;

namespace SampleProject.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email boş bırakılamaz!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen doğru bir Email giriniz!");

            RuleFor(x => x.ProductName).NotNull().WithMessage("Lütfen ProductName'i boş geçmeyiniz!").NotEmpty().WithMessage("Tamamdır!");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Lütfen ProductName'i 100 karakterden fazla girmeyiniz!");
        }
    }
}
