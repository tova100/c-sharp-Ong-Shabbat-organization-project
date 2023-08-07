using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    
        public class Converter<T_DAL, T_DTO>
        {
            public static T_DAL OneToDAL(T_DTO item)
            {
                // ההגדרות
                var config = new MapperConfiguration(cfg =>
                {
                    // מאיזה סוג לאיזה סוג ההמרה
                    cfg.CreateMap<T_DTO, T_DAL>();

                    // lowercase => companyid
                    // UPPERCASE => COMPANYID
                    // pascalCase => companyId (company_id)

                    // מקור = ממה להמיר
                    cfg.SourceMemberNamingConvention = new PascalCaseNamingConvention();// companyId

                    // היעד = למה להמיר
                    cfg.DestinationMemberNamingConvention = new LowerUnderscoreNamingConvention(); // company_id
                });

                // config אוביקט שיודע למפות = להמיר מסוג לסוג לפי ההגדרות שבתוך
                var mapper = new Mapper(config);
                // ההמרה בפועל
                return mapper.Map<T_DAL>(item);
            }

            public static T_DTO OneToDTO(T_DAL item)
            {
                // ההגדרות
                var config = new MapperConfiguration(cfg =>
                {
                    // מאיזה סוג לאיזה סוג ההמרה
                    cfg.CreateMap<T_DAL, T_DTO>();

                    // lowercase => companyid
                    // UPPERCASE => COMPANYID
                    // pascalCase => companyId (company_id)

                    // מקור = ממה להמיר
                    cfg.SourceMemberNamingConvention = new LowerUnderscoreNamingConvention(); // company_id

                    // היעד = למה להמיר
                    cfg.DestinationMemberNamingConvention = new PascalCaseNamingConvention();// companyId
                });

                // config אוביקט שיודע למפות = להמיר מסוג לסוג לפי ההגדרות שבתוך
                var mapper = new Mapper(config);
                 return mapper.Map<T_DTO>(item);
                // ההמרה בפועל
             
            }

            public static List<T_DTO> ManyToDTO(List<T_DAL> lst)
            {
                return lst.Select(item => OneToDTO(item)).ToList();
            }

            public static List<T_DAL> ManyToDAL(List<T_DTO> lst)
            {
                return lst.Select(item => OneToDAL(item)).ToList();
            }
        }
    }


