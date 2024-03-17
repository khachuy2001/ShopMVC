using AutoMapper;
using ShopMVC.Data;
using ShopMVC.ViewModels;

namespace ShopMVC.Helper
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile() 
		{
			CreateMap<RegisterVM, KhachHang>();
		}

	}
}
