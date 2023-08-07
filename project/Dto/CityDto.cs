using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CityDto
    {
        public int CitiesId { get; set; }
        //public string Name { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
            //set
            //{ 
            //    if (ValidationUtilites.IsHebrew(value))
            //        name = value;
            //    else
            //        throw new Exception("שגיאה בכתב ");
            //}
        }
    }
}
