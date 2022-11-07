using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestLibrary.Model
{
    public class GuestModel : PersonModel
    {
        public string MessageToHost { get; set; }

        public string GuestInfo
        {
            get
            {
                return $"{FirstName}.{LastName}.{PhoneNumber}.{MessageToHost}";
            }
        }

        public static void Tip()
        {
            Console.WriteLine("I don't want to tip");
        }
        public static void Tip(int tipAmmount)
        {
            Console.WriteLine($"The tip for your service is: {tipAmmount}");
        }

        public virtual void Speak(string firstLanguage, string secondLanguage)
        {
            Console.WriteLine($"This person can speak {firstLanguage} and {secondLanguage}");
        }
    }
}
