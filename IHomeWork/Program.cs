using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team(4, 1);
            House house = new House();

            while (true)
            {
                foreach (var worker in team.Workers)
                {
                    if (!worker.Work(ref house))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Здание построено!");
                        Console.WriteLine("     **\n" +
                                          "    *  *\n" +
                                          "   *    *\n" +
                                          "   ******\n" +
                                          "   * -- *\n" +
                                          "   *  | *\n" +
                                          "   ******\n");
                        Console.Read();
                        return;
                    }
                }
            }

        }
    }
}
