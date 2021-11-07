using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector.Builder.Tools
{
    public class PageTool : IPageTool
    {
        public string Name => "page_tool";

        public string Description => "description";

        public string Version => "0";

        public string SafeDisplayName => "Page Tool";

        public bool OnClick(MouseEventArgs e)
        {
            return false;
        }

        public bool OnFailure()
        {
            return false;
        }

        public bool OnSuccess()
        {
            return false;
        }

        public bool OnTrigger()
        {
            return false;
        }
    }
}
