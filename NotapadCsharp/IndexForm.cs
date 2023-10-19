using System.Windows.Forms;
using NotapadCsharp.Controls;

namespace NotapadCsharp
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            var mainMenuStrip = new MainMenuStrip();
            var mainMinTabControl = new MainTabControl();
            Controls.Add(mainMenuStrip);
            
            mainMinTabControl.TabPages.Add("Onglet 1");

            Controls.AddRange(new Control[] { mainMinTabControl, mainMenuStrip });
        }
    }
}