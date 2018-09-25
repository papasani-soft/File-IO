using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsStringReader
    {
        public void StringReaderMethod()
        {
            StringWriter str = new StringWriter();
            str.WriteLine("Hello, this message is read by StringReader class");
            str.Close();
            // Creating StringReader instance and passing StringWriter  
            StringReader reader = new StringReader(str.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
