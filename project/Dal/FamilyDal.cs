using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public static class FamilyDal
    {
         
        //get all
        public static List <Family> GetAll()
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                return db.Families.ToList();
            }

       }


        public static void AddFamily(Family F)
        { 
            //הוספה משפחה חדשה 
            using ( OnegShabatEntities db = new OnegShabatEntities())
            {
                  db.Families.Add(F);
                   db.SaveChanges();
                }
        }
        //מחיקת משפחה 
        public static void DeleteFamily(int id)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
               Family F1= db.Families.Find( id);
                db.Families.Remove(F1);
                db.SaveChanges();
            }

        }
        //עידכון משפחה 
        public static void UpdateFamily(Family F) {
         using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Family F1 = db.Families.Find(F.Familyid);
              //  F1.Familyid = F.Familyid;
                F1.FamilyName = F.FamilyName;
                F1.Phone = F.Phone;
                F1. CityId=F.CityId;
                F1.Street = F.Street;
                F1.Apartment_number = F.Apartment_number;
                F1.KashroutId = F.KashroutId;
                F1.NumberOfPeople = F.NumberOfPeople;
                F1.CookerId = F.CookerId;
                F1.Cookere = F.Cookere;
                F1.Kashrout = F.Kashrout;
                db.SaveChanges();
                }
        
    }
        //חיפוש 
        public static Family Search(int id)
        {
            using (OnegShabatEntities db = new OnegShabatEntities())
            {
                Family f = db.Families.Find(id);
                           return f;
            }

        }


        }

    }

