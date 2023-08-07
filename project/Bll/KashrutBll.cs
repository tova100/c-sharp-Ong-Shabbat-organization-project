using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class KashrutBll
    {
        //מבצע המרה מהדאל לדטאו ומציג את הכל הנתונים מה דאטבייס
        public static List<KashrutDto> GetAll()
        {
            var kashrut = KashrutDal.GetAll();
            {

                return Converter<Kashrout, KashrutDto>.ManyToDTO(kashrut);

            }
        }

        //הוספה
        public static void Addc(KashrutDto kashrut)
        {
            KashrutDal.AddKashrout(Converter<Kashrout, KashrutDto>.OneToDAL(kashrut));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה

        }

        public static KashrutDto searhcByIdKashrout(int? kashroutId)
        {
            Kashrout c = KashrutDal.searhcByIdKashrout(kashroutId);
            return Converter<Kashrout,KashrutDto>.OneToDTO(c);
             }
        //}
        ///חיפוש פונ עזרה בשביל להציג את שם העיר בטבלה בצורה מילולית
        //    public static CityDto searhcById(int? id)
        //{
        //    City c = CityDal.SearchCity(id);
        //    return Converter<City, CityDto>.OneToDTO(c);
        //}


    


    //עידכון 
    public static void Updatec(KashrutDto kashrut)
        {
            KashrutDal.UpdateKashrout(Converter<Kashrout, KashrutDto>.OneToDAL(kashrut));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
        }

       
    }

}