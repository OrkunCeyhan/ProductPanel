using Microsoft.AspNetCore.Identity;

namespace Demo_ProductV2.Models
{
    public class CustomerIdentitiyValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description="Parole En Az 6 Karakter Olmalı"

            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 büyük harf içermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola en az 1 Küçük harf içermelidir"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = " PasswordRequiresNonAlphanumeric",
                Description = "Parola en az 1 alfanumerik karakter içermelidir"
            };
        }
    }
}
