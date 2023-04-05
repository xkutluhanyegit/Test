using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IPersonelShiftService
    {
        IResult Add(Personelshift personelShift);
        
    }
}