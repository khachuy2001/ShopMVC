using Microsoft.AspNetCore.Mvc;
using ShopMVC.Data;
using ShopMVC.ViewModels;

namespace ShopMVC.ViewComponents
{
    public class MenuLoaiViewComponent : ViewComponent
    {   
        private readonly Hshop2023Context db;

        public MenuLoaiViewComponent(Hshop2023Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(loai => new MenuLoaiVM
            {
                    MaLoai = loai.MaLoai,
                    TenLoai = loai.TenLoai,
                    SoLuong =loai.HangHoas.Count
            });

            return View(data);
        }
    }
}
