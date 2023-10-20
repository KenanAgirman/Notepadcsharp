using System;
using System.Windows.Forms;

namespace NotapadCsharp.Controls
{

    public class RichTextMenuBox:ContextMenuStrip
    {
        private RichTextBox _richTextBox;
        private const string NAME = "RichTextlMenuStrip";

        public RichTextMenuBox(RichTextBox richTextBox)
        {
            Console.WriteLine("_richTextBox : " + _richTextBox);
            _richTextBox = richTextBox;
            Name = NAME;
            Console.WriteLine("Couper");
            var cut = new ToolStripMenuItem("Couper");
            var copy = new ToolStripMenuItem("Coppier");
            var paste = new ToolStripMenuItem("Coller");
            var selectall = new ToolStripMenuItem("Selectionner tout");

            cut.Click += (s, Events) => _richTextBox.Cut();
            copy.Click += (s, Events) => _richTextBox.Copy();
            paste.Click += (s, Events) => _richTextBox.Paste();
            selectall.Click += (s, Events) => _richTextBox.SelectAll();

            Items.AddRange(new ToolStripItem[]{cut,copy,paste,selectall});
        }
    }
}