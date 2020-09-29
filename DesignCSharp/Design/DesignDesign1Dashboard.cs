using DesignCSharp.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignCSharp.Design
{

    class DesignDesign1Dashboard
    {
        //===================================== BORDA ARREDONDADA ======================================//

        /* 
          * Importa uma DLL usada na biblioteca grafica do windows e usa seu método externo CreateRoundRectRgn.
          * Depois seta a Region do Form pelo método FromHrgn passando as propriedades do CreateRoundRectRgn
          */

        /*
         * Gdi32.dll é um arquivo de biblioteca de vínculo dinâmico do Windows , que é um formato de arquivo que contém instruções de programação que podem ser compartilhados pelo Windows 
         * e software compatível com Windows. 
         * 
         * Esta dll particular. É usado pelo Device Interface do Windows gráfica para criar objetos 2-D no visor. 
         */

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //O modificador extern é usado para declarar um método implementado externamente. 
        //Um uso comum do modificador extern é com o atributo DllImport quando você está usando serviços Interop para chamar código não gerenciado. 
        //Nesse caso, o método também deve ser declarado como static.

        private static extern IntPtr CreateRoundRectRgn(
            int nLeftReact,
            int nTopReact,
            int nRightReact,
            int nBottomElipse,
            int nWidthElipse,
            int nHeightElipse);

        public static Region ArredondarTela(Control componente, int Width, int Height)
        {
            return System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, componente.Width, componente.Height, Width, Height)); ;
        }

      

        //===================================== EFEITO NOS BOTÕES DO MENU ======================================//
        public static Button[] colecaoButton;

        /*
         *  AO CLICAR, DAR EFEITO AO BOTÃO SELECIONADO
         *  @param button: espera os botões do menu do formulario para seta-los com as propriedades de cor
         *  @param pnlNav: espera o panel do indicador do botão 
         */
        public static void EfeitoDaNavegaçaoNoMenu(Button button, Panel pnlNav)
        {
            pnlNav.Visible = true;
            pnlNav.Height = button.Height; //seta a altura do panel de navegação para ficar do mesmo tamanho do botão 
            pnlNav.Top = button.Top; //passa para o pnlNav a localização da altura (Y) (...) em relação ao topo (pra cima)
            pnlNav.Left = button.Left; //passa para o pnlNav a localização da largura (X) em relação ao lado


            foreach (Button b in colecaoButton)
            {
                if (button.GetHashCode() != b.GetHashCode()) //todos que forem diferentes do botão corrente, ficam...
                    b.BackColor = Color.FromArgb(24, 30, 54);
            }

            button.BackColor = Color.FromArgb(46, 51, 73);
            text.Text = "Digite aqui...";
    }



        //===================================== TEXT ======================================//

        public static TextBox text = new TextBox();
        public static void textDashboard(TextBox text2)
        {
            text = text2;
            text.Click += new EventHandler(textEventClique);
        }

        private static void textEventClique(object sender, EventArgs e)
        {
            text.Text = String.Empty;
        }

    }
}
