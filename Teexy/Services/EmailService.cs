using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teexy.Services
{
	public class EmailService
	{
		private string _emailAddress = "login@yandex.ru";
		private string _emailPassword = "login@yandex.ru";
		private string _smtpHost = "smtp.yandex.ru";
		private int _smtpPort = 25;

		public async Task SendEmailAsync(string email, string subject, string message)
		{
			var emailMessage = new MimeMessage();

			emailMessage.From.Add(new MailboxAddress("Адміністрація сайту", _emailAddress));
			emailMessage.To.Add(new MailboxAddress("", email));
			emailMessage.Subject = subject;
			emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
			{
				Text = message
			};

			using (var client = new SmtpClient())
			{
				await client.ConnectAsync(_smtpHost, _smtpPort, false);
				await client.AuthenticateAsync(_emailAddress, _emailPassword);
				await client.SendAsync(emailMessage);

				await client.DisconnectAsync(true);
			}
		}
	}
}
