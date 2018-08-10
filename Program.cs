using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningMathFacts
{
    class Program
    {
        static void Main(string[] args)
        {

                
            MFA mfa = new MFA();

            Intro intro = new Intro();
            
            Console.WriteLine("Welcome to Lightning Math Facts!");
            Console.WriteLine("Enter 'i' to read the introduction to this program.)");
            string doIntro = Console.ReadLine();
            if (doIntro == "i" | doIntro == "I")
            {
                intro.introduction();
            }
            

            int [,] MFA = mfa.makeanMFA();  

            

                        
            Console.WriteLine("Which level are you on? (Enter 'l' to see the list of levels.");
            string userLevelInput = Console.ReadLine();
            while (userLevelInput == "l" | userLevelInput == "L" | userLevelInput =="")
            {
                intro.levelList();
                Console.WriteLine("Which level are you on? (Enter 'l' to see the list of levels.");
                userLevelInput = Console.ReadLine();
            }

            int mathLevel = Convert.ToInt16(userLevelInput);
            int levelLength = 12;
            int levelUpMark = levelLength;
            int nextMFAProblem = 11;
            bool stillWorking = true;
            int[,] workingOn = new int[11, 2] { { 1, 30 }, { 2, 30 }, { 3, 30 }, { 4, 30 }, { 5, 30 }, { 6, 30 }, { 7, 30 }, { 8, 30 }, { 9, 30 }, { 10, 30 }, { 0, 0 } };
            int kills = 0;
            if (mathLevel >= 2)
            {
                int problemJumper = (mathLevel - 1) * levelLength;
                workingOn = new int[11, 2] { { 1+ problemJumper, 30 }, { 2 + problemJumper, 30 }, { 3 + problemJumper, 30 }, { 4 + problemJumper, 30 }, { 5 + problemJumper, 30 }, { 6 + problemJumper, 30 }, { 7 + problemJumper, 30 }, { 8 + problemJumper, 30 }, { 9 + problemJumper, 30 }, { 10 + problemJumper, 30 }, { 0, 0 } };
                nextMFAProblem = problemJumper + 1;
                levelUpMark = mathLevel * levelLength;
            }
                for (int loop = 0; stillWorking; loop++)
                {
                    
                    for (int i = 0; i < 10; i++)
                    {
                        workingOn[i, 1] = MFA[workingOn[i, 0], 11];
                    }
                    workingOn = mfa.problemPicker(workingOn);  //picks the problem from workingOn array.
                    int MFAProblem = workingOn[10, 0];
                    int k = workingOn[10, 1];
        
                    int lagInt = mfa.questionAsker(MFA[MFAProblem, 3], MFA[MFAProblem, 4], MFA[MFAProblem, 5], MFA[MFAProblem, 6]); //asks user the question and captures the lag for it.
                    decimal lagDec = (Convert.ToDecimal(lagInt))/10;
                    MFA[MFAProblem, 10] = MFA[MFAProblem, 9];  //updates the lags on that problem.
                    MFA[MFAProblem, 9] = MFA[MFAProblem, 8];
                    MFA[MFAProblem, 8] = MFA[MFAProblem, 7];
                    MFA[MFAProblem, 7] = lagInt;
                    MFA[MFAProblem, 11] = (MFA[MFAProblem, 7] + MFA[MFAProblem, 8] + MFA[MFAProblem, 9] + MFA[MFAProblem, 10])/4;

                    //Handles missed problems.
                    decimal aveLagDec = Convert.ToDecimal(MFA[MFAProblem, 11])/10;  
                    if (lagDec == 8)
                    {
                        Console.WriteLine("Oops. That answer should've been " + MFA[MFAProblem, 6] + ". But no big deal!");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to get the next problem.");
                        Console.ReadLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("That time: " + lagDec + "   Average: " + aveLagDec);

                    // "Kills" the killed math fact.
                    if (MFA[MFAProblem, 11] < 30)  
                    {
                        kills++;
                        Console.WriteLine();
                        Console.WriteLine("You killed that one! Total kills today: " + kills);
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        workingOn[k, 0] = nextMFAProblem;
                        workingOn[k, 1] = MFA[nextMFAProblem, 11];
                        nextMFAProblem++;
                        int min = Enumerable.Range(0, 4).Select(i => workingOn[i, 0]).Min();
                        // Console.WriteLine(min); This line shows what the lowest-numbered math fact is with each iteration.  
                        while ((min) > levelUpMark)
                        {
                        Console.WriteLine("YOU BEAT LEVEL " + (levelUpMark) / levelLength + "!!!!!!");
                        levelUpMark = levelUpMark + levelLength;
                        }
                    }
                    Console.WriteLine();
                






            }
        }
    }
}
