using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class PersonelDepartmanDetailDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DepartmanName { get; set; }
        public string ServiceName { get; set; }
        public string StationName { get; set; }
        public string ShiftName { get; set; }

        public string RegisterNo { get; set; }
        public bool Check { get; set; }
        public int? Week { get; set; }
    }
}