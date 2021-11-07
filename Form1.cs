using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vector.Builder
{
    public partial class Form1 : Form
    {

        List<Pages.Components.Vector2Dcom> vectorObjects = new List<Pages.Components.Vector2Dcom>();

        public Form1()
        {
            InitializeComponent();

        }

        private void tool_Selector_Click(object sender, EventArgs e)
        {
            visualWorkspace1.SelectedTool = Pages.Components.VisualWorkspace.Tools.Selector;
        }

        private void tool_VectorPointer_Click(object sender, EventArgs e)
        {
            visualWorkspace1.SelectedTool = Pages.Components.VisualWorkspace.Tools.Vector_Pointer;
        }
    }
}
