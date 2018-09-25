using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsTextReader1
    {
        public void CreateTextReader()
        {
            using (TextReader tr = File.OpenText("f:\\f.txt"))
            {
                Console.WriteLine(tr.ReadLine());
            }
        }
    }
}
