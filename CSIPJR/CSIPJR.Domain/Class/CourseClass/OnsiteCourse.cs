using CSIPJR.Domain.Core;
using CSIPJR.Domain.Interface;

namespace CSIPJR.Domain.Class.CourseClass
{
    public class OnsiteCourse : Course
    {
        private readonly IEmailSender emailSender;
        public string? Location { get; set; }
        public int Days { get; set; }

        public OnsiteCourse(IEmailSender emailSender)
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


//clase del martes 30 de abril del 2024