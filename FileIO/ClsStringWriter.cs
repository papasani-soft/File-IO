using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsStringWriter
    {
        public void StringMethod()
        {
            string text = "Hello, Welcome to biz \n" +
               "It is nice place. \n" +
               "It provides technical knowledge";
            // Creating StringBuilder instance  
            StringBuilder sb = new StringBuilder();
            // Passing StringBuilder instance into StringWriter  
            StringWriter writer = new StringWriter(sb);
            // Writing data using StringWriter  
            writer.WriteLine(text);
            writer.Flush();
            // Closing writer connection  
            writer.Close();
            // Creating StringReader instance and passing StringBuilder  
            StringReader reader = new StringReader(sb.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
