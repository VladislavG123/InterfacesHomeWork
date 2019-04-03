using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHomeWork
{
    public class House
    {
        public List<IPart> Parts { get; set; } = new List<IPart>();
        public const int AMOUNT_BASEMENT = 1;
        public const int AMOUNT_DOORS = 1;
        public const int AMOUNT_ROOFS = 1;
        public const int AMOUNT_WALLS = 4;
        public const int AMOUNT_WINDOWS = 4;

        public House()
        {
            for (int i = 0; i < AMOUNT_BASEMENT; i++)
                Parts.Add(new Basement());
            for (int i = 0; i < AMOUNT_DOORS; i++)
                Parts.Add(new Door());
            for (int i = 0; i < AMOUNT_ROOFS; i++)
                Parts.Add(new Roof());
            for (int i = 0; i < AMOUNT_WALLS; i++)
                Parts.Add(new Wall());
            for (int i = 0; i < AMOUNT_WINDOWS; i++)
                Parts.Add(new Window()); 
        }
    }
}
