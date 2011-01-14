using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormFrontier.HtmlControls.Utilities
{
    /// <summary>
    /// A bunch of mixin functions that extends
    /// the string class.
    /// </summary>
    public static class StringMixin
    {
        #region "FormatArgs"

        /* Some syntactic sugar to cut down on the typing
         * a little bit and make the syntax more like
         * python's formatting syntax.
         * 
         * > "Foo %s" % ('bar')
         * 
         * I had originally wished to name it just Format,
         * but unfortunately it clashes with String.Format -
         * the static method on the string class. Oh well. */

        /// <summary>
        /// Returns the formatted string
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg1"></param>
        /// <returns></returns>
        public static string FormatArgs(this String format, object arg1)
        {
            return String.Format(format, arg1);
        }


        /// <summary>
        /// Returns the formatted string
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        public static string FormatArgs(this String format, object arg1, object arg2)
        {
            return String.Format(format, arg1, arg2);
        }

        /// <summary>
        /// Returns the formatted string
        /// </summary>
        /// <param name="format"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <param name="arg3"></param>
        /// <returns></returns>
        public static string FormatArgs(this String format, object arg1, object arg2, object arg3)
        {
            return String.Format(format, arg1, arg2, arg3);
        }

        /// <summary>
        /// Returns the formatted string
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string FormatArgs(this String format, params object[] args)
        {
            return String.Format(format, args);
        }

        #endregion
    }
}
