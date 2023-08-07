using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dto;

namespace Bll
{
   
        public class CityBll
        {

            //מבצע המרה מהדאל לדטאו ומציג את הכל הנתונים מה דאטבייס
            public static List<CityDto> GetAll()
            {
                var city = CityDal.GetAll();
                {

                    return Converter<City, CityDto>.ManyToDTO(city);

                }
            }

            //הוספה
            public static void Addc(CityDto city)
            {
                CityDal.AddCity(Converter<City, CityDto>.OneToDAL(city));
                //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה

            }
            //עידכון 
            public static void Updatec(CityDto city)
            {
                CityDal.UpdateCity(Converter<City, CityDto>.OneToDAL(city));
                //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
            }
        //חיפוש פונ עזרה בשביל להציג את שם העיר בטבלה בצורה מילולית
            public static CityDto searhcById(int? id)
            {
                City c = CityDal.SearchCity(id);
                return Converter<City, CityDto>.OneToDTO(c);
            }


        }
}


