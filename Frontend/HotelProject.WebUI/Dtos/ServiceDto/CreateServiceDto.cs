using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {

        public string Description { get; set; }

        [System.ComponentModel.DataAnnotations.Required(ErrorMessage="Hizmet İkon Linkini Giriniz ..!")]
        public string ServiceIcon { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet Başlığı Giriniz ..!")]
        [StringLength(100,ErrorMessage="Hizmet Başlığı En Fazla 100 Karakter Olabilir..!")]
        public string Title { get; set; }


    }
}
