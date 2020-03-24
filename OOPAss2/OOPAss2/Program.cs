using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPAss2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileCompare.RepoCompare();
            Console.ReadLine();
        }
    }

    class UserInput
    {
        public static string getData(string Filepath)
        {
            string newFile = File.ReadAllText(Filepath); return newFile;
        }
    }

    class FileCompare : UserInput
    {
        static string InputFileA;
        static string InputFileB;
       
        public static void RepoCompare()
        {
            Console.WriteLine("File 1: GitRepositories_1a.txt");
            Console.WriteLine("File 2: GitRepositories_1b.txt");
            Console.WriteLine("File 3: GitRepositories_2a.txt");
            Console.WriteLine("File 4: GitRepositories_2b.txt");
            Console.WriteLine("File 5: GitRepositories_3a.txt");
            Console.WriteLine("File 6: GitRepositories_3b.txt");

            string Ans = "";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($" Which files would you like to compare? (Please make this the exact pathway!): ");
                Ans = Console.ReadLine();
                if (i == 0)
                    InputFileA = getData(Ans);
                else if (i == 1)
                    InputFileB = getData(Ans);
            }

            if (InputFileA == InputFileB)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"File A and File B are the same");
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"File A and File B are different");
                
            }
            Console.WriteLine();

        }
        
        
       
    }
}
