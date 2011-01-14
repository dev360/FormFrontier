using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

using FormFrontier.HtmlControls.Utilities;

namespace FormFrontier.HtmlControls.Widgets
{
    /// <summary>
    /// A HTML input control.
    /// </summary>
    [Serializable]
    public class Input : BaseElement
    {
        
        #region "Input-specific attributes"

        /// <summary>
        /// Specifies the types of files that can be submitted through a file upload (only for type="file")
        /// </summary>
        public virtual string Accept
        {
            get { return this["accept"]; }
            set { this["accept"] = value; }
        }

        /// <summary>
        /// Specifies an alternate text for an image input (only for type="image")
        /// </summary>
        public virtual string Alt
        {
            get { return this["alt"]; }
            set { this["alt"] = value; }
        }

        /// <summary>
        /// Specifies that an input element should be preselected when the page loads (for type="checkbox" or type="radio")
        /// </summary>
        public virtual string Checked
        {
            get { return this["checked"]; }
            set { this["checked"] = value; }
        }
        
        /// <summary>
        /// Specifies that an input element should be disabled when the page loads
        /// </summary>
        public virtual string Disabled
        {
            get { return this["disabled"]; }
            set { this["disabled"] = value; }
        }

        /// <summary>
        /// Specifies the maximum length (in characters) of an input field (for type="text" or type="password")
        /// </summary>
        public virtual int? MaxLength
        {
            get
            {
                string val = this["maxlength"];
                int intVal = 0;
                if (val == null || !int.TryParse(val, out intVal))
                    return null;
                else
                    return intVal;
            }
            set 
            {
                if (value != null)
                {
                    this["maxlength"] = value.ToString();
                }
                else 
                {
                    this["maxlength"] = null;
                }
            }
        }

        /// <summary>
        /// Specifies a name for an input element
        /// </summary>
        public virtual string Name
        {
            get { return this["Name"]; }
            set { this["Name"] = value; }
        }

        /// <summary>
        /// Specifies that an input field should be read-only (for type="text" or type="password")
        /// </summary>
        public virtual string Readonly
        {
            get { return this["readonly"]; }
            set { this["readonly"] = value; }
        }
        
        /// <summary>
        /// Specifies the width of an input field
        /// </summary>
        public virtual string Size
        {
            get { return this["size"]; }
            set { this["size"] = value; }
        }
        
        /// <summary>
        /// Specifies the URL to an image to display as a submit button
        /// </summary>
        public virtual string Src
        {
            get { return this["src"]; }
            set { this["src"] = value; }
        }
        
        /// <summary>
        /// Specifies the type of an input element
        /// </summary>
        public virtual InputType? Type
        {
            get 
            {
                string type = this["type"];
                if (type == null)
                    return null;
                else
                    return new InputType(type); 
            }
            set 
            { 
                if(value == null)
                    this["type"] = null; 
                else
                    this["type"] = value.Value.Value;
            }
        }
        
        /// <summary>
        /// Specifies the value of an input element
        /// </summary>
        public virtual string Value
        {
            get { return this["value"]; }
            set{ this["value"] = value; }
        }

        #endregion
        
        #region "Event attributes"

        /// <summary>
        /// Script to be run when an element loses focus
        /// </summary>
        public virtual string OnBlur
        {
            get { return this["onblur"]; }
            set { this["onblur"] = value; }
        }

        /// <summary>
        /// Script to be run when an element change
        /// </summary>
        public virtual string OnChange
        {
            get { return this["onchange"]; }
            set { this["onchange"] = value; }
        }

        /// <summary>
        /// Script to be run on a mouse click
        /// </summary>
        public virtual string OnClick
        {
            get { return this["onclick"]; }
            set { this["onclick"] = value; }
        }

        /// <summary>
        /// Script to be run on a mouse double-click
        /// </summary>
        public virtual string OnDblClick
        {
            get { return this["ondblclick"]; }
            set { this["ondblclick"] = value; }
        }

        /// <summary>
        /// Script to be run when an element gets focus
        /// </summary>
        public virtual string OnFocus
        {
            get { return this["onfocus"]; }
            set { this["onfocus"] = value; }
        }

        /// <summary>
        /// Script to be run when mouse button is pressed
        /// </summary>
        public virtual string OnMouseDown
        {
            get { return this["onmousedown"]; }
            set { this["onmousedown"] = value; }
        }

