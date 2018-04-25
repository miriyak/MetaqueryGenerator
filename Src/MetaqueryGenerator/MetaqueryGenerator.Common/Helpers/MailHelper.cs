using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace MetaqueryGenerator.Common.Helpers
{
	public static class MailHelper
	{

		public static bool SendMail(string subject,string body, List<string> to = null)
		{
			string networkCredentialUserName = ConfigurationManager.AppSettings["NetworkCredentialUserName"];
			string networkCredentialPassword = ConfigurationManager.AppSettings["NetworkCredentialPassword"];

			MailMessage mail = new MailMessage();
			SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
			mail.From = new MailAddress(networkCredentialUserName);
			if (to != null && to.Count > 0)
				mail.To.Add(string.Join(";", to));
			else
			{
				string toAddress = ConfigurationManager.AppSettings["MailToAddressDefault"];
				mail.To.Add(toAddress);
			}

			mail.Subject = subject;
			mail.Body = body;
			mail.IsBodyHtml = true;
			/*System.Net.Mail.Attachment attachment;
			attachment = new System.Net.Mail.Attachment("e:/temp/textfile.txt");
			mail.Attachments.Add(attachment);
			*/

			SmtpServer.Port = 587;
			
			SmtpServer.Credentials = new System.Net.NetworkCredential(networkCredentialUserName, networkCredentialPassword);
			SmtpServer.EnableSsl = true;

			SmtpServer.Send(mail);

			return true;
		}
	}
}
