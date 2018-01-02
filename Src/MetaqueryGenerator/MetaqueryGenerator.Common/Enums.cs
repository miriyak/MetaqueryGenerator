using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
    public enum StatusDB
    {
        Received = 1,
        InProcess=2,
        Done = 6
    }
    public enum StatusMQ
    {
        Received = 1,
        WaitingToSolver = 3,
        HasResult = 4,
        Expanded = 5,
        Done =6
    }
}
