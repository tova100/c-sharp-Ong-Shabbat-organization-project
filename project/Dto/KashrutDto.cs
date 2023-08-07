using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class KashrutDto
    {public int KashroutId { get; set; }
        //private int kashroutId;

        //public int KashroutId
        //{
        //    get { return kashroutId; }
        //    set
        //    {
        //        if (ValidationUtilites.IsNumber(value))
        //            kashroutId = value;
        //        else
        //            throw new Exception("הכנס מספר ");
        //    }
        //}
        //public string Name { get; set; }------------------------------
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (ValidationUtilites.IsHebrew(value))
                    name = value;
                else
                    throw new Exception("שגיאה בכתב ");
            }
        }
    }
}
