using System;
using System.IO;

namespace xv2savdec
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && File.Exists(args[0]))
            {
                Xv2SavFile save = new Xv2SavFile();
                
                string filePath = args[0];
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(filePath);
                if (extension == ".dat")
                {
                    save.Load(filePath);
                }
                else if (fileName.Contains(".dec.sav"))
                {
                    save.Save(filePath);
                }
                else 
                    Console.WriteLine("Wrong file or invalid usage\nDrop your 'savefile1.dat' or 'savefile1_dec.sav' file onto the program (not the console screen)");
            }
            else
                Console.WriteLine("Wrong file or invalid usage\nDrop your 'savefile1.dat' or 'savefile1_dec.sav' file onto the program (not the console screen)");

            ExitApp(true);
        }

        private static void ExitApp(bool showFinished = false)
        {
            if (showFinished)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

            Environment.Exit(0);
        }

    }
}
