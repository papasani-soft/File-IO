using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsTextWriter
    {
        public void CreateTextWriter()
        {
            using (TextWriter writer = File.CreateText("f:\\f.txt"))
            {
                writer.WriteLine("Hello C#");
                writer.WriteLine("C# File Handling by JavaTpoint");
            }
            Console.WriteLine("Data written successfully...");
        }
    }
}
