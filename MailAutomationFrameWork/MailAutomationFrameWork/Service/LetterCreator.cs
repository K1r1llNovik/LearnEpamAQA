using MailAutomationFrameWork.Base;

namespace MailAutomationFrameWork.Service
{
    public static class LetterCreator
    {
        public static Letter SendLetter => new Letter(UserCreator.UserYandex.Login, "Hello everyone");

        public static Letter ReplyLetter => new Letter(UserCreator.UserMailRu.Login, "Nickname1337");
    }
}