        /// <summary>
        /// Script to be run when mouse pointer moves
        /// </summary>
        public virtual string OnMouseMove
        {
            get { return this["onmousemove"]; }
            set { this["onmousemove"] = value; }
        }

        /// <summary>
        /// Script to be run when mouse pointer moves out of an element
        /// </summary>
        public virtual string OnMouseOut
        {
            get { return this["onmouseout"]; }
            set { this["onmouseout"] = value; }
        }

        /// <summary>
        /// Script to be run when mouse pointer moves over an element
        /// </summary>
        public virtual string OnMouseOver
        {
            get { return this["onmouseover"]; }
            set { this["onmouseover"] = value; }
        }

        /// <summary>
        /// Script to be run when mouse button is released
        /// </summary>
        public virtual string OnMouseUp
        {
            get { return this["onmouseup"]; }
            set { this["onmouseup"] = value; }
        }

        /// <summary>
        /// Script to be run when a key is pressed
        /// </summary>
        public virtual string OnKeyDown
        {
            get { return this["onkeydown"]; }
            set { this["onkeydown"] = value; }
        }

        /// <summary>
        /// Script to be run when a key is pressed and released
        /// </summary>
        public virtual string OnKeyPress
        {
            get { return this["onkeypress"]; }
            set { this["onkeypress"] = value; }
        }

        /// <summary>
        /// Script to be run when a key is released
        /// </summary>
        public virtual string OnKeyUp
        {
            get { return this["onkeyup"]; }
            set { this["onkeyup"] = value; }
        }

        /// <summary>
        /// Script to be run when an element is selected
        /// </summary>
        public virtual string OnSelect
        {
            get { return this["onselect"]; }
            set { this["onselect"] = value; }
        }

        #endregion

        #region "HTML5 attributes"

        /// <summary>
        /// HTML5 Only; Specifies the maximum value allowed
        /// </summary>
        public virtual int? Max
        {
            get
            {
                string val = this["max"];
                int intVal = 0;
                if (val == null || !int.TryParse(val, out intVal))
                    return null;
                else
                    return intVal;
            }
            set 
            {
                if (value != null)
                {
                    this["max"] = value.ToString();
                }
                else 
                {
                    this["max"] = null;
                }
            }
        }

        /// <summary>
        /// HTML5 Only; Specifies the minimum value allowed
        /// </summary>
        public virtual int? Min
        {
            get
            {
                string val = this["min"];
                int intVal = 0;
                if (val == null || !int.TryParse(val, out intVal))
                    return null;
                else
                    return intVal;
            }
            set
            {
                if (value != null)
                {
                    this["min"] = value.ToString();
                }
                else
                {
                    this["min"] = null;
                }
            }
        }

        /// <summary>
        /// HTML5 Only; Specifies legal number intervals (if step="3", legal numbers could be -3,0,3,6, etc)
        /// </summary>
        public virtual int? Step
        {
            get
            {
                string val = this["step"];
                int intVal = 0;
                if (val == null || !int.TryParse(val, out intVal))
                    return null;
                else
                    return intVal;
            }
            set
            {
                if (value != null)
                {
                    this["step"] = value.ToString();
                }
                else
                {
                    this["step"] = null;
                }
            }
        }

        /// <summary>
        /// HTML5 Only; The list attribute specifies a datalist for an input field. A datalist is a list of options for an input field.
        /// </summary>
        public virtual string List
        {
            get { return this["list"]; }
            set { this["list"] = value; }
        }

        /// <summary>
        /// The width attributes specifies the width of the image used for the input type image.
        /// </summary>
        public virtual string Width 
        {
            get { return this["width"]; }
            set { this["width"] = value; }
        }

        /// <summary>
        /// HTML5 Only; The height attributes specifies the height of the image used for the input type image.
        /// </summary>
        public virtual string Heigth
        {
            get { return this["heigth"]; }
            set { this["heigth"] = value; }
        }

        /// <summary>
        /// HTML5 Only; The multiple attribute specifies that multiple values can be selected for an input field.
        /// </summary>
        public virtual bool Multiple
        {
            get 
            {
                if (this["multiple"] == null)
                    return false;
                else
                    return true;
            }
            set 
            {
                if (value == false)
                    this["multiple"] = null; // causes key removal
                else
                    this["multiple"] = "multiple";
            }
        }

