namespace AdaptorPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            MailServer mailServer = new GoogleMailServerAdapter();
            mailServer.ConnectAndSendMail("info@test.com", "Hello World!", "John Doe");

            Console.ReadKey();
        }
    }
}
