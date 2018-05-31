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
		public static List<KeyValuePair<int, string>> GetDBNotForExperiment()
		{
			List<TblDatabaseManagement> allDB = DatabaseManagementsDS.GetNotForExperiment();
			List<KeyValuePair<int, string>> results = new List<KeyValuePair<int, string>>();
			results.Add(new KeyValuePair<int, string>(0, "Select DB"));
			results.AddRange(allDB.Select(x => new KeyValuePair<int, string>(x.Id, x.DbName)).ToList());
			return results;
		}
		public static List<KeyValuePair<int, string>> GetDBArityExists(int dbID)
		{
			var list = MetaqueryDS.GetDBArityExists(dbID);
			List<KeyValuePair<int, string>> results = new List<KeyValuePair<int, string>>();
			results.Add(new KeyValuePair<int, string>(0, "Select Arity"));
			results.AddRange(list.Select(x => new KeyValuePair<int, string>(x, x.ToString())).ToList());
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

	}
}
