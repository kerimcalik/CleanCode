using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TemizKod;

namespace CleanCode
{
    public class CustomerValidate: AbstractValidator<Customer>
    {
        public CustomerValidate()
        {
            RuleFor(customer => customer.FirstName).NotEmpty().WithMessage("ad boş bırakılamaz");
            RuleFor(c => c.Surname).NotEmpty().WithMessage("soyad boş bırakılamaz");
            RuleFor(c => c.IdentityNumber).NotEmpty().WithMessage("tc boş bırakılamaz");
        }

        /*
        public static void Validate(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.FirstName.Trim()) ||
                string.IsNullOrEmpty(customer.Surname.Trim()))
            {
                //Console.WriteLine("Hata oluştu.");
                //throw new Exception("Validasyon hatası.");
                throw new Exception("Ad, soyad boş bırakılamaz");
            }
        }*/
    }
}
