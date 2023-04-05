using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.DepartmanCode;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.ViewComponents
{
    public class Battery_Installation : ViewComponent
    {
        IPersonelService _personelService;
        public Battery_Installation(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        public IViewComponentResult Invoke()
        {
            PersonelViewModel pvm = new PersonelViewModel();
            pvm.personelDepartmanDetailDTO = _personelService.PersonelDepartmanDetailDTO(DepartmanCode.battery_installation).Data;
            pvm.personelDepartmanNoShiftDTO = _personelService.PersonelDepartmanNoShiftDTO(DepartmanCode.battery_installation).Data;

            var result = _personelService.PersonelDepartmanDetailDTO(DepartmanCode.battery_installation);
            if (result.Success)
            {
                return View(pvm);
            }
            return View();
        }
    }
}