using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}