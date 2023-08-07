using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public static class CookereDal
    {
        //get all
        public static List<Cookere> GetAll()
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {

                return db.Cookeres.ToList();
            }

        }
        public static void AddCookere(Cookere c)
            {
                //הוספה מתנדב חדשה 
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    db.Cookeres.Add(c);
                    db.SaveChanges();
                }
            }

        public static Cookere searhcByIdKashrout(string cookerId)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Cookere c = db.Cookeres.Find(cookerId);
                return c;
            }
        }

        //מחיקת מתנדב 
        public static void DeleteCookere(string id)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                 Cookere   c1 = db.Cookeres.Find(id);
                    db.Cookeres.Remove(c1);
                    db.SaveChanges();
                }

            }
            //עידכון מתנדב  
            public static void UpdateCookere(Cookere c)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                Cookere c1 = db.Cookeres.Find(c.CookerId);
                c1.Apartment_number = c.Apartment_number;
                 //c1.City = c.City;
                c1.CityId = c.CityId;
                c1.CookerId = c.CookerId;
                //c1.Driver = c.Driver;
                c1.driverId = c.driverId;
                c1.Firstname = c.Firstname;
                c1.FullName = c.FullName;
                c1.Street = c.Street;
                c1.Phone = c.Phone;
                c1.Lastname = c.Lastname;
                c1.KindOfFood = c.KindOfFood;
                c1.KashroutId = c.KashroutId;
                //c1.Kashrout = c.Kashrout;
                //c1.Families = c.Families;
                db.SaveChanges();

            }

            }
            //חיפוש 
            public static Cookere SearchDriver(int id)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    Cookere f = db.Cookeres.Find(id);
                            return f;
                }

            }

        public static List<Cookere> GetByKashrout(int kd)
        {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    return db.Cookeres.Where(cook => Convert.ToInt32( cook.CookerId) == kd).ToList();
                }
            
        }
    }
}
