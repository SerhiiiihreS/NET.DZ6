using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NET.DZ6
{
    internal class Employee
    {
        string LasFirPat;
        int Dateofbirth;
        int Phone;
        string Email;
        string Position;
        string Responsibilities;
        public Employee()
        {
        }
        public Employee(string LasF, int Dat, int Ph, string Em, string Pos, string Resp)
        {
            LasFirPat=LasF;
            Dateofbirth= Dat;
            Phone=Ph;
            Email=Em;
            Position=Pos;
            Responsibilities=Resp;
        }
        public void Enter()
        {
            Console.WriteLine("LasFirPat ->");
            LasFirPat = Console.ReadLine();
            Console.WriteLine("Dateofbirth ->");
            Dateofbirth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Phone ->");
            Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email ->");
            Email = Console.ReadLine();
            Console.WriteLine("Position ->");
            Position = Console.ReadLine();
            Console.WriteLine("Responsibilities ->");
            Responsibilities = Console.ReadLine();
        }
        public void Print()
        {
            Console.WriteLine(LasFirPat);
            Console.WriteLine(Dateofbirth);
            Console.WriteLine(Phone);
            Console.WriteLine(Email);
            Console.WriteLine(Position);
            Console.WriteLine(Responsibilities);
        }
        public void SetLasFirPat(string LasF)=>LasFirPat=LasF;
        public string GetLasFirPat() => LasFirPat;
        public void SetDateofbirth(int Datb) => Dateofbirth = Datb;
        public int GetDateofbirth() => Dateofbirth;
        public void SetPhone(int Pho) => Phone = Pho;
        public int GetPhone() => Phone;
        public void SetEmail(string Emal) => Email = Emal;
        public string GetEmail() => Email;
        public void SetPosition(string Pos) => Position = Pos;
        public string GetPosition() => Position;
        public void SetResponsibilities(string Res) => Responsibilities = Res;
        public string GetResponsibilities() => Responsibilities;
    }
}
