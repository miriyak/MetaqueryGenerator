using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common.Exceptions
{
	public class UnknownMetaqueryException : Exception
	{
		public UnknownMetaqueryException()
		: base()
		{

		}
		public UnknownMetaqueryException(string message)
		: base(message)
		{
		}
		public UnknownMetaqueryException(string message, Exception innerException)
			 : base(message, innerException)
		{
			
		}
	}
}
