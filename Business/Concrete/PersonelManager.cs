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
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public IDataResult<List<Personel1>> GetAll()
        {
            var result = _personelDal.GetAll().Where(p=>p.Iscikt == null).ToList();
            return new SuccessDataResult<List<Personel1>>(result,Messages.ListedSuccces);
        }

        public IDataResult<List<Personel1>> GetAllByDepartmanID(string departmanID)
        {
            var result = _personelDal.GetAll().Where(p=>p.Depart == departmanID).Where(p=>p.Iscikt == null).ToList();
            return new SuccessDataResult<List<Personel1>>(result,Messages.ListedSuccces);
        }

        //HR Home Table
        public IDataResult<List<PersonelDetailDTO>> GetAllPersonelDetailDTO()
        {
            var result = _personelDal.GetAllPersonelDetailDTO();
            return new SuccessDataResult<List<PersonelDetailDTO>>(result,Messages.ListedSuccces);
        }

        public IDataResult<List<PersonelDepartmanDetailDTO>> PersonelDepartmanDetailDTO(string departmanID)
        {
            var result = _personelDal.PersonelDepartmanDetailDTO(departmanID);
            return new SuccessDataResult<List<PersonelDepartmanDetailDTO>>(result,Messages.ListedSuccces);
        }

    }
}