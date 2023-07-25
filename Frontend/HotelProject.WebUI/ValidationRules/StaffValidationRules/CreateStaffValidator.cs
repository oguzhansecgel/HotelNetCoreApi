using FluentValidation;
using HotelProject.WebUI.Models.Staff;

namespace HotelProject.WebUI.ValidationRules.StaffValidationRules
{
    public class CreateStaffValidator : AbstractValidator<StaffViewModel>
    {
        public CreateStaffValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Çalışan Adı Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("En Az İki Karakter Veri Girişi Yapınız.");

            RuleFor(x => x.Title).NotEmpty().WithMessage("Çalışan Başlığı Boş Geçilemez");
            RuleFor(x => x.Title).MinimumLength(2).WithMessage("En Az İki Karakter Veri Girişi Yapınız.");

        }
    }
}
