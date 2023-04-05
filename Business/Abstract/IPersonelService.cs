using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        //İş Çıkış null
        IDataResult<List<Personel1>> GetAll();

        IDataResult<List<Personel1>> GetAllByDepartmanID(string departmanID);
        IDataResult<List<PersonelDetailDTO>> GetAllPersonelDetailDTO();

        IDataResult<List<PersonelDepartmanDetailDTO>> PersonelDepartmanDetailDTO(string departmanID);

        
    }
}