
using ConsoleUI;
using System.Globalization;

string text = "Welcome each and every one of you";
string[] array = text.Split(" ");

foreach (var word in array)
{
    Console.WriteLine(word);
}

string joined = string.Join(" ", array);
Console.WriteLine(joined);

TimeSpan time = new TimeSpan(1, 2, 3);
Console.WriteLine(time);

DateTime date = new DateTime(1990, 1, 1);
Console.WriteLine(date);

DateTime now = DateTime.Now;
Console.WriteLine(now);

DateTime date1 = DateTime.Now;
DateTime date2 = DateTime.UtcNow;
TimeSpan differenceTime = date1 - date2;
Console.WriteLine($"Difference: {date1} - {date2} = {differenceTime}");

DateTimeOffset dateOffset1 = DateTimeOffset.Now;
DateTimeOffset dateOffset2 = DateTimeOffset.UtcNow;
TimeSpan differenceTimeOffset = dateOffset1 - dateOffset2;
Console.WriteLine($"Difference: {dateOffset1} - {dateOffset2} = {differenceTimeOffset}");

CultureInfo myCLint1 = new CultureInfo("ro-RO", false);
Console.WriteLine($"Culture: {myCLint1.DisplayName}");
CultureInfo myCLint2 = new CultureInfo("en-US", false);
Console.WriteLine($"Culture: {myCLint2.DisplayName}");



string tags1 = "<app><app><app></app></app>";
string tags2 = "<app></app></app><app><app>";
string tags3 = "</app><app><app></app></app>";

int count1 = OptionalAssignment.solution(tags1);
Console.WriteLine($"Number of tags that are not in correct format: {count1}"); //1

int count2 = OptionalAssignment.solution(tags2);
Console.WriteLine($"Number of tags that are not in correct format: {count2}"); //3

int count3 = OptionalAssignment.solution(tags3);
Console.WriteLine($"Number of tags that are not in correct format: {count3}"); //1


Console.ReadLine();
