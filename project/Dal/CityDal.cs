using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class CityDal
    {

        //get all
        public static List<City> GetAll()
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {

                return db.Cities.ToList();
            }

        }
        public static void AddCity(City c)
        {
            //הוספה עיר חדשה 
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                db.Cities.Add(c);
                db.SaveChanges();
            }
        }
        //מחיקת עיר 
        public static void DeleteCity(City c)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                City c1 = db.Cities.Find(c);
                db.Cities.Remove(c1);
                db.SaveChanges();
            }

        }
        //עידכון עיר  
        public static void UpdateCity(City c)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                City c1 = db.Cities.Find(c);
                c1.CitiesId = c.CitiesId;
                c1.Name = c.Name;
            }
        }
            //חיפוש 
            public static City SearchCity(int? CityId)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    City c = db.Cities.Find(CityId);
                    return c;
                }

            }
        }
    }


