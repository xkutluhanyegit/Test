using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Web.ViewComponents
{
    public class HumanResource:ViewComponent
    {
        IPersonelService _personelService;
        public HumanResource(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        public IViewComponentResult Invoke(){

            var result = _personelService.GetAllPersonelDetailDTO();
            if (result.Success)
            {
                return View(result.Data);
            }
            return View();
        }
    }
}