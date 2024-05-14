using CSIPJR.Domain.Core;

namespace CSIPJR.Domain.Interface
{
    public interface IEmailSender
    {
        void SendEmail(Email email);
    }
}
