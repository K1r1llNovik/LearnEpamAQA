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
            => new User { Login = TestDataReader.GetTestData(TestDataMailRuName), Password = TestDataReader.GetTestData(TestDataMailRuPass) };

        public static User UserYandex
            => new User {Login = TestDataReader.GetTestData(TestDataYandexName), Password = TestDataReader.GetTestData(TestDataYandexPass)};

        public static User UserEmptyMailRU
            => new User { Login = string.Empty, Password = string.Empty };

        public static User UserInvalidLoginMailRu
            => new User {Login =  "dfvpodrnpk12-sckvfir@mail.ru", Password = string.Empty };

        public static User UserInvalidPasswordMailRu
            => new User { Login = TestDataReader.GetTestData(TestDataMailRuName), Password = TestDataReader.GetTestData(TestDataYandexPass) };

        public static User UserEmptyPassword
            => new User {Login =  TestDataReader.GetTestData(TestDataMailRuName), Password = string.Empty};



    }
}
