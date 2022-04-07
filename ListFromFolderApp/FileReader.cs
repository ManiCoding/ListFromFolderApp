using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListFromFolder
{
    internal class FileReader
    {   
        // Folder Path
        public string Path { get; set; }
        // rawFiles = DirectoryInfo
        public FileInfo[] rawFiles { get; set; }

        public FileReader(string path)
        {
            Path = path;
            Readfiles(Path); 
        }

        // Read DirectoryInfo to rawFiles
        public void Readfiles(string path) 
        {   
            DirectoryInfo diSearch = new DirectoryInfo(Path);
            rawFiles = diSearch.GetFiles();

        }

        // Write the File-Names to a Txt-File
        public void SaveToFile(string path)
        {   

            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter _writer = new StreamWriter(stream, Encoding.UTF8);

            foreach(FileInfo file in rawFiles)
                _writer.WriteLine(file.Name);

            Console.WriteLine($"\n_List.txt from {Path} created at {DateTime.Now}.");

            // Write instant and close
            _writer.Flush();
            _writer.Close();
            stream.Close();

        }

        // Print the Files to Console
        public void Print()
        {
            Console.WriteLine("\n ***** Files ***** \n");
            foreach(FileInfo file in rawFiles)
                Console.WriteLine(file.Name);
        }
    }
}
