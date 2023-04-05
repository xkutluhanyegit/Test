using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel1, PersonelCIContext>, IPersonelDal
    {
        public List<PersonelDetailDTO> GetAllPersonelDetailDTO()
        {
            using (var context = new PersonelCIContext())
            {
                var result = from personel in context.Personel1s
                                join kimlik in context.Kimlik1s
                                on personel.Sicilno equals kimlik.Prsicil into t1
                                from personelKimlik in t1.DefaultIfEmpty()

                                join departman in context.Departmen
                                on personel.Depart equals departman.Kodu into t2
                                from personelDepartman in t2.DefaultIfEmpty()

                                join servis in context.Servis
                                on personel.Servis equals servis.Kodu into t3
                                from personelService in t3.DefaultIfEmpty()

                                join durak in context.Duraks
                                on personel.Durak equals durak.DurakKodu into t4
                                from personelDurak in t4.DefaultIfEmpty()

                                //Table Shift Add
                                where personel.Iscikt == null

                                select new PersonelDetailDTO{
                                    Name = personel.Adi,
                                    Surname = personel.Soyadi,
                                    TCKN = personelKimlik.Tckmno,
                                    DepartmanName = personelDepartman.Adi,
                                    ServiceName = personelService.Turu,
                                    StationName = personelDurak.DurakAdi,
                                    RegisterNo = personel.Sicilno

                                };
                return result.ToList(); 
            }
        }

        

        public List<PersonelDepartmanDetailDTO> PersonelDepartmanDetailDTO(string departmanID)
        {
            using (var context = new PersonelCIContext())
            {
                var result = from personel in context.Personel1s
                            join departman in context.Departmen
                            on personel.Depart equals departman.Kodu into t1
                            from personelDepartman in t1.DefaultIfEmpty()

                            join servis in context.Servis
                            on personel.Servis equals servis.Kodu into t2
                            from personelServis in t2.DefaultIfEmpty()

                            join durak in context.Duraks
                            on personel.Durak equals durak.DurakKodu into t3
                            from personelDurak in t3.DefaultIfEmpty()


                            //Shift Name

                            where personel.Iscikt == null & personelDepartman.Kodu == departmanID

                            select new PersonelDepartmanDetailDTO{
                                Name = personel.Adi,
                                Surname = personel.Soyadi,
                                DepartmanName = personelDepartman.Adi,
                                ServiceName = personelServis.Turu,
                                StationName = personelDurak.DurakAdi,
                                RegisterNo = personel.Sicilno

                            };
                            
                return result.ToList();
            }
            throw new NotImplementedException();
        }
    
        
            
            
        
    }
}