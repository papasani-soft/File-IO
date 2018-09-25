using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsStreamRead
    {
        public void StreamRead()
        {
            FileStream f = new FileStream("f:\\a.txt",FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);
            string line = s.ReadLine();
            Console.WriteLine(line);
            s.Close();
            f.Close();     
        }
    }
}
