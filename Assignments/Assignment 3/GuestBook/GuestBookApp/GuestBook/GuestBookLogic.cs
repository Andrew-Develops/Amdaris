using GuestLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class GuestBookLogic
    {

        public static void GreetMessage()
        {
            Console.WriteLine("Welcome to my house.");
            Console.WriteLine("Please enter your credential before going inside.");
        }
        public static string GetInformationFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        public static void GetGuestInformation(List<GuestModel> guests)
        {
            string moreGuests = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInformationFromConsole("What is your first name: ");
                guest.LastName = GetInformationFromConsole("What is your last name: ");
                guest.PhoneNumber = GetInformationFromConsole("What is your phone number: ");
                guest.MessageToHost = GetInformationFromConsole("What message would you like to tell the host: ");

                moreGuests = GetInformationFromConsole("Are more guests coming? 'y' or 'n'.");

                Console.Clear();
                guests.Add(guest);
            } while (moreGuests.ToLower() == "y");
        }

        // using enumerables
        public static void PrintUserInformation(List<GuestModel> guests)
        {
            //foreach (var guest in guests)
            //{
            //    Console.WriteLine(guest.GuestInfo);
            //}

            var enumerator = guests.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine($"Guest information: {enumerator.Current.GuestInfo}");
            }
        }


    }
}
