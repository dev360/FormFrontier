using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

namespace FormFrontier.HtmlControls.Widgets
{
    /// <summary>
    /// The base element
    /// </summary>
    [Serializable]
    public abstract class BaseElement
    {
        #region "Key values" 
        
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();

        public Dictionary<string, string> Attributes
        {
            get { return _attributes; }
        }

        /// <summary>
        /// Gets/sets HTML attributes
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public virtual string this[string key]
        {
            get
            {
                if (this._attributes.ContainsKey(key))
                    return this._attributes[key];
                else
                    return null;
            }
            set
            {
                // If the value is null, then 
                // we remove the key alltogether.
                if (value == null)
                    this._attributes.Remove(key);
                else
                    this._attributes[key] = value;
            }
        }

        #endregion
        
        #region "Standard attributes"

        /// <summary>
        /// Specifies a keyboard shortcut to access an element
        /// </summary>
        public virtual string Accesskey
        {
            get { return this["accesskey"]; }
            set { this["accesskey"] = value; }
        }

        /// <summary>
        /// Specifies a classname for an element
        /// </summary>
        public virtual string Class
        {
            get { return this["class"]; }
            set { this["class"] = value; }
        }

        /// <summary>
        /// Specifies the text direction for the content in an element
        /// </summary>
        public virtual string Dir
        {
            get { return this["dir"]; }
            set { this["dir"] = value; }
        }

        /// <summary>
        /// Specifies a unique id for an element
        /// </summary>
        public virtual string Id
        {
            get { return this["id"]; }
            set { this["id"] = value; }
        }

        /// <summary>
        /// Specifies a language code for the content in an element
        /// </summary>
        public virtual string Lang
        {
            get { return this["lang"]; }
            set { this["lang"] = value; }
        }

        /// <summary>
        /// Specifies an inline style for an element
        /// </summary>
        public virtual string Style
        {
            get { return this["style"]; }
            set { this["style"] = value; }
        }

        /// <summary>
        /// Specifies the tab order of an element
        /// </summary>
        public virtual int? TabIndex
        {
            get
            {
                string val = this["tabindex"];
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
                    this["tabindex"] = value.ToString();
                }
                else
                {
                    this["tabindex"] = null;
                }
            }
        }

        /// <summary>
        /// Specifies extra information about an element
        /// </summary>
        public virtual string Title
        {
            get { return this["title"]; }
            set { this["title"] = value; }
        }

        /// <summary>
        /// Specifies a language code for the content in an element, in XHTML documents
        /// </summary>
        public virtual string XmlLang
        {
            get { return this["xml:lang"]; }
            set { this["xml:lang"] = value; }
        }

        #endregion

        #region "Rendering"
        public abstract void Render(HtmlTextWriter writer);
        #endregion

        public BaseElement()
        { 
            
        }

    }
}
