using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class KashrutDal
    {
       
            //get all
            public static List<Kashrout> GetAll()
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    return db.Kashrouts.ToList();
                }

            }


            public static void AddKashrout(Kashrout K)
            {
                //הוספה כשרות  חדשה 
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    db.Kashrouts.Add(K);
                    db.SaveChanges();
                }
            }
            //מחיקת משפחה 
            public static void DeleteKashrout(Kashrout K)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    Kashrout K1 = db.Kashrouts.Find(K);
                    db.Kashrouts.Remove(K1);
                    db.SaveChanges();
                }

            }

        public static Kashrout searhcByIdKashrout(int? kashroutId)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Kashrout c = db.Kashrouts.Find(kashroutId);
                return c;
            }
        }
      
    

    //עידכון משפחה 
    public static void UpdateKashrout(Kashrout K)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    Kashrout K1 = db.Kashrouts.Find(K);
                K1.KashroutId = K.KashroutId;
                K1.Name = K.Name;
         
                }
            }
            //חיפוש 
            public static Kashrout Search(int id)
            {
                using (OnegShabatEntities db = new OnegShabatEntities())
                {
                    Kashrout K = db.Kashrouts.Find(id);
                    return K;
                }

            }


        }

    }


