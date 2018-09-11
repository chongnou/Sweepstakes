using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepsStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepsStack.Push(sweepstakes);
        }
        public Sweepstakes GetNextSweepstakesWinner()
        {
            return sweepsStack.Pop();
        }
    }
}
