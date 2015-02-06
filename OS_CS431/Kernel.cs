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

        List<File> Flist = new List<File>();
        String[] UserInput;
        

        protected override void Run()
        {

            Console.Write("C: \\> ");           // dos command set i
            var input = Console.ReadLine();     // readers user input
            UserInput = input.Split(' ');       // splits user imput to grab first word
            
            if(UserInput[0].CompareTo("create") == 0)
            {
                string[] fileNameSplit = UserInput[1].Split('.');
                Console.WriteLine("Creating Doc");

                var lineCounter = 1;
                Boolean nextLine = true;
                List<String> FileText = new List<string>();
                do
                {
                    Console.Write(lineCounter + ". ");
                    var inputText = Console.ReadLine();
                    FileText.Add(inputText);
                    if (inputText.CompareTo("save") == 0)
                    {
                        nextLine = false;
                        Console.WriteLine("** File Saved **");
                    }
                    lineCounter++;


                } while (nextLine);
                
               Flist.Add(new File(fileNameSplit[0],fileNameSplit[1],FileText));

               Console.WriteLine(Flist[0].getFileName() + "." + Flist[0].getFileExt() + " File Date: " + Flist[0].getFileDate() + " File Size: " + Flist[0].getFileSize());


              
            }
            else
            {
                Console.WriteLine("Invalid command");
            }

         
            
        }
    }
}
