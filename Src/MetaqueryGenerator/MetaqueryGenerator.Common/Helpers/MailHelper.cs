using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Threading;
using System.IO;

namespace MetaqueryGenerator.Common.Helpers
{
	public static class MailHelper
	{
		public static void SendHtmlMail(string subject, string body, List<string> to = null)
		{
			SendMail(true, subject, body, to);
		}
		public static void SendTextMail(string subject, string body, List<string> to = null)
		{
			SendMail(false, subject, body, to);
		}

		public static void SendHtmlMailAsync(string subject, string body, List<string> to = null)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				SendMail(true, subject, body, to);
			});
		}
		public static void SendTextMailAsync(string subject, string body, List<string> to = null)
		{
			ThreadPool.QueueUserWorkItem(delegate
			{
				SendMail(false,subject, body, to);
			});
		}

		private static void SendMail(bool isBodyHtml, string subject,string body, List<string> to = null)
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
			//mail.Body = body;
			
			//set the HTML format to true
			mail.IsBodyHtml = isBodyHtml;

			if (isBodyHtml)
			{
				string imagePath = Environment.CurrentDirectory + @"\MailTemplates\iconCreator.jpg";
				if (File.Exists(imagePath))
				{
					//create Alrternative HTML view
					AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, null, "text/html");

					//Add Image
					LinkedResource logoImage = new LinkedResource(imagePath);
					logoImage.ContentId = "logoImage";
					
					//Add the Image to the Alternate view
					htmlView.LinkedResources.Add(logoImage);

					//Add view to the Email Message
					mail.AlternateViews.Add(htmlView);
				}
				else
					mail.Body = body;
				//mail.AlternateViews.Add(getEmbeddedImage("c:/image.png"));
			}
			else
				mail.Body = body;
			/*System.Net.Mail.Attachment attachment;
			attachment = new System.Net.Mail.Attachment("e:/temp/textfile.txt");
			mail.Attachments.Add(attachment);
			*/

			SmtpServer.Port = 587;
			
			SmtpServer.Credentials = new System.Net.NetworkCredential(networkCredentialUserName, networkCredentialPassword);
			SmtpServer.EnableSsl = true;

			SmtpServer.Send(mail);

		}
	}
}
