namespace Decorator.SimpleDecorator
{
    public class SendEmailDecorator
    {
        private readonly SendEmail _sendEmail;

        public SendEmailDecorator(SendEmail sendEmail)
        {
            _sendEmail = sendEmail;
        }

        public void Send()
        {
            _sendEmail.Send();
            Console.WriteLine("Email logged.");
        }
    }
}
