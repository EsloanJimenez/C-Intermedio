using CSIPJR.Domain.Core;
using CSIPJR.Domain.Interface;

namespace CSIPJR.Domain.Class.CourseClass
{
    public class OnlineCourse : Course
    {
        private readonly IEmailSender emailSender;
        public string Url { get; set; }

        public OnlineCourse(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
        public override void Subscribe(Estudiante estudiante)
        {
            throw new NotImplementedException();

            //Enviar notificacion
            this.emailSender.SendEmail(new Email() { });
        }
    }
}
