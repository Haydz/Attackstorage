using System;
using System.IO;
 
namespace CreateTextFile
{

class TextFileWriter
    {
        static void Main(string[] args)
        {
			 Console.WriteLine("Hello World!");  
            // create a writer and open the file
            TextWriter tw = new StreamWriter("date.txt");
 
            // write a line of text to the file
            tw.WriteLine(DateTime.Now);
 
            // close the stream
            tw.Close();
        }
    }
}