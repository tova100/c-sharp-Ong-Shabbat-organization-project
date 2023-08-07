using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public static class DriversBll
    {
        public static List<DriversDto> GetAll()
        {
            var driver = DriversDal.GetAll();


            return Converter<Driver, DriversDto>.ManyToDTO(driver);


        }


        //var drive = DriversDal.GetAll();
        //List<DriversDto> lstDTO = new List<DriversDto>();

        //foreach (Driver d in drive)
        //{
        //    lstDTO.Add(new DriversDto()
        //    {

        //        DriverId = d.DriverId,
        //        Firstname = d.Firstname,
        //        Lastname = d.Lastname,
        //        Phone = d.Phone,
        //        CityId = d.CityId
        //    });
        //}

        //return lstDTO;



        //הוספה
        public static void Add(DriversDto drivers)
        {
            DriversDal.AddDriver(Converter<Driver, DriversDto>.OneToDAL(drivers));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה

        }

        public static DriversDto searhcByIdDriver(string driverId)
        {
            Driver c =DriversDal.searhcByIdDriver(driverId);
            return Converter<Driver, DriversDto>.OneToDTO(c);
        }

        //עידכון 
        public static void update(DriversDto drivers)
        {
            DriversDal.UpdateDriver(Converter<Driver, DriversDto>.OneToDAL(drivers));
            //ממיר לדאל מכיוון שצריך לעדכן ולהוסיף לדאטאבייס ןרק לדאל יש את הגישה
        }
        //מחיקה 
        public static void Delete(DriversDto drivers)
        {
            DriversDal.Delete(Converter<Driver, DriversDto>.OneToDAL(drivers).DriverId);
        }
        public static DriversDto searhcById(int id)
        {
            Driver c = DriversDal.SearchDriver(id);
            return Converter<Driver, DriversDto>.OneToDTO(c);
        }

        public static List<DriversDto> GetByCity(int cityid)
        {
            List<Driver> driver = DriversDal.GetByCity(cityid);
            return Converter<Driver, DriversDto>.ManyToDTO(driver);
        }
    }
}
