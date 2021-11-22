using Entities.Concrete;
using System.Net;
using System.Net.Mail;

namespace Business
{
    public class MailHelper
    {
        public static bool SendMail(User user)
        {
            try
            {
                MailAddress fromAdress = new MailAddress("anindakapindainfo@gmail.com");
                MailAddress toAdress = new MailAddress(user.Mail);
                MailMessage message = new MailMessage();

                message.Subject = "Anında kapında mail doğrulama";
                message.Body = $"<p>Anında Kapında sistemine kayıt oldunuz. Hesabınızın bilgileri aşağıda yer almaktadır. Lütfen aşağıdaki linke tıklayarak mailnizi aktive ediniz. Anında Kapında ile iyi alışverişler.</p><p>İsim : {user.FirstName}</p><p>Soyisim : {user.LastName}</p><p>Mail adresi : {user.Mail}</p><p><a href='http://localhost:20979/Account/Login'>Doğrula</a></p>";
                message.IsBodyHtml = true;
                message.From = fromAdress;
                message.To.Add(toAdress);

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("anindakapindainfo@gmail.com","Test.123");
                smtp.EnableSsl = true;
                smtp.Send(message);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
