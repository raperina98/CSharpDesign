using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignCSharp.Design
{
    public partial class PanelCircle : UserControl
    {
        public PanelCircle()
        {
            this.Visible = true;
            this.Enabled = true;
            this.Region = Design.DesignDesign1Dashboard.ArredondarTela(this, 25, 25);
            this.BackColor = Color.FromArgb(37, 42, 64);
        }
    }
 
      

    
}
