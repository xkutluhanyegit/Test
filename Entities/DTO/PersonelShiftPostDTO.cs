using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class PersonelShiftDetailDTO
    {
        public bool check { get; set; }
        public string Sicilno { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Service { get; set; }
        public int Week { get; set; }
        public string depID { get; set; }
    }
}