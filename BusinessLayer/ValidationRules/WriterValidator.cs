using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {

        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Kullanıcı Adı ve Soyadı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Kullanıcı Mail  boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Kullanıcı Password  boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En az 50 karakter giriniz");


        }

    }
}
