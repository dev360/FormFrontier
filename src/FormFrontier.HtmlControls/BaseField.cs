using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;

using FormFrontier.HtmlControls.Utilities;

namespace FormFrontier.HtmlControls
{
    /// <summary>
    /// The base field that all fields derive from
    /// </summary>
    [Serializable]
    public abstract class BaseField : Control
    {
        #region "Private/protected members"
        private Http.IHttpContext _context = (Http.IHttpContext) new Http.ASPNetHttpContext();

        private string _labelHtml = string.Empty;
        private string _value = string.Empty;
        #endregion

        #region "Public properties"

        /// <summary>
        /// Main motivation for this is to make everything
        /// easier to mock and test.
        /// </summary>
        protected virtual Http.IHttpContext httpContext 
        {
            get { return (Http.IHttpContext) _context; }
        }

        /// <summary>
        /// Gets/sets the value of the control.
        /// </summary>
        public virtual string Value
        {
            get
            {
                return _value;
            }
            set 
            {
                _value = value;
            }
        }

        /// <summary>
        /// Gets/sets the label of the control.
        /// </summary>
        public string Label
        {
            get { return this._context.HtmlDecode(this.LabelHtml); }
            set { _labelHtml = this._context.HtmlEncode(value); }
        }

        /// <summary>
        /// Gets/sets the label of the control.
        /// </summary>
        public string LabelHtml
        {
            get { return _labelHtml; }
            set { _labelHtml = value; }
        }

        #endregion

        #region "Functions"

        #region "Rendering"

        protected override void Render(HtmlTextWriter writer)
        {
            this.RenderLabel(writer);
            this.RenderInputControls(writer);
            this.RenderValidation(writer);
        }

        protected virtual void RenderLabel(HtmlTextWriter writer)
        {
            writer.Write("<label for=\"{0}\">{1}</label>".FormatArgs(this.ID, this.Label));
        }

        protected abstract void RenderInputControls(HtmlTextWriter writer);

        protected abstract void RenderValidation(HtmlTextWriter writer);
        
        #endregion

        #endregion

    }
}
