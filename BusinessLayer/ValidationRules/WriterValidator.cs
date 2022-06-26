using EntityLayer.Concreate;
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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Alanı Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Parolanızda en az 1 adet büyük harf olmalıdır");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Parolanızda en az 1 adet küçük harf olmalıdır");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Parolanızda en az 1 adet rakam olmalıdır");
        }
    }
}
