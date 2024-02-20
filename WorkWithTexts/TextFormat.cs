using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WorkWithTexts
{
    public class TextFormat
    {
        public static string NameFormat(string name)
        {
            if (name.Equals(""))
            {
                return "";
            }
            else
            {
                name = name.Trim().ToLower();
                string[] nameArr = name.Split(' ');
                string result = "";
                foreach (var item in nameArr)
                {
                    result += item[0].ToString().ToUpper() + item.Substring(1) + " ";
                }
                return result.Trim();
            }
        }

        public static string PhoNoFormat(string phoneNo)
        {
            string result = "";
            phoneNo = phoneNo.Trim();
            result = Regex.Replace(phoneNo, "[^0-9]", "");
            if (result.Length >= 8 && result.Length <= 13)
            {
                if (result.StartsWith("00370"))
                {
                    result = result.Substring(5);
                }
                else if (result.StartsWith("370"))
                {
                    result = result.Substring(3);
                }
                else if (result.StartsWith("8"))
                {
                    result = result.Substring(1);
                }
                return result;
            }
            return result;
        }

        public static string EMailFormat(string eMail)
        {
            if (eMail.Equals(""))
            {
                return "";
            }
            eMail = eMail.Trim().ToLower().Replace(" ", "");
            return eMail;
        }
    }
}
