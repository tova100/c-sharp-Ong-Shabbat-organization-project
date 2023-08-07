using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DTO
{
     public class ValidationUtilites
    {
        public static bool IsEmail(string word)
        {
            string pattern = @"\b[a-zA-Z0-9]{2,}";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);
        }
        public static bool IsWord(string word)
        {
            string pattern = @"\b[a-zA-Z\s]{2,}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);
        }
        public static bool IsBranch(string word)
        {
            string pattern = @"\b[0-9]{1,4}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);
        }
        public static bool IsWordOrNum(string word)
        {
            string pattern = @"\b[a-zA-Z0-9]{2,}";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);
        }
        public static bool IsNumber(string st)//מספר
        {
            int x;
            return int.TryParse(st, out x);
        }
        public static bool IsDoubleNumber(string st)
        {
            double x;
            return double.TryParse(st, out x);
        }
        
        public static bool IsHebrew(string word)//מילב בעיברית
        {
            string pattern = @"\b[א-ת-\s ]+$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(word);
        }

        public static bool IsCellPhone(string tel)
        {
            string pattern = @"\b05[0 2 4 6 7 8]-[2-9]\d{6}$";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }
        
        
       // פעולה שאני הוספתי, לאפשר קבלת מספרי טלפון של חו"ל 
        public static bool IsPhoneNum(string tel)
        {
            string pattern = @"\b[0-9]{9,}";
            Regex reg = new Regex(pattern);
            return reg.IsMatch(tel);
        }

        public static bool LegalId(string s)//תז תקין
        {
            int x;
            if (!int.TryParse(s, out x))
                return false;
            if (s.Length < 5 || s.Length > 9)
                return false;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
                if (k > 9)
                    k -= 9;
                sum += k;

            }
            return sum % 10 == 0;
        }

        public static int GetAge(DateTime d)
        {
          DateTime t = DateTime.Today;
          int age = t.Year - d.Year;
          if (t < d.AddYears(age)) age--;
          return age;
        }




    }
 }
    

