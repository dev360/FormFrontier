using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FormFrontier.HtmlControls.Widgets;

using NUnit.Framework;

using FormFrontier.HtmlControls.Tests.Unit.Mocks;

namespace FormFrontier.HtmlControls.Tests.Unit.Widgets
{
    [TestFixture]
    public class InputTest : BaseTestFixture
    {
        #region "Property assignment tests"
        
        [Test]
        public void TestProperty_AutoComplete()
        { 
            // ..
        }

        #endregion

        #region "Rendering tests"

        [Test]
        public void TestRenderingOrder()
        {
            // The rendering should be
            // dependent on the order that
            // items are set on the control.
            Input input = new Input();
            input.Type = InputType.Text;
            input.TabIndex = 10;
            input.Value = "default";
            
            MockHtmlWriter writer = MockHtmlWriter.GetInstance();
            input.Render(writer);
            string actualHtml = writer.ToString();
            string expectedHtml = "<input type=\"text\" tabindex=\"10\" value=\"default\" />";
            Assert.AreEqual(expectedHtml, actualHtml);
        }

        #endregion

        [Test]
        public void TestIsSerializable()
        {
            // Ensure that the object is serializable.
            Input obj = new Input();
            Assert.That(obj, Is.BinarySerializable);
            Assert.That(obj, Is.XmlSerializable);
        }

    }
}
