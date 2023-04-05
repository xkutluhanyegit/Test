using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Models;

namespace Web.Controllers
{
    [Route("akulu-montaj")]
    public class battery_installationController : Controller
    {
        private readonly IPersonelShiftService _personelShiftService;
        private readonly ILogger<battery_installationController> _logger;
        private readonly IMapper _mapper;

        public battery_installationController(ILogger<battery_installationController> logger, IPersonelShiftService personelShiftService, IMapper mapper)
        {
            _logger = logger;
            _personelShiftService = personelShiftService;
            _mapper = mapper;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("vardiya")]
        public IActionResult shift()
        {
            return View();
        }

        [HttpPost("vardiya")]
        [RequestFormLimits(ValueCountLimit = 1000)]
        public IActionResult shift(PersonelViewModel RegisterNo, int shiftID)
        {
            for (int i = 0; i < RegisterNo.personelDepartmanNoShiftDTO.ToList().Count(); i++)
            {
                Personelshift ps = new Personelshift();
                if (RegisterNo.personelDepartmanNoShiftDTO[i].Check)
                {
                    ps.Sicilno = RegisterNo.personelDepartmanNoShiftDTO[i].RegisterNo;
                    ps.Shiftid = shiftID;
                    _personelShiftService.Add(ps);
                }

            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}