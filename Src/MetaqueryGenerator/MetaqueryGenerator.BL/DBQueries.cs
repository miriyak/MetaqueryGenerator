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
		public static List<KeyValuePair<int, string>> GetAllDB()
		{
			List<TblDatabaseManagement> allDB = DatabaseManagementsDS.Get();
			return allDB.Select(x => new KeyValuePair<int, string>(x.Id, x.DbName)).ToList();
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
