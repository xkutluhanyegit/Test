using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class OrderDetailDto:IDto
    {
        public int orderId { get; set; }
        public string orderNo { get; set; }
        public string secondQuality { get; set; }
    }
}