using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHomeWork
{
    public class Team
    {
        public List<IWorker> Workers { get; set; } = new List<IWorker>();

        public Team(int amountWorkers, int amountTeamLeaders)
        {
            for (int i = 0; i < amountTeamLeaders; i++)
                Workers.Add(new TeamLeader());
            for (int i = 0; i < amountWorkers; i++)
                Workers.Add(new Worker());
        }
    }
}
