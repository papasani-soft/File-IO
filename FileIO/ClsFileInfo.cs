using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsFileInfo
    {
        public void CreateFileInfo()
        {
            try
            {
                // Specifying file location  
                string loc = "F:\\abc.txt";
                // Creating FileInfo instance  
                FileInfo file = new FileInfo(loc);
                // Creating an empty file  
                file.Create();
                Console.WriteLine("File is created Successfuly");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}
