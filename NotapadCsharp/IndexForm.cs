using System.Windows.Forms;
using NotapadCsharp.Controls;
using NotapadCsharp.Object;

namespace NotapadCsharp
{
    public partial class IndexForm : Form
    {
    public static RichTextBox RichTextBox;
        public IndexForm()
        {
            InitializeComponent();
            var mainMenuStrip = new MainMenuStrip();
            var mainMinTabControl = new MainTabControl();
            RichTextBox = new CustomRichTextBox();
            
            Controls.Add(mainMenuStrip);
            
            mainMinTabControl.TabPages.Add("Onglet 1");
            mainMinTabControl.TabPages[0].Controls.Add(RichTextBox);

            TextFile file = new TextFile("c:/test.txt");
            Controls.AddRange(new Control[] { mainMinTabControl, mainMenuStrip });
        }
    }
}