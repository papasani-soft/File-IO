using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsFileStream2
    {
        public void Write()
        {
            FileStream f = new FileStream("f:\\a.txt", FileMode.OpenOrCreate);
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
        }
    }
}
