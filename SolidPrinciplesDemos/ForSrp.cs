using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemos
{
    //public class Invoice
    //{
    //    public void CalculateTotal()
    //    {
    //       
    //        var total = 0; 
    //    }
    //}

    //public class InvoicePrint
    //{
    //    public void PrintInvoice()
    //    {
    //        Console.WriteLine("Printing invoice...");
    //    }
    //}

    //public class InvoiceRepository
    //{
    //    public void SaveToDatabase()
    //    {
    //        Console.WriteLine("Saved");
    //    }
    //}


    public class InvoiceCalculator
    {
        public void CalculateTotal()
        {
            var total = 0;
            Console.WriteLine($"Total: {total}");
        }
    }



    public class InvoicePrinter
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Invoice print"); 
        }
    }

    public class InvoiceRepository
    {
        public void SaveToDatabase()
        {
            Console.WriteLine("Invoice saved to database");
        }
    }


}
