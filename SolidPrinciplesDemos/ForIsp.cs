using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemos
{
    //public interface IMultiFunctionDevice
    //{
    //    void Print();
    //    void Scan();
    //    void Fax();
    //}

    //public class BasicPrinter : IMultiFunctionDevice
    //{
    //    public void Print()
    //    {
    //        Console.WriteLine("...Printing....");
    //    }

    //    public void Scan()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Fax()
    //    {
    //        throw new NotImplementedException(); 
    //    }
    //}


    public interface IPrinter
    {
        void Print();
    }


    public interface IScanner
    {
        void Scan();
    }




    public class BasicPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing.."); 
        }
    }


}
