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
        WaitingToExpand = 4,
		HasPartialResult = 5,
		Expanded = 6,
        Done =7,
		ExpandedAndDone = 1000,
	}
	public enum ResultMQ
	{
		HasAnswers = 1,
		SupportFailure,
		ConfidenceFailure
	}
	public enum ExpandType
	{
		All,
		InBodyOnly,
		NewRelationOnly
	}


}
