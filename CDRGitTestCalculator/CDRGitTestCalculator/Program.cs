using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRGitTestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // adding a comment -- alpha branch
            Console.WriteLine(Add(1,4));
            Console.ReadLine();
        }

        static int Add(int first, int second)
        {
            Console.WriteLine("The answer is: ");
            return first + second;
        }
        
        
    }
}
