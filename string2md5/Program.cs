using System;
using System.IO;

namespace string2md5
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                string[] arguments = Environment.GetCommandLineArgs();
                string name;
                if (arguments.Length > 0)
                {
                    name = Path.GetFileNameWithoutExtension(arguments[0]);
                }
                else
                {
                    name = "string2md5";
                }

                Console.Error.WriteLine("Usage: " + name + " string");
                return -1;
            }

            string input = args[0];
            string output = MD5Generation.GetMD5FromString(input);
            Console.WriteLine(output);
            return 0;
        }
    }
}
