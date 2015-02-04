using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace OS_CS431
{
    
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            File F1 = new File();
            Console.Write("Input: ");
            var input = Console.ReadLine();
            F1.setFileName(input);
            Console.Write("File name is " + F1.getFileName());
            //Console.WriteLine(input);

            


        }
    }
}
