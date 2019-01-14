namespace _100DaysOfCoding.Packages.Models
{
    public interface IMailSender
    {
        void Send(string toAddress, string subject);
    }
}