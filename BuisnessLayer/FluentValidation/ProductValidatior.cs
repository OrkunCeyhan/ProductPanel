using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.FluentValidation
{
    public class ProductValidatior : AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("BOŞ GEÇME");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("ÜRÜN ADI EN AZ 3 KARAKTER OLMADI");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("STOK BOŞ GEÇİLEMEZ");
            RuleFor(x => x.Price).NotEmpty().WithMessage("FİYAT BOŞ GEÇİLEMEZ");

        }
    }
}
