using EntitiyLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.FluentValidation
{
    public class CustomerValidatior : AbstractValidator<Customer>
    {
        public CustomerValidatior()
        {
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Bilgisi boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("İSİM BOŞ GEÇİLEMEZ");
        }
    }
}
