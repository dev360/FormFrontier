using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace FormFrontier.HtmlControls.Tests.Unit.Mocks
{
    /// <summary>
    /// Mock HTML writer
    /// </summary>
    public class MockHtmlWriter : HtmlTextWriter
    {
        private StringBuilder html = new StringBuilder();


        public string ToString()
        {
            return ToString(true);
        }

        /// <summary>
        /// Returns the string
        /// </summary>
        /// <returns></returns>
        public new string ToString(bool resetWriter)
        {
            string value = html.ToString();
            if (resetWriter)
            {
                html = new StringBuilder();
            }
            return value;
        }

        public override void Write(bool value)
        {
            html.Append(value);
        }

        public override void Write(char value)
        {
            html.Append(value);
        }

        public override void Write(char[] buffer)
        {
            html.Append(buffer);
        }

        public override void Write(char[] buffer, int index, int count)
        {
            html.Append(buffer, index, count);
        }

        public override void Write(decimal value)
        {
            html.Append(value);
        }

        public override void Write(double value)
        {
            html.Append(value);
        }

        public override void Write(float value)
        {
            html.Append(value);
        }

        public override void Write(int value)
        {
            html.Append(value);
        }

        public override void Write(long value)
        {
            html.Append(value);
        }

        public override void Write(object value)
        {
            html.Append(value);
        }

        public override void Write(string format, object arg0)
        {
            html.Append(String.Format(format, arg0));
        }

        public override void Write(string format, object arg0, object arg1)
        {
            html.Append(String.Format(format, arg0, arg1));
        }

        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            html.Append(String.Format(format, arg0, arg1, arg2));
        }

        public override void Write(string format, params object[] arg)
        {
            html.Append(String.Format(format, arg));
        }

        public override void Write(string s)
        {
            html.Append(s);
        }

        public override void Write(uint value)
        {
            html.Append(value);
        }

        public override void Write(ulong value)
        {
            html.Append(value);
        }

        public override void WriteLine()
        {
            html.AppendLine();
        }

        public override void WriteLine(bool value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(char value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(char[] buffer)
        {
            html.AppendLine(buffer.ToString());
        }

        public override void WriteLine(char[] buffer, int index, int count)
        {
            html.Append(buffer, index, count);
            html.Append("\n");
        }

        public override void WriteLine(decimal value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(double value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(float value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(int value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(long value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(object value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(string format, object arg0)
        {
            html.AppendLine(String.Format(format, arg0));
        }

        public override void WriteLine(string format, object arg0, object arg1)
        {
            html.AppendLine(String.Format(format, arg0, arg1));
        }

        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            html.AppendLine(String.Format(format, arg0, arg1, arg2));
        }

        public override void WriteLine(string format, params object[] arg)
        {
            html.AppendLine(String.Format(format, arg));
        }

        public override void WriteLine(string s)
        {
            html.AppendLine(s);
        }

        public override void WriteLine(uint value)
        {
            html.AppendLine(value.ToString());
        }

        public override void WriteLine(ulong value)
        {
            html.AppendLine(value.ToString());
        }

        public static MockHtmlWriter GetInstance()
        {
            return new MockHtmlWriter(null);
        }

        public MockHtmlWriter(System.IO.TextWriter writer)
            : base(writer)
        {
            
        }
    }
}
