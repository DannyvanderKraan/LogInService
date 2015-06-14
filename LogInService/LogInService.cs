using LogInService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInService
{ 
    public class LogInService
    {
        public ICardPresenceChecker MyCardPresenceChecker { get; set; }

        public LogInService(ICardPresenceChecker cardPresenceChecker)
        {
            this.MyCardPresenceChecker = cardPresenceChecker;
            this.MyCardPresenceChecker.CardIn += MyCardPresenceChecker_CardIn;
            this.MyCardPresenceChecker.CardOut += MyCardPresenceChecker_CardOut;
            this.MyCardPresenceChecker.Init();
        }

        private void MyCardPresenceChecker_CardOut(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format("{0} said the card is out!", sender));
        }

        private void MyCardPresenceChecker_CardIn(object sender, EventArgs e)
        {
            Console.WriteLine(string.Format("{0} said the card is in!", sender));
        }
    }
}
