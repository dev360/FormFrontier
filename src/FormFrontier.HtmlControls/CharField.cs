using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

using FormFrontier.HtmlControls.Utilities;

namespace FormFrontier.HtmlControls
{

    /// <summary>
    /// Character input field for shorter text.
    /// </summary>
    [Serializable]
    public class CharField : BaseField
    {

        #region "Private/protected fields"
        
        private int? _maxLength = null;

        #endregion

        #region "Public properties"

        public virtual int? MaxLength 
        {
            get { return _maxLength; }
            set { _maxLength = value; }
        }

        #endregion

        #region "Rendering functions"

        /// <summary>
        /// Rendering inputs
        /// </summary>
        /// <param name="writer"></param>
        protected override void RenderInputControls(HtmlTextWriter writer)
        {
            

            string labelHtml = "<input id=\"{0}\" name=\"{0}\" value=\"{1}\" />".FormatArgs(this.ID);
            writer.Write(labelHtml);
        }

        protected override void RenderValidation(HtmlTextWriter writer)
        {

        }

        #endregion
    }
}
