using System;

namespace Properties
{
   public class SealedMethod
    {
        public virtual void m1()
        {
            Console.WriteLine("In M1 Method");
        }
        public virtual void m2()
        {
            Console.WriteLine("In M2 Method ");
        }
    }

    public class SealedMethod1 : SealedMethod
    {
        public sealed override void m1()
        {
            Console.WriteLine("SealedMethod1 in m1");
        }

        public override void m2()
        {
            Console.WriteLine("SealedMethod1 in m2");
        }
    }

    public class SealedMethod2 : SealedMethod1 
    {
        public override void m1()
        {
            Console.WriteLine("SealedMethod1 in m1");
        }

        public override void m2()
        {
           // sealed int x = 10;
            Console.WriteLine("SealedMethod1 in m2");
             
    }
    }
}
