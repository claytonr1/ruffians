using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRDataStructures
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // just test code here for node creation
            Node head;
            head = null;
            head = new Node("Ruff",1,head);

            Console.WriteLine(head.GetItem());
            Console.WriteLine(head.GetCount());

            
            Console.ReadLine();

        }
    }
}
