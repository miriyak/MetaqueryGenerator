using MetaqueryGenerator.Common;
using MetaqueryGenerator.Common.Helpers;
using MetaqueryGenerator.DS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MetaqueryGenerator.BL
{
	public static class MQGeneratorMail
	{
		public static string GetStringHtmlMessage(string fileName)
		{
			string path = Environment.CurrentDirectory + @"\MailTemplates\" + fileName;
			if (File.Exists(path))
			{
				string readText = File.ReadAllText(path);
				return readText;
			}
			return null;
		}
		public static void SendResultMail(TblMetaquery tblMetaquery)
		{
			string strMessage = "Result to Metaquery {0} Done";
			if (tblMetaquery.HasResult.HasValue && tblMetaquery.HasResult.Value == (int)ResultMQ.HasAnswers)
				strMessage = "Result to Metaquery {0} Done";
			else
				strMessage = "There is no result for Metaquery {0}";

			string subject = string.Format(strMessage ,tblMetaquery.Id);
			/*string strMsgBody = strMessage +
										@"Metaquery ID: { 0}< br\> " +
										@"Metaquery: {1}<br\>" +
										@"StartTime: {2}<br\>" +
										@"FinishTime: {3}<br\>";
			*/

			string body = string.Format(GetStringHtmlMessage("MQResult.html")
										, subject, tblMetaquery.Id, tblMetaquery.Metaquery, tblMetaquery.StartTime, tblMetaquery.FinishTime);
			MailHelper.SendHtmlMailAsync(subject, body);

		}

		public static void SendAssignmentMail(TblMetaqueriesResult tblMetaqueriesResult,string strMetaquery)
		{
			string subject = string.Format("There is a result for Metaquery {0}", tblMetaqueriesResult.FkMetaqueryId);
			/*string strMsgBody = 
										@"Metaquery ID: {0}<br\>" +
										@"Metaquery: {1}<br\>" +
										@"Assignment: {2}<br\>" +
										@"Support Value: {3}<br\>" +
										@"Confidence Value: {4}<br\>";
			*/
			string body = string.Format(GetStringHtmlMessage("MQAssignmentResult.html")
										, tblMetaqueriesResult.FkMetaqueryId, strMetaquery, tblMetaqueriesResult.Assignment,tblMetaqueriesResult.SupportValue,tblMetaqueriesResult.ConfidenceValue);
			MailHelper.SendHtmlMailAsync(subject, body);
		}
		public static void SendDBInitializedMail(TblDatabaseManagement tblDatabaseManagement)
		{
			string subject = string.Format("Database {0} initialized successfuly", tblDatabaseManagement.DbName);
			string body = "";
			MailHelper.SendTextMailAsync(subject, body);

		}
		public static void SendDBFinishedMail(TblDatabaseManagement tblDatabaseManagement)
		{
			string subject = string.Format("Database {0} done successfuly", tblDatabaseManagement.DbName);
			string body = "";
			MailHelper.SendTextMailAsync(subject, body);

		}

		public static void SendExceptionMail(Exception exception)
		{
			string subject = "There is an Exception on MQ Generator process";
			
			/*string strMsgBody = strMessage +
										@"Metaquery ID: { 0}< br\> " +
										@"Metaquery: {1}<br\>" +
										@"StartTime: {2}<br\>" +
										@"FinishTime: {3}<br\>";
			*/

			string body = string.Format(subject +
										@"Exception Message : {0}. " +
										@"Inner Exception: {1}.",exception.Message,exception.InnerException?.ToString());
			MailHelper.SendTextMailAsync(subject, body);

		}

	}
}
