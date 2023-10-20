using System.Windows.Forms;
using NotapadCsharp.Controls;
using NotapadCsharp.Object;

namespace NotapadCsharp
{
    public partial class IndexForm : Form
    {
        public  RichTextBox CurrentRtb;
        public TabControl MaintabControl;

        public IndexForm()
        {
            InitializeComponent();
            var mainMenuStrip = new MainMenuStrip();
            
            CurrentRtb = new CustomRichTextBox();
            Controls.Add(mainMenuStrip);

            MaintabControl = new MainTabControl(); // Créez l'instance de MaintabControl ici
        
            MaintabControl.TabPages.Add("Onglet 1");
            MaintabControl.TabPages[0].Controls.Add(CurrentRtb);

            TextFile file = new TextFile("c:/test.txt");

            Controls.AddRange(new Control[] { MaintabControl, mainMenuStrip });
        }
    }

}