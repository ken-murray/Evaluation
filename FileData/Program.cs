using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ThirdPartyTools;

namespace FileData
{
    // Ken Murray - technical project assessment 

    public static class Program
    {
        static FileDetails _fileDetails = new FileDetails();
        
        public static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                if (IsVersion(args[0]))
                {
                    Console.WriteLine(_fileDetails.Version(args[1]));
                }
                else if (IsSize(args[0]))
                {
                    Console.WriteLine(_fileDetails.Size(args[1]));
                }
            }
            else
            {
                Console.WriteLine("Error: Two parameters required.");
            }

            Console.WriteLine("Press any key to finish.");
            Console.ReadKey();
        }

        //Made public for integration tests - could use reflection to access private methods
        public static bool IsVersion(string arg0)
        {
            if (   arg0.StartsWith("-v")
                || arg0.StartsWith("--v")
                || arg0.StartsWith("/v")
                || arg0.StartsWith("--version"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsSize(string arg0)
        {
            if (arg0.StartsWith("-s")
                || arg0.StartsWith("--s")
                || arg0.StartsWith("/s")
                || arg0.StartsWith("--size"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
