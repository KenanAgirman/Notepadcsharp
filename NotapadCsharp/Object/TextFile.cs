using System;
using System.IO;

namespace NotapadCsharp.Object
{
    public class TextFile
    {
        public String FileName { get; set; }
        
        public String BackupFileName { get; set; }
        public String SafeFileName { get; set; }
        public String SafeBackupFileName { get; set; }
        
        public String Contents { get; set; }


        public TextFile()
        {
            
        }

        public TextFile(String fileName)
        {
            FileName = fileName;
            SafeFileName = Path.GetFileName(fileName);
            
        }
    }
}