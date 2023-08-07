using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class DriversDto
    {
        //DAL-הנתונים 
        // public string DriverId { get; set; }
        //  קוד תעודת תהות תקין ----------------------------------
        private string driverId;

        public string DriverId
        {
            get { return driverId; }
            set
            {
                if (ValidationUtilites.LegalId(Convert.ToString(value)))
                    driverId = value;
                else
                    throw new Exception("תעודת זהות שגויה ");
            }
        }
        // public string Firstname { get; set; }
        //שם בעברית  
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    firstname = value;
                else
                    throw new Exception("שם לא תקין-אותיות בעברית בלבד!");
            }
        }

        // public string Lastname { get; set; }
        //שם בעברית  
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    lastname = value;
                else
                    throw new Exception("שם לא תקין-אותיות בעברית בלבד!");
            }
        }

        //  public string Phone { get; set; }
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
       // public int? CityId { get; set; }
        
        //מספר תקין 
        private int cityId;
        public int CityId
        {
            get { return cityId; }
            set
            {
                if (ValidationUtilites.IsNumber(value.ToString()))
                    cityId = value;
                else
                    throw new Exception("טלפון לא תקין");
            }
        }


    }
}
