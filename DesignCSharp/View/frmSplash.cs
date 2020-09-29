using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DesignCSharp.Constants;
using DesignCSharp.Design;

namespace DesignCSharp.View
{
    public partial class frmSplash : Form
    {

        public frmSplash()
        {
            InitializeComponent();
            progressBar.Value = 0;
            this.Region = DesignDesign1Dashboard.ArredondarTela(this, 25, 25);
            FrameConstants.Design1 = new Design1();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            progressBar.Text = progressBar.Value.ToString();

            if(progressBar.Value == 100)
            {
                timerSplash.Stop();
                this.Hide();
                FrameConstants.Design1.Show();
            }
        }
    }
}
