using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormFrontier.HtmlControls.Widgets
{
    /// <summary>
    /// The available input types
    /// </summary>
    /// <remarks>For lack of a better enum.</remarks>
    [Serializable]
    public struct InputType
    {
        public string Value;

        #region "Equality overriding"
        public override bool Equals(Object obj)
        {
            if (((InputType)obj).Value == this.Value)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator !=(InputType a, InputType b)
        {
            return !(a == b);
        }

        public static bool operator ==(InputType a, InputType b)
        {
            if (a == null && b == null)
                return true;
            else
            {
                return (a.Value == b.Value);
            }
        }
        #endregion

        #region "Instantiation"
        public static InputType Button
        {
            get
            {
                return new InputType("button");
            }
        }

        public static InputType CheckBox
        {
            get
            {
                return new InputType("checkbox");
            }
        }

        public static InputType File
        {
            get
            {
                return new InputType("file");
            }
        }

        public static InputType Hidden
        {
            get
            {
                return new InputType("hidden");
            }
        }

        public static InputType Image
        {
            get
            {
                return new InputType("image");
            }
        }

        public static InputType Password
        {
            get
            {
                return new InputType("password");
            }
        }

        public static InputType Radio
        {
            get
            {
                return new InputType("radio");
            }
        }

        public static InputType Reset
        {
            get
            {
                return new InputType("reset");
            }
        }

        public static InputType Submit
        {
            get
            {
                return new InputType("submit");
            }
        }

        public static InputType Text
        {
            get
            {
                return new InputType("text");
            }
        }


        // From here on we list HTML5 types
        public static InputType Email
        {
            get
            {
                return new InputType("email");
            }
        }

        public static InputType Url
        {
            get
            {
                return new InputType("url");
            }
        }

        public static InputType Number
        {
            get
            {
                return new InputType("number");
            }
        }

        public static InputType Range
        {
            get
            {
                return new InputType("range");
            }
        }

        public static InputType Date
        {
            get
            {
                return new InputType("date");
            }
        }

        public static InputType Month
        {
            get
            {
                return new InputType("month");
            }
        }

        public static InputType Week
        {
            get
            {
                return new InputType("week");
            }
        }

        public static InputType Time
        {
            get
            {
                return new InputType("time");
            }
        }

        public static InputType DateTime
        {
            get
            {
                return new InputType("datetime");
            }
        }

        public static InputType DateTimeLocal
        {
            get
            {
                return new InputType("datetime-local");
            }
        }

        public static InputType Search
        {
            get
            {
                return new InputType("search");
            }
        }

        public static InputType Color
        {
            get
            {
                return new InputType("color");
            }
        }

#endregion

        public InputType(string value)
        {
            this.Value = value;
        }

    }

    
}
