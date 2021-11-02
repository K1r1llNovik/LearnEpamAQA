using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using OpenQA.Selenium;
using System.IO;
using NUnit.Framework;

namespace MailAutomationFrameWork.Service
{
    public class TestDataReader
    {
        private static string _filePath = "../../../../MailAutomationFrameWork/Resources/";
        private static string _environment = TestContext.Parameters["environment"];

        public static string GetTestData(string key)
        {
            return GetValue(_environment, key);
        }

        private static string GetValue(string environment, string key)
        {
            var text = File.ReadAllText($"{_filePath}{environment}.json");
            JObject json = JObject.Parse(text);

            return json.Descendants()
                    .OfType<JProperty>()
                    .Where(p => p.Name == key)
                    .First()
                    .Value
                    .ToString();
        }
    }
}
