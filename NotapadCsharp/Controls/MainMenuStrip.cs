using System.Windows.Forms;

namespace NotapadCsharp.Controls
{
    class MainMenuStrip : MenuStrip 
    {
        private const string MENU_NAME = "MainMenuStrip";

        private IndexForm _form;
        
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

            HandleCreated += (s, e) =>
            {
                _form = FindForm() as IndexForm;
            };
        }

        public void FileDropDownMenu()
        {
            ToolStripMenuItem fileDropDownMenu = new ToolStripMenuItem("Fichier");
            
            var  newMenu = new ToolStripMenuItem("Nouveau",null,null,Keys.Control | Keys.N);
            var  openMenu = new ToolStripMenuItem("Ouvrir...",null,null,Keys.Control | Keys.O);
            var  saveMenu = new ToolStripMenuItem("Enregistrer",null,null,Keys.Control | Keys.S);
            var  saveAsMenu = new ToolStripMenuItem("Enregistrer sous..",null,null,Keys.Control | Keys.Shift | Keys.N);
            var  quitMenu = new ToolStripMenuItem("Quitter",null,null,Keys.Alt | Keys.F4);
            newMenu.Click += (s, e) =>
            {
                var tabControl = _form.MaintabControl;
                var tabPagesCount = tabControl.TabPages.Count;
                var fileName = $"sans titre {tabPagesCount + 1}";

                var newTabPage = new TabPage(fileName);
                tabControl.TabPages.Add(newTabPage);
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
                if (_form.CurrentRtb.CanUndo) _form.CurrentRtb.Undo();
            };
            
            restorMenu.Click += (s, e) =>
            {
                if (_form.CurrentRtb.CanRedo) _form.CurrentRtb.Redo();
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
                _fontDialog.Font = _form.CurrentRtb.Font;
                _fontDialog.ShowDialog();

                _form.CurrentRtb.Font = _fontDialog.Font;
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
            var zoomReset = new ToolStripMenuItem("Zoom Reset",null,null,Keys.Control | Keys.Divide);

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
                if (_form.CurrentRtb.ZoomFactor < 33F)
                {
                    _form.CurrentRtb.ZoomFactor += 0.2F;
                }
            };
            zoomOut.Click += (s, e) =>
            {
                if (_form.CurrentRtb.ZoomFactor < 7F)
                {
                    _form.CurrentRtb.ZoomFactor -= 0.2F;
                }
            };
            
            zoomReset.Click += (s, e) =>
            {
                _form.CurrentRtb.ZoomFactor = 1F;
            };
            zoomDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{zoomIn,zoomOut,zoomReset});
            viewDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{alwaysOnTopMenu,zoomDropDownMenu});
           
            Items.Add(viewDropDownMenu);
        }
    }
}