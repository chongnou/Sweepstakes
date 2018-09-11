using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        public string firstName;
        public string lastName;
        public int ticketNumber;
        public string result;

        public Contestant(string FirstName, string LastName, int TicketNumber, string Result)
        {

            firstName = FirstName;
            lastName = LastName;
            ticketNumber = TicketNumber;
            result = Result;

        }
    }
}
