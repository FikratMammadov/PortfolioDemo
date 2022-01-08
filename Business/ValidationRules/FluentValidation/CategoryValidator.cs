using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Kategori adi bos gecilemez.");
            RuleFor(c => c.Name).MinimumLength(3).WithMessage("Kategori adi 3 karakterden az olamaz.");
            RuleFor(c => c.Name).MaximumLength(20).WithMessage("Kategori adi 20 karakterden fazla olamaz.");
            RuleFor(c => c.Description).NotEmpty().WithMessage("Aciklama bos gecilemez.");
        }
    }
}
