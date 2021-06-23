using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGNLib.Core
{
    public static class ListViewExtensions
    {
        internal static List<string> TextToList(this ListViewItem.ListViewSubItemCollection subItems)
        {
            List<string> output = new List<string>();
            foreach (ListViewItem.ListViewSubItem subItem in subItems)
            {
                output.Add(subItem.Text);
            }
            return output;
        }
    }
}
