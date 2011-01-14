using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using FormFrontier.HtmlControls.Widgets;

namespace FormFrontier.HtmlControls.Tests.Unit.Widgets
{
    [TestFixture]
    public class InputTypeTest
    {
        [Test]
        public void TestEquals()
        {
            InputType t1 = InputType.Button;
            InputType t2 = InputType.Button;
            InputType t3 = InputType.CheckBox;

            Assert.That(t1.Equals(t2) == true);
            Assert.That(t1.Equals(t3) == false);
        }

        [Test]
        public void TestEqualityOperator()
        {
            InputType t1 = InputType.Button;
            InputType t2 = InputType.Button;
            InputType t3 = InputType.CheckBox;

            Assert.That((t1==t2) == true);
            Assert.That((t2==t3) == false);
        }

        [Test]
        public void TestInequalityOperator()
        {
            InputType t1 = InputType.Button;
            InputType t2 = InputType.Button;
            InputType t3 = InputType.CheckBox;

            Assert.That((t1 != t2) == false);
            Assert.That((t2 != t3) == true);
        }


        [Test]
        public void TestValues()
        { 
            // Ensure that we have the correct values.
            Assert.That(InputType.Button.Value == "button");
            Assert.That(InputType.CheckBox.Value == "checkbox");
            Assert.That(InputType.Color.Value == "color");
            Assert.That(InputType.Date.Value == "date");
            Assert.That(InputType.DateTime.Value == "datetime");
            Assert.That(InputType.DateTimeLocal.Value == "datetime-local");
            Assert.That(InputType.Email.Value == "email");
            Assert.That(InputType.File.Value == "file");
            Assert.That(InputType.Hidden.Value == "hidden");
            Assert.That(InputType.Image.Value == "image");
            Assert.That(InputType.Month.Value == "month");
            Assert.That(InputType.Number.Value == "number");
            Assert.That(InputType.Password.Value == "password");
            Assert.That(InputType.Radio.Value == "radio");
            Assert.That(InputType.Range.Value == "range");
            Assert.That(InputType.Reset.Value == "reset");
            Assert.That(InputType.Search.Value == "search");
            Assert.That(InputType.Submit.Value == "submit");
            Assert.That(InputType.Text.Value == "text");
            Assert.That(InputType.Time.Value == "time");
            Assert.That(InputType.Url.Value == "url");
            Assert.That(InputType.Week.Value == "week");
        }

        [Test]
        public void TestIsSerializable()
        { 
            // Ensure that the object is serializable.
            InputType obj = InputType.Radio;
            Assert.That(obj, Is.BinarySerializable);
            Assert.That(obj, Is.XmlSerializable);
        }
    }
}
