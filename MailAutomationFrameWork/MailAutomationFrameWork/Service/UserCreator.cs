using System;
using MailAutomationFrameWork.Base;

namespace MailAutomationFrameWork.Service
{
    public static class UserCreator
    {
        public static readonly string TestDataMailRuName = "testdata.mailru.user.name";
        public static readonly string TestDataMailRuPass = "testdata.mailru.user.password";
        public static readonly string TestDataYandexName = "testdata.yandex.user.name";
        public static readonly string TestDataYandexPass = "testdata.yandex.user.password";

        public static User UserMailRu
            => new User(TestDataReader.GetValue(TestDataMailRuName), TestDataReader.GetValue(TestDataMailRuPass));

        public static User UserYandex
            => new User(TestDataReader.GetValue(TestDataYandexName), TestDataReader.GetValue(TestDataYandexPass));

        public static User UserEmptyMailRU
            => new User(string.Empty, string.Empty);

        public static User UserInvalidLoginMailRu
            => new User("dfvpodrnpk12-sckvfir@mail.ru", string.Empty);

        public static User UserInvalidPasswordMailRu
            => new User(TestDataReader.GetValue(TestDataMailRuName), TestDataReader.GetValue(TestDataYandexPass));

        public static User UserEmptyPassword
            => new User(TestDataReader.GetValue(TestDataMailRuName), string.Empty);



    }
}
