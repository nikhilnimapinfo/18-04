using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            // Properties Example 
            Program e1 = new Program();
            e1.Name = "Sonoo Jaiswal";
            Console.WriteLine("Employee Name: " + e1.Name);

            // Base Keyword Example
            ClassBase s = new ClassBase();
            s.BaseMethod();

            //Sealed KeyWord Example
            SealedProgram sp = new SealedProgram();
            sp.m2();
            // sp.m1(); Give Compile Time Error


           
        }
    }
}
