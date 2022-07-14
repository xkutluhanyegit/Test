using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int id { get; set; }
        public string orderName { get; set; }
        public int customerID { get; set; }
        public int categoryID { get; set; }

    }
}