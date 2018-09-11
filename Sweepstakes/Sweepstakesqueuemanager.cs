using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepsQueue = new Queue<Sweepstakes>();

        public void InsertSweepstakes(Sweepstakes sweepstake)
        {
            sweepsQueue.Enqueue(sweepstake);
        }
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepsQueue.Dequeue();
        }
    }
}
