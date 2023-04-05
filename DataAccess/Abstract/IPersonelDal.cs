using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Abstract
{
    public interface IPersonelDal : IEntityRepository<Personel1>
    {
        List<PersonelDetailDTO> GetAllPersonelDetailDTO();
        List<PersonelDepartmanDetailDTO> PersonelDepartmanDetailDTO(string departmanID);
        List<PersonelDepartmanDetailDTO> PersonelDepartmanDetailDTOWithWeek(string departmanID);

    }
}