using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotapadCsharp.Controls
{
    public class CustomRichTextBox:RichTextBox
    {
        private const String NAME = "RtbTextFileContents";
        public CustomRichTextBox()
        {
            Name = NAME;
            AcceptsTab = true;
            Font = new Font("Times new roman",12.0F,FontStyle.Regular);
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;

            ContextMenuStrip = new RichTextMenuBox(this);
            Console.WriteLine("ContextMenuStrip " + ContextMenuStrip);
        }
    }
}