using EmailService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailService.Controllers
{
    public class EmailController : Controller
    {
        //Turn on the Access for less secure apps
        public async Task<IActionResult> Index(Email email)
        {
            if (ModelState.IsValid)
            {
                MailMessage mMessage = new MailMessage();
                mMessage.To.Add(email.To);
                mMessage.Subject = email.Subject;
                mMessage.Body = email.Body;
                mMessage.IsBodyHtml = false;
                mMessage.From = new MailAddress("alexaspnet300@gmail.com");
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                // smtp 
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;

                smtpClient.Credentials = new NetworkCredential("alexaspnet300@gmail.com", "Alextest!234");
                smtpClient.EnableSsl = true;

                await smtpClient.SendMailAsync(mMessage);
                ViewData["Message"] = "Message has been send Succesfully";
            }
            return View();
        }

       
    }
   
}
