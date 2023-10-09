using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.DAL
{
    public class Client
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
       
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string ShortName
        {
            get 
            {
                if(string.IsNullOrWhiteSpace(LName))
                {
                    return string.Format("{0} {1}.", FName, MName[0]);
                }
                else
                {
                    return string.Format("{0} {1}. {2}.", FName, MName[0], LName[0]);
                }
            }
        }

        public DateTime BirthDate  { get; set; }
        public int GetAge
        {
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Iin { get; set; }

        public Address Address { get; set; }
    }
}
