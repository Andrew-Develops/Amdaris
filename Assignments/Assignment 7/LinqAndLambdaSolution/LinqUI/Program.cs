using LinqUI;
using LinqUI.Models;

Console.WriteLine("Practice Linq and Lambda expressions");
Console.WriteLine("|-----------------------------------|");

// List of int
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var numberResult = numbers.Where(x => x > 5).ToList();

foreach (var number in numberResult)
{
    Console.WriteLine(number);
}

// String collection
IList<string> names = new List<string> { "Mike", "John", "Smith", "Andy", "Rafael", "Anderson" };
var nameResult = names.Where(x => x.Contains("An"));

foreach (var str in nameResult)
{
    Console.WriteLine(str);
}

Console.WriteLine("|------------------------------------|");

    // Decat sa cream un foreach si sa aplicam logica pentru fiecare obiect, cream un linq statement care face asta pentru noi
    // Linq statement : data.Where(x => x.Addresses.Count > 1);

LambdaTests();
LinqTests();


Console.WriteLine("Done Processing");
Console.ReadLine();

void LambdaTests()
{
    var data = SampleData.GetContactData();
    // Linq statement : data.Where(x => x.Addresses.Count > 1);

    // Filter people who have at least two addresses
        // IEnumerable of type ContactModel
    //var results = data.Where(x => x.Addresses.Count > 1);
    //foreach (var item in results)
    //{
    //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}");
    //}

    // Select only ContactModel FirstName variable
        // IEnumerable of type string
    //var results = data.Select(x => x.FirstName);
    //foreach (var item in results)
    //{
    //    Console.WriteLine(item);
    //}

    // Selectam doar 2 obiecte din lista noastra
        // IEnumerable of type ContactModel
    //var results = data.Take(2);
    //foreach (var item in results)
    //{
    //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}");
    //}

    // Skip primele 2 obiecte si selectam urmatoarele 2 obiecte
        // IEnumerable of type ContactModel
    //var results = data.Skip(2).Take(2);
    //foreach (var item in results)
    //{
    //    Console.WriteLine($"Name: {item.FirstName} {item.LastName}");
    //}

    // Sortam in functie de LastName
    var results = data.OrderBy(x => x.LastName);
    foreach (var item in results)
    {
        Console.WriteLine($"Name: {item.FirstName} {item.LastName}");
    }

}
void LinqTests()
{
    var contacts = SampleData.GetContactData();
    var addresses = SampleData.GetAddressData();

    // Linq statement
    // c este un alias
    //var results = (from c in contacts
    //               where c.Addresses.Count > 1
    //               select c);

    // one-to-many relation
    //var results = (from c in contacts
    //               join a in addresses
    //               on c.Id equals a.ContactId
    //               // cream un nou obiect
    //               select new { c.FirstName, c.LastName, a.City, a.State });

    //foreach (var item in results)
    //{
    //    Console.WriteLine($"Name: {item.FirstName} {item.LastName} from {item.City}, {item.State}");
    //}

    // Linq + Lambda
    //var results = (from c in contacts
    //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(x => x.ContactId == c.Id) });

    // Return number of addresses for each contact
    //foreach (var item in results)
    //{
    //    Console.WriteLine($"Name: {item.FirstName} - {item.Addresses.Count()}");
    //}

    // many-to-many relation to get the List<int> of Addresses for every contact
    var results = (from c in contacts
                   select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)) });

    // Return number of addresses for each contact
    foreach (var item in results)
    {
        Console.WriteLine($"Name: {item.FirstName} - {item.Addresses.Count()}");
    }


}

// Metoda este identica cu expresia lambda de mai sus
bool RunMe(ContactModel x)
{
    return x.Addresses.Count > 1;
}

