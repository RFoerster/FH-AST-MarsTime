using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboxTestStatementBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geburtsdatum des Klettergartenbesuchers?");
            DateTime Geburtsdatum = new DateTime();
            DateTime today = new DateTime();
            today = DateTime.Now;
            try   { Geburtsdatum = DateTime.Parse("31.12.1991");}
            catch (FormatException) {Console.WriteLine("Ungültiges Datum!");}
            Console.WriteLine("Du bist {0} Jahre alt!", today.Subtract(Geburtsdatum).ToString);
            Console.ReadLine();
        }
    }
}
