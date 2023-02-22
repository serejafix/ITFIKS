namespace DZ_7_My_Blog.Services.EmailService
{
    public interface IEmailService
    {
        Task SendEmailAsync(string from, string to, string subject, string html);
    }
}
