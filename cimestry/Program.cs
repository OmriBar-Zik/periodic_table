using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimestry
{
    class Program
    {
        static void Main(string[] args)
        {
            
            UserInterface start = new UserInterface();
            start.DataBaseCommands();
            SUI();
        }

        public static void SUI()
        {
            //stop until input
            Console.ReadLine();
        }
    }
}
