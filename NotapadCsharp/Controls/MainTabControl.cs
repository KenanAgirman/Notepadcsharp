using System;
using System.Windows.Forms;

namespace NotapadCsharp.Controls
{
    public class MainTabControl:TabControl
    {
        private const string TAB_CONTROL_NAME = "MainTabControl";
        private ContextMenuStrip _contextMenuStrip;
        
        public MainTabControl()
        {
            Console.WriteLine("Je vais passé ici");
            _contextMenuStrip = new TabControlMenuStrip();
            Name = TAB_CONTROL_NAME;
            ContextMenuStrip = _contextMenuStrip;
            Dock = DockStyle.Fill;
        }
    }
}