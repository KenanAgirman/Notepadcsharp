using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NotapadCsharp.Controls
{
    class MainMenuStrip : MenuStrip 
    {
        private const string MENU_NAME = "MainMenuStrip";
        private FontDialog _fontDialog;
        
        public MainMenuStrip()
        {
            _fontDialog = new FontDialog();
            Name = MENU_NAME ;
            Dock = DockStyle.Top;
            FileDropDownMenu();
            EditDropDownMenu();
            FormatDropDownMenu();
            ViewDropDownMenu();
        }

        public void FileDropDownMenu()
        {
            ToolStripMenuItem fileDropDownMenu = new ToolStripMenuItem("Fichier");
            
            var  newMenu = new ToolStripMenuItem("Nouveau",null,null,Keys.Control | Keys.N);
            var  openMenu = new ToolStripMenuItem("Ouvrir...",null,null,Keys.Control | Keys.O);
            var  saveMenu = new ToolStripMenuItem("Enregistrer",null,null,Keys.Control | Keys.S);
            var  saveAsMenu = new ToolStripMenuItem("Enregistrer sous..",null,null,Keys.Control | Keys.Shift | Keys.N);
            var  quitMenu = new ToolStripMenuItem("Quitter",null,null,Keys.Alt | Keys.F4);
            quitMenu.Click += (s, e) =>
            {
                
            };
            fileDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{newMenu,openMenu,saveAsMenu,saveMenu,quitMenu});
            Items.Add(fileDropDownMenu);
        }

        public void EditDropDownMenu()
        {
            var editDropDownMenu = new ToolStripMenuItem("Edition");
            
            var  cancelMenu = new ToolStripMenuItem("Annuler",null,null,Keys.Control | Keys.N);
            var  restorMenu = new ToolStripMenuItem("Restaurer",null,null,Keys.Control | Keys.O);
            cancelMenu.Click += (s, e) =>
            {
                if (IndexForm.RichTextBox.CanUndo) IndexForm.RichTextBox.Undo();
            };
            
            restorMenu.Click += (s, e) =>
            {
                if (IndexForm.RichTextBox.CanRedo) IndexForm.RichTextBox.Redo();
            };
            editDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{cancelMenu,restorMenu});
            Items.Add(editDropDownMenu);
        }
        
        public void FormatDropDownMenu()
        {
            var formatDropDownMenu = new ToolStripMenuItem("Format");
            
            var  policelMenu = new ToolStripMenuItem("Police");
            
            policelMenu.Click += (s, e) =>
            {
                _fontDialog.Font = IndexForm.RichTextBox.Font;
                _fontDialog.ShowDialog();

                IndexForm.RichTextBox.Font = _fontDialog.Font;
            };
            
            formatDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{policelMenu});
            Items.Add(formatDropDownMenu);
        }
        
        public void ViewDropDownMenu()
        {
            var viewDropDownMenu = new ToolStripMenuItem("Affichage");
            
            var  alwaysOnTopMenu = new ToolStripMenuItem("Toujours devant");
            var  zoomDropDownMenu = new ToolStripMenuItem("Zoom");
            
            var zoomIn = new ToolStripMenuItem("Zoom avant",null,null,Keys.Control | Keys.Add);
            var zoomOut = new ToolStripMenuItem("Zoom arrière",null,null,Keys.Control | Keys.Subtract);
            var zoomReset = new ToolStripMenuItem("Zoom arrière",null,null,Keys.Control | Keys.Divide);

            zoomIn.ShortcutKeyDisplayString = "Ctrl+Num + ";
            zoomOut.ShortcutKeyDisplayString = "Ctrl+Num - ";
            zoomReset.ShortcutKeyDisplayString = "Ctrl+Num /";

            alwaysOnTopMenu.Click += (s, e) =>
            {
                //MessageBox.Show(alwaysOnTopMenu.Checked.ToString());
                if (alwaysOnTopMenu.Checked)
                {
                    alwaysOnTopMenu.Checked = false;
                    Program.IndexForm.TopMost = false;
                }else alwaysOnTopMenu.Checked = true;
            };
            zoomIn.Click += (s, e) =>
            {
                if (IndexForm.RichTextBox.ZoomFactor < 33F)
                {
                    IndexForm.RichTextBox.ZoomFactor += 0.2F;
                }
            };
            zoomOut.Click += (s, e) =>
            {
                if (IndexForm.RichTextBox.ZoomFactor < 7F)
                {
                    IndexForm.RichTextBox.ZoomFactor -= 0.2F;
                }
            };
            
            zoomReset.Click += (s, e) =>
            {
                IndexForm.RichTextBox.ZoomFactor = 1F;
            };
            zoomDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{zoomIn,zoomOut,zoomReset});
            viewDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{alwaysOnTopMenu,zoomDropDownMenu});
           
            Items.Add(viewDropDownMenu);
        }
    }
}