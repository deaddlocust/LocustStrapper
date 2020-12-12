using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace BootStrapper
{
    class Program
    {
        // There is a lot of useless code here just for the sake of being showy.
        // Source by dead_locust
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string file = Convert.ToString(args[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("LocustStrapper Version 1.1 by dead_locust");
                if (!Directory.Exists(Environment.CurrentDirectory + "/Updated"))
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + "/Updated");
                }
                Console.Title = "LocustStrapper";
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Requesting files from server...");
                System.Threading.Thread.Sleep(2000);
                string name = file.Substring(file.LastIndexOf("/") + 1);
                try
                {
                    Console.WriteLine("Downloading files...");
                    System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Progress: ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    for (int a = 0; a < 12; a++)
                    {
                        int random_number = new Random().Next(100, 500);
                        System.Threading.Thread.Sleep(random_number);
                        Console.Write("▓");
                    }
                    new WebClient().DownloadFile(new Uri(file), Environment.CurrentDirectory + "/Updated/" + name);
                    for (int a = 0; a < 8; a++)
                    {
                        int random_number = new Random().Next(100, 500);
                        System.Threading.Thread.Sleep(random_number);
                        Console.Write("▓");
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Extracting files...");
                    System.Threading.Thread.Sleep(1000);
                    string zipPath = Environment.CurrentDirectory + "/Updated/" + name;
                    string extractPath = Environment.CurrentDirectory;
                    ZipFile.ExtractToDirectory(zipPath, extractPath);
                }
                catch
                { }
                string updatedir = Environment.CurrentDirectory + "/Updated";
                Console.WriteLine("Cleaning up...");
                Directory.Delete(updatedir, true);
                Console.ForegroundColor = ConsoleColor.Green;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Finished.");
                System.Threading.Thread.Sleep(3000);
                Environment.Exit(0);
            }
        }
    }
}
