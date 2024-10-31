using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

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
            matrix we= new matrix();    
            we.Enter();
            we.Print();
            we.MinMax();
        }
    }
}
