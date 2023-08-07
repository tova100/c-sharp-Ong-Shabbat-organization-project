using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;

namespace Dal
{
    //[System.Serializable]

    public static class DriversDal
    {
        //get all
        public static List<Driver> GetAll()
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {

                return db.Drivers.ToList();
            }

        }
        public static void AddDriver(Driver d)
        {
            //הוספה מתנדב חדשה 
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                db.Drivers.Add(d);
                db.SaveChanges();
                
            }
            
           
        }
        //מחיקת מתנדב 
        public static void DeleteDriver(Driver d)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Driver d1 = db.Drivers.Find(d);
                db.Drivers.Remove(d1);
                db.SaveChanges();
            }

        }
        //עידכון מתנדב  
        public static void UpdateDriver(Driver d)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Driver d1 = db.Drivers.Find(d.DriverId);
              //  d1.City = d.City;
                d1.CityId = d.CityId;
              //  d1.Cookeres = d.Cookeres;
                d1.DriverId = d.DriverId;
                d1.Firstname = d.Firstname;
                d1.Lastname = d.Lastname;
                d1.Phone = d.Phone;
                db.SaveChanges();
            }

        }

        public static Driver searhcByIdDriver(string driverId)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Driver c = db.Drivers.Find(driverId);
                return c;
            }
        }

        //חיפוש 
        public static Driver SearchDriver(int DriverId)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Driver f = db.Drivers.Find(DriverId);
                return f;
            }

        }

        public static List<Driver> GetByCity(int cd)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                return db.Drivers.Where(driver => driver.CityId == cd ).ToList();
            }


        }

        public static void Delete(string id)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Driver c = db.Drivers.Find(id);
                db.Drivers.Remove(c);
                db.SaveChanges();
            }
        }

        public static List<Cookere> GetByCityAndKashrout(int cd, int kd)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                return db.Cookeres.Where(cook => cook.CityId == cd&& cook.KashroutId==kd).ToList();
            }
        }
    }

}





