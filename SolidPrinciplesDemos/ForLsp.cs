using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemos
{
    //public class Bird
    //{
    //    public virtual void Fly()
    //    {
    //        Console.WriteLine("Flying...");
    //    }
    //}

    //public class Penguin : Bird
    //{
    //    public override void Fly()
    //    {
    //        throw new Exception("Penguins can't fly!");
    //    }
    //}

    public abstract class Bird
    {
        public abstract void Move();
    }

    public class FlyingBird : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Flying...");
        }
    }

    public class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Swimming..."); 
        }
    }


}
