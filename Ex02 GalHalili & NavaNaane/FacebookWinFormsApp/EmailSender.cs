using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public static class EmailSender
    {
        private const int k_GmailSMTPPort = 587;
        private const string k_GmailHost = "smtp.gmail.com";
        private static ManualResetEvent s_EmailSentEvent = new ManualResetEvent(false);
        public static bool s_IsEmailSendingSucceed { get; private set; } = false;

        public static void SendEmailsInNewThread(string i_GroupName, string i_GroupLink, List<string> i_EmailsList, User i_LoggedInUser)
        {
            Thread emailThread = new Thread(() =>
            {
                sendEmails(i_GroupName, i_GroupLink, i_EmailsList, i_LoggedInUser);
            });

            emailThread.Start();
        }

        private static void sendEmails(string i_GroupName, string i_GroupLink, List<string> i_EmailsList, User i_LoggedInUser)
        {
            string senderEmail = "fapp20140@gmail.com";
            string senderAppPassword = "jmqi dcpi wvqq vnzb";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            message.From = new MailAddress(senderEmail);
            message.Subject = $"{i_LoggedInUser.Name} created new group - Please Join";
            message.Body = $"Hey! {i_LoggedInUser.Name} created a group and wants you to join. Here is the link to the new group called '{i_GroupName}': {i_GroupLink}";
            smtp.Port = k_GmailSMTPPort;
            smtp.Host = k_GmailHost;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(senderEmail, senderAppPassword);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            foreach (string email in i_EmailsList)
            {
                message.To.Add(new MailAddress(email));
            }

            try
            {
                smtp.Send(message);
                s_IsEmailSendingSucceed = true;
            }
            catch (Exception)
            {
                s_IsEmailSendingSucceed = false;
            }
            finally
            {
                s_EmailSentEvent.Set();
            }
        }

        public static void WaitForEmailToSend()
        {
            s_EmailSentEvent.WaitOne();
        }
    }
}