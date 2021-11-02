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
            => new User(TestDataReader.GetTestData(TestDataMailRuName), TestDataReader.GetTestData(TestDataMailRuPass));

        public static User UserYandex
            => new User(TestDataReader.GetTestData(TestDataYandexName), TestDataReader.GetTestData(TestDataYandexPass));

        public static User UserEmptyMailRU
            => new User(string.Empty, string.Empty);

        public static User UserInvalidLoginMailRu
            => new User("dfvpodrnpk12-sckvfir@mail.ru", string.Empty);

        public static User UserInvalidPasswordMailRu
            => new User(TestDataReader.GetTestData(TestDataMailRuName), TestDataReader.GetTestData(TestDataYandexPass));

        public static User UserEmptyPassword
            => new User(TestDataReader.GetTestData(TestDataMailRuName), string.Empty);



    }
}
