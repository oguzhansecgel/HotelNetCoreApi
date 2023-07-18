using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet İkon Linkini Giriniz ..!")]
        public string ServiceIcon { get; set; }


        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet Başlığı Giriniz ..!")]
        [StringLength(100, ErrorMessage = "Hizmet Başlığı En Fazla 100 Karakter Olabilir..!")]
        public string Title { get; set; }

       // [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hizmet Açıklaması Giriniz ..!")]
        [StringLength(500, ErrorMessage = "Hizmet Başlığı En Fazla 500 Karakter Olabilir..!")]
        public string Description { get; set; }
    }
}
