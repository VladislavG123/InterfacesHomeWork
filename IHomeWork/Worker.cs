using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHomeWork
{
    public class Worker : IWorker
    {
        public bool Work(ref House house)
        {
            foreach (var part in house.Parts)
            {
                if (part.IsBuild == false)
                {
                    part.IsBuild = true;
                    return true;
                }
            }
            return false;
        }
    }
}
