using System.ComponentModel.DataAnnotations;

namespace ShopMVC.ViewModels
{
	public class LoginVM
	{
		[Display(Name = "Tên đăng nhập")]
		[Required(ErrorMessage = "Vui lòng nhập trường này")]
		[MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
		public string UserName {  get; set; }

		[Display(Name = "Mật khẩu")]
		[Required(ErrorMessage = "Vui lòng nhập trường này")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
