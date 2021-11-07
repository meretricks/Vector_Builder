using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Builder.Tools
{
    internal interface IPageTool
    {
        public string Name { get; }
        public string Description { get; }
        public string Version { get; }
        public string SafeDisplayName { get; }

        public bool OnTrigger();
        public bool OnSuccess();
        public bool OnFailure();
        public bool OnClick(System.Windows.Forms.MouseEventArgs e);

    }
}
