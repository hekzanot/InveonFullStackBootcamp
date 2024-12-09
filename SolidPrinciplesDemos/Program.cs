using System;
using SolidPrinciplesDemos;

namespace SolidPrinciplesDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOLID Principles Demo");

            
            Console.WriteLine("1. Single Responsibility Principle");
            var invoicePrinter = new InvoicePrinter();
            invoicePrinter.PrintInvoice();

          
            Console.WriteLine("\n2. Open/Closed Principle )");
            var discount = new NormalCustomerDiscount();
            Console.WriteLine($"Discounted Amount: {discount.ApplyDiscount(100)}");


           
            Console.WriteLine("\n3. Liskov Substitution Principle (LSP)");
            Bird flyingBird = new FlyingBird();
            Bird penguin = new Penguin();

            flyingBird.Move(); 
            penguin.Move();  

            Console.WriteLine();


            Console.WriteLine("\n4. Interface Segregation Principle (ISP)");
          
            IPrinter printer = new BasicPrinter();
            printer.Print();


            Console.WriteLine("\n5. Dependency Inversion Principle ");

            var manager = new NotificationManager(new EmailService());
            manager.Notify("Hello world!");

            Console.WriteLine("\n-- End of Demo ---");
            Console.ReadLine();
        }
    }
}
