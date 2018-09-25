using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileIO
{
    class ClsBinaryReader
    {
        public void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("f:\\binaryfile.dat", FileMode.Create)))
            {
                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        public void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("f:\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}
