using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           //using (FileStream fs  = new FileStream("1.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite,))
           //{
           //    //fs.Seek(0, SeekOrigin.End);
           //    //string str = "";
           //    //Console.WriteLine("Введите строку");
           //    //str = Console.ReadLine();
           //    //byte[] text = Encoding.UTF8.GetBytes(str);
           //    //fs.Write(text, 0, text.Length);
           //    //fs.Flush();

           //    //fs.Seek(0, SeekOrigin.Begin);
           //    //byte[] txtRead = new byte[fs.Length];
           //    //fs.Read(txtRead, 0, txtRead.Length);
           //    //string strRead = Encoding.UTF8.GetString(txtRead);
           //    //Console.WriteLine(strRead);


           //}

            FileStream fs = new FileStream("1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //fs.Seek(10, SeekOrigin.Current);
            
            //StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            //sw.AutoFlush = true;
                        
            //string str = "";
            //Console.WriteLine("Введите строку");
            //str = Console.ReadLine();

            //sw.Write(str);
            //sw.Dispose();

            //StreamReader sr = new StreamReader(@"1.txt",Encoding.UTF8);
            //Console.WriteLine(sr.ReadToEnd());
            
            //sr.Dispose();

           // BinaryWriter bw = new BinaryWriter(fs);

           // string str = "";
           // Console.WriteLine("Введите строку");
           // str = Console.ReadLine();

           // bw.Write(Convert.ToInt32(str));
           // bw.Flush();
           //// bw.Dispose();

           // fs.Seek(0, SeekOrigin.Begin);
           // BinaryReader br = new BinaryReader(fs);
           // Console.WriteLine(br.ReadInt32());
           // fs.Dispose();

            Console.WriteLine(File.Exists("1.txt"));
            //File.
            //Console.WriteLine(Directory.GetLogicalDrives()[0]);
            //Console.WriteLine(Environment.GetLogicalDrives()[1]);
            //Console.WriteLine(DriveInfo.GetDrives()[2]);

            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Directory.SetCurrentDirectory(@"D:\");
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //Console.WriteLine(File.GetCreationTime("1.txt"));
            //Console.WriteLine(File.GetCreationTimeUtc("1.txt"));
            //Console.WriteLine(File.GetAccessControl("1.txt"));

            //FileInfo f = new FileInfo("1.txt");
            //Console.WriteLine(f.);
            //Console.WriteLine(Directory.GetDirectories(@"..\..")[1]);

            //Console.WriteLine(Directory.GetFiles(Directory.GetCurrentDirectory())[0]);
            //string[] files = Directory.GetFileSystemEntries(Directory.GetCurrentDirectory(),);
            //foreach (string file in files)
            //{ Console.WriteLine(file); }

            //DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            //FileInfo[] fi = di.GetFiles();
            //foreach (FileInfo f in fi)
            //{
            //    Console.Write(""+f.Name+" "+f.LastAccessTime);
            //    Console.WriteLine();
            //}

            Console.WriteLine(Path.GetRandomFileName());
            Console.WriteLine(Path.GetTempPath());
         
            
        }
    }
}
