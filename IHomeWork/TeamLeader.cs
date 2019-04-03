using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHomeWork
{
    public class TeamLeader : IWorker
    {
        public bool Work(ref House house)
        {
            string report = "";
            foreach (var part in house.Parts)
            {
                string answer = part.IsBuild ? "построен": "в разработке!";
                report += $"{part.GetType().ToString()} - { answer }\n";
            }
            Console.WriteLine();
            Console.WriteLine(report);
            return true;
        }
    }
}
