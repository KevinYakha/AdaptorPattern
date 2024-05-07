namespace AdaptorPattern
{
    public class GoogleMailServerAdapter : MailServer
    {
        private GoogleMailServer googleMailServer = new GoogleMailServer();

        public void ConnectAndSendMail(string emailAddress, string content, string receiverName)
        {
            googleMailServer.BuildConnection();
            Console.WriteLine("Email successfully encrypted...");
            googleMailServer.SendEmail(emailAddress, content);
        }
    }
}
