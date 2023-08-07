using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
    public static class CookereBll
    {

        public static List<CookereDto> GetAll()
        {
            var cook = CookereDal.GetAll();
            {

                return Converter<Cookere, CookereDto>.ManyToDTO(cook);

            }
        }

        public static CookereDto searhcByIdCooker(string cookerId)
        {
            Cookere c = CookereDal.searhcByIdKashrout(cookerId);
            return Converter<Cookere, CookereDto>.OneToDTO(c);
        }

        //List<CookereDto> lstDTO = new List<CookereDto>();

        //foreach (Cookere c in cook)
        //{
        //    lstDTO.Add(new CookereDto()
        //    {
        //    CookerId= c.CookerId  ,
        //    Firstname= c.Firstname,
        //    Lastname = c.Lastname ,
        //    KashroutId=c.KashroutId,
        //    Phone= c.Phone ,
        //    Apartment_number=c.Apartment_number,
        //    FullName =c.FullName,
        //    Street =c.Street,
        //    CityId =c.CityId,
        //    KindOfFood =c.KindOfFood,
        //    driverId  =c.driverId,

        //    });
        //}
        //return lstDTO;



        //הוספה
        public static void Addc(CookereDto cook)
        {
            CookereDal.AddCookere(Converter<Cookere, CookereDto>.OneToDAL(cook));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה

        }
        //עידכון 
        public static void Updatec(CookereDto cook)
        {
            CookereDal.UpdateCookere(Converter<Cookere, CookereDto>.OneToDAL(cook));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
        }
        //מחיקה
        public static void Delete(CookereDto id)
        {
            CookereDal.DeleteCookere(Converter<Cookere, CookereDto>.OneToDAL(id).CookerId);
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
        }


        public static object GetByCityAndKashrout(int cityid, int kashroutid)
        {
            List<Cookere> cook = DriversDal.GetByCityAndKashrout(cityid, kashroutid);
            //List<Cookere> kashrout = CookereDal.GetByKashrout(kashroutid);
            return Converter<Cookere, CookereDto>.ManyToDTO(cook);
        }
    }
}