        /// <summary>
        /// HTML5 Only; The autocomplete attribute specifies that the form or input field should have an autocomplete function.
        /// </summary>
        public virtual bool? AutoComplete
        {
            get
            {
                if (this["autofocus"] != null)
                {
                    if (this["autofocus"] == "on")
                    {
                        return true;
                    }
                    else if (this["autofocus"] == "off")
                    {
                        return false;
                    }
                }

                return null;
            }
            set
            {
                if (value == null)
                    this["autofocus"] = null; // causes key removal
                else if (value == true)
                    this["autofocus"] = "on";
                else                
                    this["autofocus"] = "off";
            }
        }

        /// <summary>
        /// HTML5 Only; The autofocus attribute specifies that a field should automatically get focus when a page is loaded.
        /// </summary>
        public virtual bool AutoFocus
        {
            get
            {
                if (this["autofocus"] == null)
                    return false;
                else
                    return true;
            }
            set
            {
                if (value == false)
                    this["autofocus"] = null; // causes key removal
                else
                    this["autofocus"] = "autofocus";
            }
        }

        /// <summary>
        /// HTML5 Only; The form attribute specifies one or more forms the input field belongs to.
        /// </summary>
        public virtual string Form
        {
            get { return this["form"]; }
            set { this["form"] = value; }
        }

        /// <summary>
        /// HTML5 Only; Overrides the form action attribute
        /// </summary>
        public virtual string FormAction
        {
            get { return this["formaction"]; }
            set { this["formaction"] = value; }
        }

        /// <summary>
        /// HTML5 Only; Overrides the form enctype attribute
        /// </summary>
        public virtual string FormEncType
        {
            get { return this["formenctype"]; }
            set { this["formenctype"] = value; }
        }

        /// <summary>
        /// HTML5 Only; Overrides the form method attribute
        /// </summary>
        public virtual string FormMethod
        {
            get { return this["formmethod"]; }
            set { this["formmethod"] = value; }
        }

        /// <summary>
        /// HTML5 Only; Overrides the form novalidate attribute
        /// </summary>
        public virtual string FormNoValidate
        {
            get { return this["formnovalidate"]; }
            set { this["formnovalidate"] = value; }
        }

        /// <summary>
        /// HTML5 Only; Overrides the form target attribute
        /// </summary>
        public virtual string FormTarget
        {
            get { return this["formtarget"]; }
            set { this["formtarget"] = value; }
        }

        /// <summary>
        /// HTML5 Only; The novalidate attribute specifies that the form or input field should not be validated when submitted.
        /// </summary>
        public virtual bool NoValidate
        {
            get 
            {
                if (this["novalidate"] == null)
                    return false;
                else
                    return true;
            }
            set 
            {
                if (value == false)
                    this["novalidate"] = null; // causes key removal
                else
                    this["novalidate"] = "novalidate";
            }
        }

        /// <summary>
        /// HTML5 Only; The pattern attribute specifies a pattern used to validate an input field.
        /// </summary>
        public virtual string Pattern 
        {
            get { return this["pattern"]; }
            set { this["pattern"] = value; }
        }

        /// <summary>
        /// HTML5 Only; The placeholder attribute provides a hint that describes the expected value of an input field.
        /// </summary>
        public virtual string Placeholder
        {
            get { return this["placeholder"]; }
            set { this["placeholder"] = value; }
        }

        /// <summary>
        /// HTML5 Only; The required attribute specifies that an input field must be filled out before submitting.
        /// </summary>
        public virtual bool Required
        {
            get
            {
                if (this["required"] == null)
                    return false;
                else
                    return true;
            }
            set
            {
                if (value == false)
                    this["required"] = null; // causes key removal
                else
                    this["required"] = "required";
            }
        }

        #endregion

        #region "Rendering"

        public override void Render(HtmlTextWriter writer)
        {
            writer.Write("<input");
            foreach (string key in this.Attributes.Keys)
            {
                string value = this.Attributes[key];
                writer.Write(" {0}=\"{1}\"".FormatArgs(key, value));
            }
            writer.Write(" />");

        }

        #endregion

        #region "Constructors"

        public Input() : base()
        {
            
        }

        public Input(CharField field) : base()
        {
            this.MaxLength = field.MaxLength;

        }

        #endregion
    }
}
