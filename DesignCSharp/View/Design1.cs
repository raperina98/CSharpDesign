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
using System.Runtime.Remoting.Messaging;
using DesignCSharp.Design;

//using System.Runtime.InteropServices;
namespace DesignCSharp.View
{
    public partial class Design1 : Form
    {


        public Design1()
        {
            InitializeComponent();
        }
      
        private void Design1_Load(object sender, EventArgs e)
        {
            //Coleção usada na classe DesignButton para limpar as cores dos outros botões enquanto que o clicado seta uma diferente cor
            DesignDesign1Dashboard.colecaoButton = new Button[]{ btnDashboard, btnAnalytics, btnCalendario, btnContatos, btnConfig};
            DesignDesign1Dashboard.EfeitoDaNavegaçaoNoMenu(btnDashboard, pnlNav);
            DesignDesign1Dashboard.textDashboard(textBox1);

            this.Region = DesignDesign1Dashboard.ArredondarTela(this, 25, 25);
            panel6.Region = DesignDesign1Dashboard.ArredondarTela(panel6, 50, 50);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DesignDesign1Dashboard.EfeitoDaNavegaçaoNoMenu(btnDashboard, pnlNav);
        }
        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            DesignDesign1Dashboard.EfeitoDaNavegaçaoNoMenu(btnAnalytics, pnlNav);
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            DesignDesign1Dashboard.EfeitoDaNavegaçaoNoMenu(btnCalendario, pnlNav);
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            DesignDesign1Dashboard.EfeitoDaNavegaçaoNoMenu(btnContatos, pnlNav);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            DesignDesign1Dashboard.EfeitoDaNavegaçaoNoMenu(btnConfig, pnlNav);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
