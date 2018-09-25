using System;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter program no. to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ClsFileStream obj1 = new ClsFileStream();
                    obj1.CreateFileStream();
                    break;
                case 2:
                    ClsFileStream1 obj2 = new ClsFileStream1();
                    obj2.CreateFileStream();
                    break;
                case 3:
                    ClsFileStream2 obj3 = new ClsFileStream2();
                    obj3.Write();
                    break;
                case 4:
                    ClsStreamWrite obj4 = new ClsStreamWrite();
                    obj4.StreamWrite();
                    break;
                case 5:
                    ClsStreamRead obj5 = new ClsStreamRead();
                    obj5.StreamRead();
                    break;
                case 6:
                    ClsStreamRead obj6 = new ClsStreamRead();
                    obj6.StreamRead();
                    break;
                case 7:
                    ClsTextWriter obj7 = new ClsTextWriter();
                    obj7.CreateTextWriter();
                    break;
                case 8:
                    ClsTextReader obj8 = new ClsTextReader();
                    obj8.CreateTextReader();
                    break;
                case 9:         
                    ClsTextReader1 obj9 = new ClsTextReader1();
                    obj9.CreateTextReader();
                    break;
                case 10:
                    ClsBinaryWriter obj10 = new ClsBinaryWriter();
                    obj10.CreateBinaryWriter();
                    break;
                case 11:
                    ClsBinaryReader obj11 = new ClsBinaryReader();
                    obj11.WriteBinaryFile();
                    obj11.ReadBinaryFile();
                    break;
                case 12:
                    ClsStringWriter obj12 = new ClsStringWriter();
                    obj12.StringMethod();
                    break;
                case 13:
                    ClsStringReader obj13 = new ClsStringReader();
                    obj13.StringReaderMethod();
                    break;
                case 14:
                    ClsFileInfo obj14 = new ClsFileInfo();
                    obj14.CreateFileInfo();
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
