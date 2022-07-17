using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EF
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, AppDbContext>, IOrderDal
    {
        public List<OrderDetailDto> GetOrderDetailDtos()
        {
            
            using (AppDbContext context = new AppDbContext())
            {
                var res = from o in Order
            }

        }
    }
}