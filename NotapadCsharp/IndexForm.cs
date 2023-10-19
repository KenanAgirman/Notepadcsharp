using System.Windows.Forms;
using NotapadCsharp.Controls;

namespace NotapadCsharp
{
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
            MainMenuStrip mainMenuStrip = new MainMenuStrip();
            Controls.Add(mainMenuStrip);
        }
    }
}