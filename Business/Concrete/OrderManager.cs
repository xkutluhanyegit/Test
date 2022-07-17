using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal)
        {
            _orderDal=orderDal;
        }
        public IResult Add(Order order)
        {
            
            _orderDal.Add(order);
            return new Result(true,"Order başarıyla eklendi");
            
        }

        
    }
}