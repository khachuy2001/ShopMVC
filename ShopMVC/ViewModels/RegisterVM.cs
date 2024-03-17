using System.ComponentModel.DataAnnotations;

namespace ShopMVC.ViewModels
{
	public class RegisterVM
	{
		[Display(Name="Tên đăng nhập")]
		[Required(ErrorMessage ="*")]
		[MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
		public string MaKh { get; set; }

		[Display(Name ="Mật khẩu")]
		[Required(ErrorMessage = "*")]
		[DataType(DataType.Password)]	
		public string? MatKhau { get; set; }

		[Display(Name = "Họ Tên")]
		[Required(ErrorMessage = "*")]
		[MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
		public string HoTen { get; set; } 

		public bool GioiTinh { get; set; }

        [Display(Name = "Ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime? NgaySinh { get; set; }

		[Display(Name = "Đỉa Chỉ")]
		[MaxLength(60, ErrorMessage = "Tối đa 60 kí tự")]
		public string DiaChi { get; set; }

		[Display(Name = "Điện Thoại")]
		[MaxLength(24, ErrorMessage = "Tối đa 24 kí tự")]
		[RegularExpression(@"0[98753]\d{8}",ErrorMessage ="Đây không phải là số điện thoại")]
		public string DienThoai { get; set; }

		[EmailAddress(ErrorMessage = "Chưa đúng định dạng Email")]
		public string Email { get; set; }

		public string? Hinh { get; set; }
	}
}
