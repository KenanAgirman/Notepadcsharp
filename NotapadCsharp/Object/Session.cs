using System;
using System.Collections.Generic;
using System.IO;

namespace NotapadCsharp.Object
{
    public class Session
    {
        
        private const string FILENAME = "session.xml";

        private static string _applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string _applicationPath= Path.Combine(_applicationDataPath,"Notapad.Net");

        public string FileNamme { get; } = Path.Combine(_applicationPath, FILENAME);

        public int ActiveIndex { get; set; } = 0; 

        public List<TextFile> TextFiles  { get; set; } = new List<TextFile>();
    }
}