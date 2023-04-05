using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.DepartmanCode;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class Departman:ViewComponent
    {
        IPersonelService _personelService;
        public Departman(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        public IViewComponentResult Invoke(){

            // ViewBag.battery_installation = _personelService.GetAllByDepartmanID(DepartmanCode.battery_installation).Data.Count();
            // ViewBag.injection = _personelService.GetAllByDepartmanID(DepartmanCode.injection).Data.Count();
            // ViewBag.molding_room = _personelService.GetAllByDepartmanID(DepartmanCode.molding_room).Data.Count();
            // ViewBag.toy_assembly = _personelService.GetAllByDepartmanID(DepartmanCode.toy_assembly).Data.Count();
            // ViewBag.puffing = _personelService.GetAllByDepartmanID(DepartmanCode.puffing).Data.Count();
            // ViewBag.warehouse = _personelService.GetAllByDepartmanID(DepartmanCode.warehouse).Data.Count();
            // ViewBag.furniture = _personelService.GetAllByDepartmanID(DepartmanCode.furniture).Data.Count();
            // ViewBag.maintenance = _personelService.GetAllByDepartmanID(DepartmanCode.maintenance).Data.Count();
            // ViewBag.accept = _personelService.GetAllByDepartmanID(DepartmanCode.accept).Data.Count();
            // ViewBag.press_shop = _personelService.GetAllByDepartmanID(DepartmanCode.press_shop).Data.Count();
            // ViewBag.rotation = _personelService.GetAllByDepartmanID(DepartmanCode.rotation).Data.Count();
            // ViewBag.planning = _personelService.GetAllByDepartmanID(DepartmanCode.planning).Data.Count();
            // ViewBag.security = _personelService.GetAllByDepartmanID(DepartmanCode.security).Data.Count();
            // ViewBag.semi_product = _personelService.GetAllByDepartmanID(DepartmanCode.semi_product).Data.Count();
            // ViewBag.quality = _personelService.GetAllByDepartmanID(DepartmanCode.quality).Data.Count();
            // ViewBag.dining_hall = _personelService.GetAllByDepartmanID(DepartmanCode.dining_hall).Data.Count();
            
            return View();
        }
    }
}