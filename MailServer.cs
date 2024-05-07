namespace AdaptorPattern
{
    public interface MailServer
    {
        void ConnectAndSendMail(string emailAddress, string content, string receiverName);
    }
}
