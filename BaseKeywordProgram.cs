using System;

namespace Properties
{
    public class BaseKeywordProgram {
        public int a = 100;
    }

    public class ClassBase : BaseKeywordProgram
    {

        public int a = 200;
        public void BaseMethod()
        {
            Console.WriteLine(base.a);
            Console.WriteLine(a);
        }
    
    }
}
