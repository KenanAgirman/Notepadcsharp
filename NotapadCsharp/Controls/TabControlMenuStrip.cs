using System;
using System.Windows.Forms;

namespace NotapadCsharp.Controls
{
    public class TabControlMenuStrip:ContextMenuStrip
    {
        private const string NAME = "TabControlMenuStrip";

        public TabControlMenuStrip()
        {
            Name = NAME;
            Console.WriteLine("je suis passé ici");
            var closetab = new ToolStripMenuItem("Fermer");
            var closeAllTab = new ToolStripMenuItem("Fermer Sauf fichier");
            var openFile = new ToolStripMenuItem("Open In");
            Items.AddRange(new ToolStripItem[]{closetab,closeAllTab,openFile});

        }
    }
}