using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
 */

class ReadFileContents
{
    static void Main()
    {
        //string fileName = "FileName.txt";
        //string path = @"C:\Users\(username)\Desktop\FileName.txt";
        Console.WriteLine("Please enter the file name:");
        string fileName = Console.ReadLine();
        Console.WriteLine("Please enter its path:");
        string path = Console.ReadLine();

        try
        {
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
        }
        catch (FileNotFoundException)
        {
            Console.Error.WriteLine("Can not find file {0}.", fileName);
        }
        catch (IOException)
        {
            Console.Error.WriteLine("Can not read the file {0}.", fileName);
        }
    }
}