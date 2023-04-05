using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.DTO;

namespace Web.Models
{
    public class PersonelViewModel
    {
        public List<PersonelDepartmanDetailDTO> personelDepartmanDetailDTO { get; set; }
        public List<PersonelDepartmanDetailDTO> personelDepartmanNoShiftDTO { get; set; }

    }
}