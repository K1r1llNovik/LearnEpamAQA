using System;
using System.Collections.Generic;
using System.Text;

namespace MailWebDriver.Base
{
    public class Letter
    {
        public string EmailReciever { get; set; }
        public string LettersText { get; set; }

        public Letter(string emailreciever, string lettersText)
        {
            EmailReciever = emailreciever;
            LettersText = lettersText;
        }
    }
}
