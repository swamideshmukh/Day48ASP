using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Day48Demo.Services.Utilities
{
    public static class HtmlHelper
    {
        public static string GetFormattedValue(this string text)
        {
            return text.Replace("\n", "<br />\n");
        }

        public static void ShowStatusMessage(this Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }
    }
}