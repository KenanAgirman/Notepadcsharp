using System.Windows.Forms;

namespace NotapadCsharp.Controls
{
    class MainMenuStrip : MenuStrip 
    {
        public MainMenuStrip()
        {
            Name = "MainMenuStrip";
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

            fileDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{newMenu,openMenu,saveAsMenu,saveMenu,quitMenu});
            Items.Add(fileDropDownMenu);
        }

        public void EditDropDownMenu()
        {
            var editDropDownMenu = new ToolStripMenuItem("Edition");
            
            var  cancelMenu = new ToolStripMenuItem("Annuler",null,null,Keys.Control | Keys.N);
            var  restorMenu = new ToolStripMenuItem("Restaurer",null,null,Keys.Control | Keys.O);

            editDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{cancelMenu,restorMenu});
            Items.Add(editDropDownMenu);
        }
        
        public void FormatDropDownMenu()
        {
            var formatDropDownMenu = new ToolStripMenuItem("Format");
            
            var  policelMenu = new ToolStripMenuItem("Police");

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
            
            zoomDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{zoomIn,zoomOut,zoomReset});
            viewDropDownMenu.DropDownItems.AddRange(new ToolStripItem[]{alwaysOnTopMenu,zoomDropDownMenu});
           
            Items.Add(viewDropDownMenu);
        }
    }
}