using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant.Messages;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Concrete
{
    public class PersonelShiftManager : IPersonelShiftService
    {
        IPersonelShiftDal _personelShiftDal;
        public PersonelShiftManager(IPersonelShiftDal personelShiftDal)
        {
            _personelShiftDal = personelShiftDal;
        }
        public IResult Add(Personelshift personelShift)
        {
            personelShift.Createday = DateTime.Now.ToShortDateString();
            //Cuma günü hafta değeri artar


            var ShiftEnd = DateTime.Now;
            var ShiftStart = DateTime.Now;

            while (true)
            {
                if (ShiftStart.DayOfWeek == DayOfWeek.Monday)
                {
                    personelShift.Startday = ShiftStart.ToShortDateString();
                    personelShift.WeekOfYear = Convert.ToDateTime(personelShift.Startday).DayOfYear / 7;
                    if (personelShift.Shiftid == 1 | personelShift.Shiftid == 2 | personelShift.Shiftid == 3)
                    {
                        personelShift.Endday = ShiftStart.AddDays(6).ToShortDateString();
                        break;
                    }
                    else if (personelShift.Shiftid == 4)
                    {
                        personelShift.Endday = ShiftStart.AddDays(5).ToShortDateString();
                        break;
                    }

                }

                ShiftStart = ShiftStart.AddDays(1);


                // if (personelShift.Shiftid == 1 | personelShift.Shiftid == 2 | personelShift.Shiftid == 3)
                // {
                //     if (ShiftEnd.DayOfWeek == DayOfWeek.Saturday)
                //     {
                //         personelShift.Endday = ShiftEnd.ToShortDateString();
                //         break;
                //     }
                // }
                // else if (personelShift.Shiftid == 4)
                // {
                //     if (ShiftEnd.DayOfWeek == DayOfWeek.Friday)
                //     {
                //         personelShift.Endday = ShiftEnd.ToShortDateString();
                //         break;
                //     }
                // }

                // ShiftEnd = ShiftEnd.AddDays(1);
            }


            _personelShiftDal.Add(personelShift);
            return new SuccessResult(Messages.AddSuccess);
        }




    }
}