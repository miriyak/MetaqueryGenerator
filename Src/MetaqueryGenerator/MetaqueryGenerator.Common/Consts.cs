using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaqueryGenerator.Common
{
	public class Consts
	{
		public const string DateTimeFormat = "dd/MM/yyyy HH:mm";
	}
	public class KeyValue
	{
		public int Key { get; set; }
		public string Value { get; set; }
		public KeyValue()
		{

		}
		public KeyValue(int key, string value)
		{
			Key = key;
			Value = value;
		}
	}
}
