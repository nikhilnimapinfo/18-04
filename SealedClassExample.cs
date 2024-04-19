using System;

namespace Properties
{
   sealed public class SealedClassExample {

        public void m1()
        {
            Console.WriteLine("It is a m1 Method");
        }
    
    }

    public class SealedProgram : SealedClassExample
    {
        public void m2()
        {
            Console.WriteLine("It's a M2 Method ");
        }
    }
}
