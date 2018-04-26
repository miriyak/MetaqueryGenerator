using MetaqueryGenerator.Common;
using MetaqueryGenerator.Common.Helpers;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaqueryGenerator.BL
{
	public static class MQGeneratorMail
	{
		public static void SendResultMail(TblMetaquery tblMetaquery)
		{
			string strMessage = "Result to Metaquery {0} Done";
			if (tblMetaquery.HasResult.HasValue && tblMetaquery.HasResult.Value == true)
				strMessage = "Result to Metaquery {0} Done";
			else
				strMessage = "There is no result for Metaquery {0}";

			string subject = string.Format(strMessage ,tblMetaquery.Id);
			string body = string.Format(@"Metaquery ID: {0}<br\>" +
										@"Metaquery: {1}<br\>" +
										@"StartTime: {2}<br\>" +
										@"FinishTime: {3}<br\>"
										, tblMetaquery.Id,tblMetaquery.Metaquery, tblMetaquery.StartTime, tblMetaquery.FinishTime);
			MailHelper.SendMail(subject, body);

		}

		public static void SendAssignmentMail(TblMetaqueriesResult tblMetaqueriesResult,string strMetaquery)
		{
			string subject = string.Format("There is a result for Metaquery {0}", tblMetaqueriesResult.FkMetaqueryId);
			string body = string.Format(@"Metaquery ID: {0}<br\>" +
										@"Metaquery: {1}<br\>" +
										@"Assignment: {2}<br\>" +
										@"Support Value: {3}<br\>" +
										@"Confidence Value: {4}<br\>"
										, tblMetaqueriesResult.FkMetaqueryId, strMetaquery, tblMetaqueriesResult.Assignment,tblMetaqueriesResult.SupportValue,tblMetaqueriesResult.ConfidenceValue);
			MailHelper.SendMail(subject, body);
		}
		public static void SendDBInitializedMail(TblDatabaseManagement tblDatabaseManagement)
		{
			string subject = string.Format("Database {0} initialized successfuly", tblDatabaseManagement.DbName);
			string body = "";
			ThreadPool.QueueUserWorkItem(delegate
			{
				MailHelper.SendMail(subject, body);
			});
		}
	}
}
