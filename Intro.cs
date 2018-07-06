using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningMathFacts
{
    class Intro
    {
        public void introduction()
        {

            Console.WriteLine("(press enter to scroll through this intro)");
            Console.ReadLine();
            Console.WriteLine("You gotta learn your math facts, but this program can make it quick and         painless.");
            Console.ReadLine();
            Console.WriteLine("This program will notice when you have learned a math fact well and stop giving you that one.");
            Console.ReadLine();
            Console.WriteLine("You'll always be working with a pool of 10 math facts.");
            Console.ReadLine();
            Console.WriteLine("It will average your last 4 times on EACH math fact.");
            Console.ReadLine();
            Console.WriteLine("Once you have the average time down to 3 seconds, you're done with that math    fact.");
            Console.ReadLine();
            Console.WriteLine("Don't worry, that's not too hard.");
            Console.ReadLine();
            Console.WriteLine("Then it will take that problem out of the pool, and put a new fact in the pool.");
            Console.ReadLine();
            Console.WriteLine("If you are having extra trouble with one problem, the program will give it to   you more often to help you get it.");
            Console.ReadLine();
            Console.WriteLine("It's important that you don't worry or freak out too much. To help you with     this, the longest that the computer will record is 5 seconds.");
            Console.ReadLine();
            Console.WriteLine("So if you want to take a 30 second break at any time, just do so.");
            Console.ReadLine();
            Console.WriteLine("Because even if you take 90 seconds to answer the question, it will just record it as 5.");
            Console.ReadLine();
            Console.WriteLine("However, if you give the wrong answer, it will record 8 seconds, even if you    answered it very fast.");
            Console.ReadLine();
            Console.WriteLine("Of course correct answers are more important than fast answers.");
            Console.ReadLine();
            Console.WriteLine("So just stay calm and be certain of your answers and the speed will come soon   enough.");
            Console.ReadLine();
            Console.WriteLine("Ready to begin?");
            Console.ReadLine();
        }
        public void levelList()
        {
            Console.WriteLine("LEVELS");
            Console.WriteLine("1-12 Addition");
            Console.WriteLine("13-24 Subtraction");
            Console.WriteLine("25-36 Multiplication");
            Console.WriteLine("37-48 Division");
            Console.WriteLine("49-96 All operations mixed");
        }
    }
}
