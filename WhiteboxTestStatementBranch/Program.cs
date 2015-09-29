using System;

namespace WhiteboxTestStatementBranch
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean allowed = false;
            Console.Write("Alter des Klettergartenbesuchers?");
            int alter = Convert.ToInt32(Console.ReadLine());
            if (alter >= 16) { allowed = true;}
            else {Console.Write("Gibt es die Erlaubnis eines Erziehungsberechtigten? (y/n)");
                if (Console.ReadLine().ToUpper() == "Y") {allowed = true;}};
            Einlass(allowed);
            Console.ReadLine();
        }
        public static void Einlass(Boolean a)
        {
            if (a) { Console.WriteLine("Erlaubt!"); }
            else { Console.WriteLine("Nicht erlaubt!"); }
        }
    }
}
