

using ConsoleUI.Models;
using System.IO.Compression;
using System.Security.Cryptography;

List<EmployeeModel> itEmployees = new();
List<EmployeeModel> saleEmployees = new();

String employee = @"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\employee.txt";

using (StreamReader sr = new StreamReader(employee))
{
    while (sr.EndOfStream == false)
    {
        string[] line = sr.ReadLine().Split(';');
        if (line[2] == "IT")
        {
            itEmployees.Add(new EmployeeModel(line[0], line[1], line[2]));
        }
        else
        {
            saleEmployees.Add(new EmployeeModel(line[0], line[1], line[2]));
        }
    }
}

Console.WriteLine("IT Employees:");
foreach (var person in itEmployees)
{
    Console.WriteLine(person.EmployeeInfo);
}

Console.WriteLine();

Console.WriteLine("Sales Employees:");
foreach (var person in saleEmployees)
{
    Console.WriteLine(person.EmployeeInfo);
}

// Save the list of IT employees to a file called itEmployees.txt
try
{
    using (StreamWriter sw = new StreamWriter(@"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\itEmployees.txt"))
    {
        foreach (var item in itEmployees)
        {
            sw.WriteLine(item.ToString());
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Save the list of Sales employees to a file called salesEmployees.txt
try
{
    using (StreamWriter sw = new StreamWriter(@"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\salesEmployees.txt"))
    {
        foreach (var item in saleEmployees)
        {
            sw.WriteLine(item.ToString());
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Encrypt itEmployees file
try
{
    using (Aes aes = Aes.Create())
    {
        using (FileStream fs = new FileStream(@"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\itEmployees.txt", FileMode.OpenOrCreate))
        {
            using (FileStream fsEncrypt = new FileStream(@"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\itEmployeesEncrypt.txt", FileMode.OpenOrCreate))
            {
                using (CryptoStream cs = new CryptoStream(fsEncrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    fs.CopyTo(cs);
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// Use GZip compression for the salesEmployees file
try
{
    using (FileStream fs = new FileStream(@"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\salesEmployees.txt", FileMode.OpenOrCreate))
    {
        using (FileStream fsCompress = new FileStream(@"C:\Users\Andrew\Documents\GitHub\Amdaris\Assignments\Assignment 8\FileSystemsAndStreamsDemo\Employee\salesEmployeesCompress.txt", FileMode.OpenOrCreate))
        {
            using (GZipStream gs = new GZipStream(fsCompress, CompressionMode.Compress))
            {
                fs.CopyTo(gs);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}