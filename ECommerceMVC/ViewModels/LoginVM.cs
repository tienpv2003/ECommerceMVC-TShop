using System.ComponentModel.DataAnnotations;

namespace ECommerceMVC.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = ("Chưa nhập tên đăng nhập"))]
        [MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        public string UserName { get; set; }
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = ("Chưa nhập mật khẩu"))]
        public string Password { get; set; }
    }
}
