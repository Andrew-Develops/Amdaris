using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestLibrary.Model
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _phoneNumber;

        public virtual void Speak()
        {
            Console.WriteLine($"This person can speak English");
        }

        public string PhoneNumber
        {
            get 
            {
                return $"**-****-{_phoneNumber.Substring(_phoneNumber.Length - 4)}"; 
            }
            set 
            {
                _phoneNumber = value; 
            }
        }
    }
}
