using System;
using System.Threading;

namespace PROGPART1
{
    public class UIHelper
    {
       public static void DisplayAscii()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"
 __| |____________________________________________| |__
(__   ____________________________________________   __)
   | |        🔐 CYBER SECURITY CHATBOT 🔐         | |
   | |                                            | |
   | |        Welcome to your assistant           | |
   | |                                            | |
   | |        Type 'exit' to quit                 | |
   | |                                            | |
 __| |____________________________________________| |__
(__   ____________________________________________   __)
   | |                                            | |
");

            Console.ResetColor();
        }

        public static void TypeText(string v)
        {
            if (string.IsNullOrEmpty(v)) return;

            foreach (char c in v)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }
    }
}
