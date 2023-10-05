using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace StockWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        [WebMethod(MessageName = "Hello")]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(MessageName = "For the sum of two numbers")]
        public int Addition(int x, int y)
        {
            return x + y;
        }

        [WebMethod(MessageName = "For the difference of two numbers")]
        public int Subraction(int x, int y)
        {
            return x - y;
        }

        [WebMethod(MessageName = "For the product of two numbers")]
        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        [WebMethod(MessageName = "For the division of two numbers")]
        public int Division(int x, int y)
        {
            return x / y;
        }

        [WebMethod(MessageName = "For getting the user's nameInitial by writing her initial")]
        public string GetName(char nameInitial)
        {
            if (nameInitial == 'A' || nameInitial == 'a')
            {
                return "Your nameInitial is Aakriti";
            }
            else if (nameInitial == 'M' || nameInitial == 'm')
            {
                return "Your nameInitial is Manaswini";
            }
            else
            {
                return "Your nameInitial is Sandhya";
            }
        }

        string[,] details =
        {
            {"SRA", "Sandhya Rani", "24-02-2003"},
            {"MRA", "Manaswini Ray", "30-09-2002"},
            {"AKU", "Aakriti Kumari", "14-04-2002"}
        };

        [WebMethod(MessageName ="For getting the birth date")]
        public DateTime GetBirthDate(string symbol)
        {
            for (int i = 0; i < details.GetLength(0); i++)
            {
                if (string.Compare(symbol, details[i,0])==0)
                {
                    return Convert.ToDateTime(details[i,2]);
                }
            }
            return DateTime.MinValue;
        }
        

    }
}
