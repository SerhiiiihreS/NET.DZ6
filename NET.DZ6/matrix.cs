using System;
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
    internal class matrix
    {
        int columns;
        int rows;
        public matrix() { }
        public matrix(int columns, int rows) { 
            this.columns = columns;
            this.rows = rows;
        }
        public void Enter()
        {
            Console.WriteLine("columns ->");
            columns = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("rows ->");
            rows = Convert.ToInt32(Console.ReadLine());
            Random rnd1 = new Random();
            double[,] Array2 = new double[columns, rows];


            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    Array2[i, j] = Convert.ToDouble(rnd1.Next(-100, 100));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");

        }
        public void Print()
        {
            Random rnd1 = new Random();
            double[,] Array2 = new double[columns, rows];
            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    Array2[i, j] = Convert.ToDouble(rnd1.Next(-100, 100));
                    Console.Write("{0,6}", Array2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");

        }
        public void MinMax()
        {
            Random rnd1 = new Random();
            double[,] Array2 = new double[columns, rows];
            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    Array2[i, j] = Convert.ToDouble(rnd1.Next(-100, 100));
                }
                Console.WriteLine();
            }
            double max3 = Array2[0, 0];
            double min3 = Array2[0, 0];

            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    if (Array2[i, j] > max3) { max3 = Array2[i, j];  }
                    if (Array2[i, j] < min3) { min3 = Array2[i, j]; }
                }
            }
            Console.WriteLine(max3);
            Console.WriteLine(min3);
        }
    }
}
