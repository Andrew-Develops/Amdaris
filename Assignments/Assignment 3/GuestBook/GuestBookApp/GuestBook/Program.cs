using ConsoleUI;
using GuestLibrary.Model;

List<GuestModel> guests = new List<GuestModel>();

GuestBookLogic.GreetMessage();
GuestBookLogic.GetGuestInformation(guests);
GuestBookLogic.PrintUserInformation(guests);


Console.ReadLine();
