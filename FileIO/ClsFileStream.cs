using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsFileStream
    {
        public void CreateFileStream()
        {
            FileStream f = new FileStream("f:\\c.txt", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  
            
        }
       
    }
}
