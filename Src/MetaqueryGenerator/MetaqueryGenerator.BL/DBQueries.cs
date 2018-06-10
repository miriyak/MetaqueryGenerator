using MetaqueryGenerator.Common;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaqueryGenerator.BL
{
	public static class DBQueries
	{
		public static List<KeyValue> GetDBNotForExperiment()
		{
			
			List<KeyValue> allDB = DatabaseManagementsDS.GetNotForExperiment();
			allDB.Insert(0,new KeyValue(0, "Select DB"));
			return allDB;
		}
		public static List<KeyValue> GetDBArityExists(int dbID)
		{
			var list = MetaqueryDS.GetDBArityExists(dbID);
			List<KeyValue> results = new List<KeyValue>();
			results.Add(new KeyValue(0, "Select Arity"));
			results.AddRange(list.Select(x => new KeyValue(x, x.ToString())).ToList());
			return results;

		}
		public static List<VMetaquery> GetMetaqueriesByDBID(int dbID)
		{
			return MetaqueryDS.GetMetaqueriesByID(dbID);
		}

		public static List<VMetaqueriesResult> GetMetaqueriesResultByID(int metaqueryID)
		{
			return MetaqueryResultDS.GetMetaqueriesResultByID(metaqueryID);
		}

		public static List<KeyValue> GetSupportExistsInProbabiltyExperiment()
		{
			var list = ProbabilityExperimentDS.GetSupportExistsInProbabiltyExperiment();
			List<KeyValue> results = new List<KeyValue>();
			results.Add(new KeyValue(0, "Select"));
			results.AddRange(list.Select(x => new KeyValue(x, x.ToString())).ToList());
			return results;
		}
		public static List<KeyValue> GetConfidenceExistsInProbabiltyExperiment()
		{
			var list = ProbabilityExperimentDS.GetConfidenceExistsInProbabiltyExperiment();
			List<KeyValue> results = new List<KeyValue>();
			results.Add(new KeyValue(0, "Select"));
			results.AddRange(list.Select(x => new KeyValue(x, x.ToString())).ToList());
			return results;
		}
		public static List<VProbabilityExperimentResult> GetProbabilityExperimentResult()
		{
			var list = ProbabilityExperimentDS.GetProbabilityExperimentResult();
			return list;
		}


	}
}
