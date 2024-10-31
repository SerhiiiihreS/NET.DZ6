using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NET.DZ6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em = new Employee();     
            em.Enter();
            em.Print();
            Aircraft er= new Aircraft();
            er.Enter();
            er.Print();
        }
    }
}
