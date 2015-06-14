using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInService.Interfaces
{
    public interface ICardPresenceChecker
    {
        void Init();
        event EventHandler CardIn;
        event EventHandler CardOut;
    }
}
