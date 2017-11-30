using ProgrammingBlockchain.Chapters;
using System;

namespace ProgrammingBlockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select the chapter here.             
            var chapter = new Chapter1();

            //call the lesson here.             
            chapter.Lesson4();

            //this will hold the window open for you to read the output.             
            Console.WriteLine("\n\n\nPress enter to continue.");
            Console.ReadLine();
        }
    }
}
