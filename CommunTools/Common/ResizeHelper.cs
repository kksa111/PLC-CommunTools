using System.Drawing;
using System.Windows.Forms;

namespace CommunTools.Common
{
    /// <summary>
    /// Helper to enable window resizing for forms.
    /// </summary>
    public static class ResizeHelper
    {
        public static void EnableResizing(Form form)
        {
            if (form == null) return;
            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.MaximizeBox = true;
            form.MaximumSize = Size.Empty;
        }
    }
}
