using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public static class FamilyBll
    {
        //מבצע המרה מהדאל לדטאו ומציג את הכל הנתונים מה דאטבייס
        public static List<FamilyDto> GetAll()
        {
            var familiesdal = FamilyDal.GetAll();
            {

                return Converter<Family, FamilyDto>.ManyToDTO(familiesdal);

            }
        }

        //List<FamilyDto> lstDTO = new List<FamilyDto>();

        //foreach (Family f in familiesdal)
        //{
        //    lstDTO.Add(new FamilyDto()
        //    {
        //        CityId = f.CityId,
        //        Familyid = f.Familyid,
        //        FamilyName = f.FamilyName,
        //        Phone = f.Phone,
        //        Street = f.Street,
        //        Apartment_number = f.Apartment_number,
        //        KashroutId = f.KashroutId,
        //        NumberOfPeople = f.NumberOfPeople,
        //CookerId = f.CookerId,
        //});
        //}
        //return lstDTO;

        //הוספה
        public static void Add(FamilyDto family)
        {
            FamilyDal.AddFamily(Converter<Family, FamilyDto>.OneToDAL(family));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה

        }
        //עידכון 
        public static void update(FamilyDto family)
        {
            FamilyDal.UpdateFamily(Converter<Family, FamilyDto>.OneToDAL(family));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
        }
        //מחיקה
        public static void Delete(FamilyDto id)
        {
            FamilyDal.DeleteFamily(Converter<Family, FamilyDto>.OneToDAL(id).Familyid);
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
        }

        }
}
 
 

