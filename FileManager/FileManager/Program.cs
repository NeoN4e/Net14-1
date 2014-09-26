using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleGui;

namespace ProgramFileManager
{
    class Program
    {
        static FilleMannager fm = new FilleMannager();

        static void Main(string[] args)
        {

            do
            {
                try
                {
                    inCommand();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            } while (true);
        }

        static void inCommand()
        {
            do
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-=Введите комманду (? - список доступных комманд)=-");
                Console.ResetColor();
                fm.Command = Console.ReadLine();
            } while (true);
        }
    }

    
    

    class FilleMannager
    {
        string SystemMsg 
        {
            set 
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(value);
                Console.ResetColor();
            }
        }

        string currentDir;
        public String CurrentDir 
        { 
            get {return this.currentDir;}
            set 
            {
                Directory.SetCurrentDirectory(value);
                this.currentDir = Directory.GetCurrentDirectory();
                Console.Title = "File Manager (" + this.currentDir + ")";
            } 
        }

        //public int ComandParametrQty 
        //{
        //    set 
        //    {
        //        if (CommandParametrs.Length < value) throw new CommandExeption("Не достаточно параметров");
        //        if (CommandParametrs.Length > value) throw new CommandExeption("Слишко много параметров");
        //    }
        //}

        //string[] CommandParametrs;

        ////string[] CommandParametrs;
        //public void execute(string cmd)
        //{
        //    string[] CommandParametrs = ((cmd.ToLower()).Trim()).Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries);
        //    this.command = CommandParametrs[0];

        //    switch (command)
        //    {
        //        case "?":
        //            this.ComandParametrQty = 1;
        //            Console.WriteLine(@"""?"" - Справка");
        //            Console.WriteLine(@"""list"" - посмотреть содержимое текущего каталога ");
        //            Console.WriteLine(@"""CreateFile"" - создание файла ");
        //            Console.WriteLine(@"""DeleteFile"" - удаление файла ");

        //            Console.WriteLine(@"""CreateDir"" - создание каталога ");
        //            Console.WriteLine(@"""DeleteDir"" - удаление каталога ");

        //            Console.WriteLine(@"""CD"" - смена текущего каталога ");
        //            break;

        //        case "list":
        //            this.ComandParametrQty = 1;
        //            this.SystemMsg = this.CurrentDir + ":";

        //            //Каталоги
        //            foreach (string item in Directory.GetDirectories(this.CurrentDir))
        //            {
        //                Console.WriteLine("[{0}]", item);
        //            }

        //            //Файлы
        //            foreach (string item in Directory.GetFiles(this.CurrentDir))
        //            {
        //                Console.WriteLine(item);
        //            }
        //            break;
        //        case "createfile":
        //            this.ComandParametrQty = 2;
        //            {
        //                this.SystemMsg = "Введите имя файла";
        //                string filename = Console.ReadLine();
        //                (File.Create(filename)).Close();
        //                if (File.Exists(filename))
        //                    this.SystemMsg = "Файл успешно создан";
        //            }
        //            break;

        //        case "deletefile":
        //            this.ComandParametrQty = 2;
        //            {
        //                this.SystemMsg = "Введите имя файла";
        //                string filename = Console.ReadLine();
        //                File.Delete(filename);
        //                if (!File.Exists(filename))
        //                    this.SystemMsg = "Файл успешно удален";
        //            }
        //            break;

        //        case "createdir":
        //            this.ComandParametrQty = 2;
        //            {
        //                this.SystemMsg = "Введите имя Каталога";
        //                string filename = Console.ReadLine();
        //                Directory.CreateDirectory(filename);
        //                if (Directory.Exists(filename))
        //                    this.SystemMsg = "Каталог успешно создан";
        //            }
        //            break;

        //        case "deletedir":
        //            this.ComandParametrQty = 2;
        //            {
        //                this.SystemMsg = "Введите имя Каталога";
        //                string filename = Console.ReadLine();
        //                Directory.Delete(filename, true);
        //                if (!Directory.Exists(filename))
        //                    this.SystemMsg = "Каталог успешно удален";
        //            }
        //            break;

        //        case "cd":
        //            this.ComandParametrQty = 2;
        //            {
        //                this.SystemMsg = "Введите имя Каталога";
        //                this.CurrentDir = Console.ReadLine();
        //            }
        //            break;


        //        default: throw new CommandExeption("Недопустимая комманда " + command);
        //    }
        //}


        string command=""; 
        public string Command 
        {
            get { return this.command; }
            set
            {
                
                string inCommand = (value.ToLower()).Trim();
                string parametr;

                this.LOG.WriteLine(inCommand);

                int pointer = inCommand.IndexOf(' ');
                if (pointer > 0)
                {
                    this.command = inCommand.Substring(0, pointer);
                    parametr = inCommand.Replace(this.command + " ", "");
                }
                else
                    this.command = inCommand;

                switch (command)
                {
                    case "?":
                        Console.WriteLine(@"""?"" - Справка");
                        Console.WriteLine(@"""list"" - посмотреть содержимое текущего каталога ");
                        Console.WriteLine(@"""CreateFile"" - создание файла ");
                        Console.WriteLine(@"""DeleteFile"" - удаление файла ");

                        Console.WriteLine(@"""CreateDir"" - создание каталога ");
                        Console.WriteLine(@"""DeleteDir"" - удаление каталога ");

                        Console.WriteLine(@"""CD"" - смена текущего каталога ");
                        break;

                    case "list":
                        this.SystemMsg = this.CurrentDir + ":";

                        //Каталоги
                        foreach (string item in Directory.GetDirectories(this.CurrentDir))
                        {
                            Console.WriteLine("[{0}]", item);
                        }

                        //Файлы
                        foreach (string item in Directory.GetFiles(this.CurrentDir))
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "createfile":
                        {
                            this.SystemMsg = "Введите имя файла";
                            string filename = Console.ReadLine();
                            (File.Create(filename)).Close();
                            if (File.Exists(filename))
                                this.SystemMsg = "Файл успешно создан";
                        }
                        break;

                    case "deletefile":
                        {
                            this.SystemMsg = "Введите имя файла";
                            string filename = Console.ReadLine();
                            File.Delete(filename);
                            if (!File.Exists(filename))
                                this.SystemMsg = "Файл успешно удален";
                        }
                        break;

                    case "createdir":
                        {
                            this.SystemMsg = "Введите имя Каталога";
                            string filename = Console.ReadLine();
                            Directory.CreateDirectory(filename);
                            if (Directory.Exists(filename))
                                this.SystemMsg = "Каталог успешно создан";
                        }
                        break;

                    case "deletedir":
                        {
                            this.SystemMsg = "Введите имя Каталога";
                            string filename = Console.ReadLine();
                            Directory.Delete(filename, true);
                            if (!Directory.Exists(filename))
                                this.SystemMsg = "Каталог успешно удален";
                        }
                        break;

                    case "cd":
                        {
                            this.SystemMsg = "Введите имя Каталога";
                            this.CurrentDir = Console.ReadLine();
                        }
                        break;


                    default: throw new CommandExeption("Недопустимая комманда " + command);
                }

            }
        }
        
        StreamWriter LOG; 
        public FilleMannager()
        {
            FileStream fs = new FileStream("FM.log", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            this.LOG = new StreamWriter(fs, Encoding.UTF8);
            this.LOG.AutoFlush = true;

            this.CurrentDir = Directory.GetCurrentDirectory();
        }
    }

    class CommandExeption : ApplicationException
    {
        public CommandExeption(string msg)
            :base(msg)
        { }
    }
}
