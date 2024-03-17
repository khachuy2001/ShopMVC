using System.Text;

namespace ShopMVC.Helper
{
	public class MyUtil
	{
		public static string UpLoaiHinh(IFormFile Hinh, string folder)
		{
			try
			{
				var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Hinh", folder, Hinh.FileName);
				using (var myfile = new FileStream(fullPath, FileMode.Create))
				{
					Hinh.CopyTo(myfile);
				}

				return Hinh.FileName;
			}
			catch (Exception ex)
			{
				return string.Empty;
			}
			
		}

		public static string GenerateRandomKey(int length = 5)
		{
			var pattern = @"qazwsxedcrfvtgbyhnujmiklopQAZWSXEDCRFVTGBYHNUJMIKLOP!";
			var sb = new StringBuilder();
			var rd = new Random();
			for (int i = 0; i < length; i++)
			{
				sb.Append(pattern[rd.Next(0, pattern.Length)]);
			}
			return sb.ToString();
		}
	}
}
