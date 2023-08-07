using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class CookereDto
    {
        //DAL-הנתונים 
      // public string CookerId { get; set; }
      //  קוד תעודת תהות תקין
        private string cookerId;

        public string CookerId
        {
            get { return cookerId; }
            set
            {
                if (ValidationUtilites.LegalId(Convert.ToString(value)))
                    cookerId = value;
                else
                    throw new Exception("תעודת זהות שגויה ");
            }
        }
    
      
        //public string Firstname { get; set; }------------------------------
        //כתיבה בעברית 

        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    firstname = value;
                else
                    throw new Exception("שגיאה בכתב ");
            }
        }
        //public string Lastname { get; set; }-------------------------------------
        //כתיבה בעברית 
        private string lastname;

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    lastname = value;
                else
                    throw new Exception("שגיאה בכתב ");
            }
        }
    //   public string Phone { get; set; }
        //בדיקת פון תקין 
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
        //כתיבה בעברית

        //public string FullName { get; set; }------------------------------
        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    fullName = value;
                else
                    throw new Exception("שגיאה בכתב ");
            }
        }
        
        //אין צורך בקובובוקס
        public int KashroutId { get; set; }
        //אין צורך בקובובוקס
        public int? CityId { get; set; }
       // public string Street { get; set; }
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

        //  public int Apartment_number { get; set; }
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
       // public string KindOfFood { get; set; }
        private string kindOfFood;
        public string KindOfFood
        {
            get { return kindOfFood; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    kindOfFood = value;
                else
                    throw new Exception("שם לא תקין-אותיות בעברית בלבד!");
            }
        }

        public string driverId { get; set; }
    }
}

