using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using OpenQA.Selenium;
using System.IO;
using NUnit.Framework;

namespace MailAutomationFrameWork.Service
{
    public static class TestDataReader
    {
        private static string _environment = TestContext.Parameters["environment"];
        private static string _filePath = "Resources/";

        public static string GetValue(string key)
        {
            var objectJsonFile = File.ReadAllText($"{_filePath}{_environment}.json");
            JObject json = JObject.Parse(objectJsonFile);

            return json.Descendants()
                .OfType<JProperty>()
                .Where(k => k.Name == key)
                .First()
                .Value
                .ToString();
        }
    }
}
