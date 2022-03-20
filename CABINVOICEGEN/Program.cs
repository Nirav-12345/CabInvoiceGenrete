using System;
namespace CABINVOICEGEN;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to cab invoice generator");
        InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.Normal);
        double fare = invoiceGenerator.CalculateFare(2.0, 5);
        Console.WriteLine($"Fare: {fare}");
    }
}