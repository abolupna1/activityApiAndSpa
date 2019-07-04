
using System.ComponentModel.DataAnnotations;

namespace ActivityApi.Dtos
{
    public class UserForRegisterDto
    {
          [Required(ErrorMessage="اسم المستخدم مطلوب")]
        public string Username { get; set; }

        [Required(ErrorMessage="كلمة المرور مطلوبة")]
        [StringLength(10,MinimumLength=6,ErrorMessage="يجب ان تكون كلمة المرور اقل من 10 واكبرمن 6")]
        public string Password { get; set; }
     
    }
}