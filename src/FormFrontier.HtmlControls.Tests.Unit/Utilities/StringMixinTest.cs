using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using FormFrontier.HtmlControls.Utilities;

namespace FormFrontier.HtmlControls.Tests.Unit.Utilities
{
    [TestFixture]
    public class StringMixinTest
    {
        [Test]
        public void testFormat() 
        {
            string text1 = String.Format("<label for=\"{0}\">{1}</label>", "foo", "bar");
            string text2 = "<label for=\"{0}\">{1}</label>".FormatArgs("foo", "bar");
            Assert.That(text1 == text2);
        }
    }
}
