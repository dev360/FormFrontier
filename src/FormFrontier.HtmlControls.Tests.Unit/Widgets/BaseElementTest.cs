using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

using FormFrontier.HtmlControls.Widgets;

namespace FormFrontier.HtmlControls.Tests.Unit.Widgets
{
    [TestFixture]
    public class BaseElementTest
    {
        #region "Test property assignment"

        [Test]
        public void TestProperty_AccessKey()
        {
            Element e = new Element();
            e.Accesskey = "1";
            Assert.That(e.Accesskey == "1");
            Assert.That(e.Attributes.ContainsKey("accesskey"));
            Assert.That(e.Attributes["accesskey"] == "1");
            Assert.That(e["accesskey"] == "1");

            e.Accesskey = null;
            Assert.That(e.Attributes.ContainsKey("accesskey") == false);
        }

        [Test]
        public void TestProperty_Class()
        {
            Element e = new Element();
            e.Class = "1";
            Assert.That(e.Class == "1");
            Assert.That(e.Attributes.ContainsKey("class"));
            Assert.That(e.Attributes["class"] == "1");
            Assert.That(e["class"] == "1");

            e.Class = null;
            Assert.That(e.Attributes.ContainsKey("class") == false);
        }

        [Test]
        public void TestProperty_Dir()
        {
            Element e = new Element();
            e.Dir = "1";
            Assert.That(e.Dir == "1");
            Assert.That(e.Attributes.ContainsKey("dir"));
            Assert.That(e.Attributes["dir"] == "1");
            Assert.That(e["dir"] == "1");

            e.Dir = null;
            Assert.That(e.Attributes.ContainsKey("dir") == false);
        }

        [Test]
        public void TestProperty_Id()
        {
            Element e = new Element();
            e.Id = "1";
            Assert.That(e.Id == "1");
            Assert.That(e.Attributes.ContainsKey("id"));
            Assert.That(e.Attributes["id"] == "1");
            Assert.That(e["id"] == "1");

            e.Id = null;
            Assert.That(e.Attributes.ContainsKey("id") == false);
        }

        [Test]
        public void TestProperty_Lang()
        {
            Element e = new Element();
            e.Lang = "1";
            Assert.That(e.Lang == "1");
            Assert.That(e.Attributes.ContainsKey("lang"));
            Assert.That(e.Attributes["lang"] == "1");
            Assert.That(e["lang"] == "1");

            e.Lang = null;
            Assert.That(e.Attributes.ContainsKey("lang") == false);
        }

        [Test]
        public void TestProperty_Style()
        {
            Element e = new Element();
            e.Style = "1";
            Assert.That(e.Style == "1");
            Assert.That(e.Attributes.ContainsKey("style"));
            Assert.That(e.Attributes["style"] == "1");
            Assert.That(e["style"] == "1");

            e.Style = null;
            Assert.That(e.Attributes.ContainsKey("style") == false);
        }

        [Test]
        public void TestProperty_TabIndex()
        {
            Element e = new Element();
            e.TabIndex = 1;
            Assert.That(e.TabIndex == 1);
            Assert.That(e.Attributes.ContainsKey("tabindex"));
            Assert.That(e.Attributes["tabindex"] == "1");
            Assert.That(e["tabindex"] == "1");
            
            e.TabIndex = null;
            Assert.That(e.Attributes.ContainsKey("tabindex") == false);
            Assert.That(e.TabIndex == null);
        }

        [Test]
        public void TestProperty_Title()
        {
            Element e = new Element();
            e.Title = "1";
            Assert.That(e.Title == "1");
            Assert.That(e.Attributes.ContainsKey("title"));
            Assert.That(e.Attributes["title"] == "1");
            Assert.That(e["title"] == "1");

            e.Title = null;
            Assert.That(e.Attributes.ContainsKey("title") == false);
            Assert.That(e.Title == null);
        }

        [Test]
        public void TestProperty_XmlLang()
        {
            Element e = new Element();
            e.XmlLang = "en";
            Assert.That(e.XmlLang == "en");
            Assert.That(e.Attributes.ContainsKey("xml:lang"));
            Assert.That(e.Attributes["xml:lang"] == "en");
            Assert.That(e["xml:lang"] == "en");

            e.XmlLang = null;
            Assert.That(e.Attributes.ContainsKey("xml:lang") == false);
            Assert.That(e.XmlLang == null);
        }

        #endregion


        #region "Class for testing base class"

        public class Element : BaseElement
        {
            public override void Render(System.Web.UI.HtmlTextWriter writer)
            {
                throw new NotImplementedException();
            }
        }

        #endregion

    }
}
