using System;
using System.IO;

/* by mgeissle
 * V1 File Name from a Folder to a List
 * 
 * V2 Ideas:
 * User can choose with or without Extension
 * User can choose txt or csv file
 * Folder and Sub-Folder in one list
 * 
 *
 */

namespace ListFromFolder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("***********************************************************\n" +
                                  "************** File-Name from Folder to List v1************\n" +
                                  "***********************************************************\n");
                Console.Write("Insert Path (with copy and paste): ");
                string dirPath = Console.ReadLine();
                FileReader fileReader = new FileReader(dirPath);
                fileReader.Print();
                string newpath = Path.Combine(dirPath, "_List.txt");
                fileReader.SaveToFile(newpath);
                Console.WriteLine();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
