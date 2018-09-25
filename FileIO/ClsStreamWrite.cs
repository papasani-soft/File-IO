using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsStreamWrite
    {
        public void StreamWrite()
        {
            FileStream f = new FileStream("f:\\ouput.txt",FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine("hello anji");
            s.Close();
            f.Close();
            Console.WriteLine("file created successfullly...");
        }
    }
}
