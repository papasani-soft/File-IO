using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsFileStream1
    {
        public void CreateFileStream()
        {
            FileStream f = new FileStream("f:\\a.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = "";
            while ((line = s.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s.Close();
            f.Close();
        }
    }
}
