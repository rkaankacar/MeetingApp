using System.ComponentModel.DataAnnotations; //Required i kullanmak için kütüphanesini çağırıyoruz
namespace MeetingApp1.Models
{
    public class UserInfo
    {   
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad-Soyad alanı zorunludur!")] // null değeri kabul etmemeyi sağlıyor 
        public string? Name { get; set; }
        [Required(ErrorMessage ="Email alanı zorunludur!")]
        [EmailAddress(ErrorMessage ="Hatalı Email, @ kullanmayı unutmayın!")]
        public string? Email { get; set; }
        [Required (ErrorMessage ="Telefon alanı zorunludur!")]
        public string? Phone { get; set; }
       
        public bool? WillAttend { get; set; }

    }
}
