using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScriptForSeconds.Views
{
    public class Pager
    {
        internal static void ChangedPageTo(Page page)
        {
            ChangePage?.Invoke(null, page);
        }

        internal static event EventHandler<Page> ChangePage;
    }
}
