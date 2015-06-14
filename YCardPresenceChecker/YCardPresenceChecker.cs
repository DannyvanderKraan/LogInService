using LogInService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YCardPresenceChecker
{
    public class YCardPresenceChecker : ICardPresenceChecker
    {
        public event EventHandler CardIn;
        public event EventHandler CardOut;

        private bool IsCardIn { get; set; }

        public void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                if (IsCardIn)
                {
                    CardIn?.Invoke(this, new EventArgs());
                }
                else
                {
                    CardOut?.Invoke(this, new EventArgs());

                }
                IsCardIn = !IsCardIn;
            }
        }
    }
}
