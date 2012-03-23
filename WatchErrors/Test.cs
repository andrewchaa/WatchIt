using System;
using System.IO;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace WatchErrorsTest
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void General_Information_Is_Splitted_By_Hr_Tag()
        {
            string log = File.ReadAllText(@"..\..\web_20120322.htm");
            var messages = log.Split(new [] {"<hr/>"}, StringSplitOptions.RemoveEmptyEntries);

            Assert.That(messages.Length, Is.EqualTo(3));
        }
    }
}
