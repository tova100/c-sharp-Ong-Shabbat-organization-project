using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class FamilyDto
    {
        //DAL-הנתונים 
        public int Familyid { get; set; }//אוטומטי
        //public string FamilyName { get; set; }
        //בדיקה עברית 
        private string familyName;
        public string FamilyName
        {
            get { return familyName; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    familyName = value;
                else
                    throw new Exception("שם לא תקין-אותיות בעברית בלבד!");
            }
        }

        // public string Phone { get; set; }
        //בדיקת מס פלאפון תקין 
        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                if (ValidationUtilites.IsPhoneNum(value))
                    phone = value;
                else
                    throw new Exception("טלפון לא תקין");
            }
        }
    

        public int? CityId { get; set; }
       // public string Street { get; set; }

        /// האם מילה באנגלית או מספר - למשל עבור כתובת <summary>
      //  בדיקה עברית
        private string street;
        public string Street
        {
            get { return street; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    street = value;
                else
                    throw new Exception("שם לא תקין-אותיות בעברית בלבד!");
            }
        }


        //בדיקת רחוב תקין שרשום בעברית 



        //public string Apartment_number { get; set;}

        //בדיקת מס דירה תקין
        private string apartment_number;

        public string Apartment_number
        {
            get { return apartment_number; }
            set
            {
                if (ValidationUtilites.IsNumber(value))
                    apartment_number = value;
                else
                    throw new Exception("הכנס מספר ");
            }
        }
        //combobox
        public int KashroutId { get; set; }



      //  public int? NumberOfPeople { get; set; }

        private int? numberOfPeople;

        public int? NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                if (value > 0)
                    numberOfPeople = value;
                else
                    throw new Exception("הכנס מספר ");
            }
        }
        //   //combobox
        public string CookerId { get; set; }

    }
}
