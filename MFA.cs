using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningMathFacts
{
    class MFA
    {
        public int[,] makeanMFA()
        {
            // make the empty array
            int[,] MFA = new int[576,19 ];

            // instantiate FindAnswer
            FindAnswer calc = new FindAnswer();

            // add the addtion facts to the math fact array
            // Data columns:
            // 0: ID number (same as row number)
            // 1: Status number (10, not started on. 9-1 varying degrees of mastery. 0, mastered.)
            // 2: Total number of times the question has been asked.
            // 3: First argument
            // 4: Operation  (0 is addition, 1 subtraction, 2 mult., 3 div.)
            // 5: Second argument
            // 6: Answer
            // 7: Most recent time on problem. (in tenths of seconds)
            // 8: Next most recent time
            // 9: Third most recent time
            // 10: Fourth most recent time
            // 11: Fifth times
            // to be added:
            // 12: Lifetime "asks"  
            // 13: Lifetime kills.
            // 14: Perma-killed (0 still alive. 1 perma killed.)(Answered it SO fast so as to achieve a TTK of 2.)
            // 15: Most recent TTK (Times to kill)
            // 16: Second most recent TTK
            // 17: Third most recent TTK
            // 18: Fourth most recent TTK  


            int j = 1, k=0;
            for (int i = 1; i <= 144; i++)
            {
                if (k<=12)
                { k++; }
                if (k>12) {j++; k = 1; }
                MFA[i, 0] = i; //Sets the id number.  Perhaps redundant.
                MFA[i, 3] = j; //Sets the first argument.
                MFA[i, 4] = 0; //Sets the operation (0 is addition, 1 subtraction, 2 mult., 3 div.)
                MFA[i, 5] = k; //Sets the second argument.
                MFA[i, 6] = calc.mathIt(MFA[i, 3], MFA[i, 4], MFA[i, 5]);   //Calculates answer.
                MFA[i, 7] = 40; MFA[i, 8] = 40; MFA[i, 9] = 40; MFA[i, 10] = 40; MFA[i, 11] = 60; // Set starting times for each fact.
            }


            // add the subtraction facts to the math fact array

            j = 1; k = 0;
            for (int i = 145; i <= 288; i++)
            {
                if (k <= 12)
                { k++; }
                if (k > 12) { j++; k = 1; }
                MFA[i, 0] = i;                  //Sets the id number.  Perhaps redundant.
                MFA[i, 3] = MFA[i-144, 6];      //Sets the first argument, "answer" to corresponding addition fact.
                MFA[i, 4] = 1;                  //Sets the operation (0 is addition, 1 subtraction, 2 mult., 3 div.)
                MFA[i, 5] = MFA[i-144, 3];      //Sets the second argument, "Arg1" from corresponding addition fact.
                MFA[i, 6] = calc.mathIt(MFA[i, 3], MFA[i, 4], MFA[i, 5]);  //Calculates answer.
                MFA[i, 7] = 60; MFA[i, 8] = 60; MFA[i, 9] = 60; MFA[i, 10] = 60; MFA[i, 11] = 60; // Set starting times for each fact.
            }

            // add the multiplication facts

            j = 1; k = 0;
            for (int i = 289; i <= 432; i++)
            {
                if (k <= 12)
                { k++; }
                if (k > 12) { j++; k = 1; }
                MFA[i, 0] = i; //Sets the id number.  Perhaps redundant.
                MFA[i, 3] = j; //Sets the first argument.
                MFA[i, 4] = 2; //Sets the operation (0 is addition, 1 subtraction, 2 mult., 3 div.)
                MFA[i, 5] = k; //Sets the second argument.
                MFA[i, 6] = calc.mathIt(MFA[i, 3], MFA[i, 4], MFA[i, 5]);   //Calculates answer.
                MFA[i, 7] = 60; MFA[i, 8] = 60; MFA[i, 9] = 60; MFA[i, 10] = 60; MFA[i, 11] = 60; // Set starting times for each fact.

            }
            // add the division facts

            j = 1; k = 0;
            for (int i = 433; i <= 575; i++)
            {
                if (k <= 12)
                {
                    k++;
                }
                if (k > 12) { j++; k = 1; }
                MFA[i, 0] = i;                  //Sets the id number.  Perhaps redundant.
                MFA[i, 3] = MFA[i - 144, 6];      //Sets the first argument, "answer" to corresponding multiplication fact.
                MFA[i, 4] = 3;                  //Sets the operation (0 is addition, 1 subtraction, 2 mult., 3 div.)
                MFA[i, 5] = MFA[i - 144, 3];      //Sets the second argument, "Arg1" from corresponding multipliction fact.
                MFA[i, 6] = calc.mathIt(MFA[i, 3], MFA[i, 4], MFA[i, 5]);  //Calculates answer.
                MFA[i, 7] = 60; MFA[i, 8] = 60; MFA[i, 9] = 60; MFA[i, 10] = 60; MFA[i, 11] = 60; // Set starting times for each fact.
            }
            int[] rndmSet = { 576, 322, 83, 280, 365, 563, 465, 428, 36, 210, 239, 264, 98, 92, 349, 58, 9, 40, 318, 68, 259, 440, 17, 288, 425, 434, 266, 131, 211, 248, 481, 28, 114, 446, 132, 406, 291, 142, 157, 316, 67, 541, 554, 37, 163, 512, 564, 523, 7, 224, 479, 466, 21, 392, 47, 105, 542, 258, 162, 179, 2, 320, 217, 151, 136, 53, 182, 302, 417, 138, 229, 337, 39, 497, 419, 439, 485, 340, 421, 286, 429, 191, 336, 119, 483, 45, 272, 273, 366, 376, 213, 403, 38, 377, 166, 231, 16, 42, 305, 433, 298, 152, 75, 359, 462, 172, 149, 106, 186, 401, 139, 158, 386, 254, 30, 490, 474, 473, 471, 544, 29, 451, 49, 357, 426, 307, 494, 164, 448, 235, 241, 427, 208, 198, 519, 218, 453, 62, 538, 346, 393, 407, 61, 173, 43, 256, 293, 430, 203, 573, 283, 375, 141, 140, 113, 297, 107, 341, 55, 502, 287, 558, 496, 86, 60, 460, 491, 379, 187, 363, 477, 84, 274, 514, 65, 551, 367, 397, 486, 306, 246, 200, 50, 15, 66, 416, 126, 464, 472, 284, 301, 528, 261, 338, 520, 159, 576, 344, 253, 214, 571, 35, 572, 442, 411, 122, 135, 308, 292, 537, 415, 408, 169, 556, 478, 467, 475, 184, 499, 52, 493, 521, 137, 437, 444, 148, 299, 41, 529, 385, 530, 350, 525, 351, 190, 559, 536, 309, 102, 420, 144, 395, 277, 362, 94, 161, 268, 553, 447, 223, 79, 181, 174, 399, 354, 435, 461, 5, 145, 19, 4, 72, 228, 12, 468, 20, 327, 80, 189, 501, 303, 244, 423, 391, 192, 109, 352, 412, 128, 120, 574, 543, 170, 314, 215, 8, 539, 44, 454, 540, 252, 56, 204, 548, 535, 143, 321, 262, 378, 326, 225, 300, 269, 220, 87, 404, 557, 206, 345, 93, 570, 334, 398, 265, 282, 372, 424, 188, 90, 74, 422, 312, 180, 73, 59, 361, 89, 511, 527, 509, 216, 279, 125, 495, 64, 271, 110, 489, 209, 33, 81, 117, 402, 130, 331, 54, 315, 562, 546, 240, 390, 432, 129, 355, 22, 498, 296, 196, 506, 260, 207, 488, 504, 368, 185, 482, 480, 371, 513, 380, 347, 6, 26, 236, 522, 575, 112, 127, 450, 255, 146, 175, 500, 263, 388, 370, 348, 176, 171, 369, 234, 118, 382, 78, 313, 552, 507, 383, 111, 270, 360, 155, 249, 531, 290, 295, 409, 400, 183, 373, 374, 23, 396, 232, 547, 333, 97, 160, 518, 310, 85, 508, 438, 317, 197, 561, 289, 418, 510, 57, 13, 195, 165, 51, 569, 330, 245, 549, 150, 194, 91, 167, 387, 247, 353, 384, 153, 463, 431, 31, 325, 452, 343, 456, 233, 516, 257, 63, 285, 560, 116, 457, 275, 34, 484, 219, 449, 436, 25, 193, 394, 492, 304, 533, 364, 205, 69, 32, 324, 319, 156, 124, 18, 71, 201, 48, 70, 178, 568, 267, 532, 358, 555, 96, 566, 524, 335, 100, 242, 455, 212, 470, 550, 545, 11, 311, 104, 469, 413, 328, 389, 329, 14, 227, 133, 27, 101, 82, 99, 154, 414, 243, 103, 567, 95, 115, 121, 459, 238, 10, 77, 46, 517, 168, 199, 445, 251, 202, 250, 222, 342, 281, 177, 24, 487, 147, 1, 443, 134, 441, 476, 505, 88, 278, 226, 108, 526, 565, 339, 534, 221, 405, 410, 276, 294, 123, 332, 381, 503, 458, 356, 515, 76, 230, 237, 323, 3 };

        
//            for (int K = 577; K <= 1152; K++)
//            {
//                MFA[K, 0] = K;
//                for (int L = 1; L<=11; L++)
//                {
//                    MFA[K, L] = MFA[rndmSet[K-576], L];
//                }
//}

            return MFA;        
        }

        public int[,] problemPicker(int [,] workingOn)
        {
            // Algorithm to determine probabilities of asking each question.
            // workingOn array guide:
            // Column 1: Question number from the big MFA.
            // Column 2: Average of last 4 things. Taken from Column 11 of MFA.
            
            int timeSum = 0;
            for (int i = 0; i < 10; i++)  //time sum
            {
                timeSum = timeSum + workingOn[i, 1];
                // Console.WriteLine("building timeSum" + timeSum);
            }
            // Console.WriteLine("timeSum " + timeSum);


            Random r = new Random();
            int rInt = r.Next(1, 100);
            int rInt2 = rInt * timeSum / 100;
            int k = 0;
            int timeTotal=0;
            timeTotal = timeTotal + workingOn[k, 1];


            for (k = 1; (timeTotal <= rInt2 && k<=10); k++)
            {
                timeTotal = timeTotal + workingOn[k, 1];
            }
            k = k - 1;

            //if (k == 11) { k = 10; }
            // set the bottom two values of the workingOn array
            workingOn[10, 0] = workingOn[k, 0]; 
            workingOn[10, 1] = k;

            // display the workingOn array
            //Console.WriteLine("workingOn array ");
            int rowLengthWO = workingOn.GetLength(0);
            int colLengthWO = workingOn.GetLength(1);

            for (int i = 0; i < rowLengthWO; i++)
            {
                for (int j = 0; j < colLengthWO; j++)
                {

                }

            }



            return workingOn;
        }

        public int questionAsker(int Arg1, int Op, int Arg2, int answer)
        {
            if (Op == 0)  // writes the appropriate question.
            {
                Console.Write(Arg1 + " + " + Arg2 + " = ");
            }
            else if (Op == 1)
            {
                Console.WriteLine(Arg1 + " - " + Arg2 + " = ");
            }
            else if (Op == 2)
            {
                Console.WriteLine(Arg1 + " " + (char)215 + " " + Arg2 + " = ");
            }
            else if (Op == 3)
            {
                Console.WriteLine(Arg1 + " " + (char)247 + " " + Arg2 + " = ");
            }
            DateTime askTime = DateTime.Now;
            string input = Console.ReadLine();
            while (input == "")
            {
                input = Console.ReadLine();
            }

            int userAnswer = Convert.ToInt16(input);
            DateTime answerTime = DateTime.Now;
            TimeSpan lag = answerTime - askTime;



            int lagInt = 0;
            decimal lagDecimal = 0;
            TimeSpan max = new TimeSpan(0, 0, 0, 5);
            if (userAnswer != answer)
            {
                lagInt = 80;
            }
            else if (lag > max)
            {
                lagInt = 50;
            }
            else if (lag < max)
            {
                lagDecimal = lag.Seconds * 10 + lag.Milliseconds/100 ;
                lagInt = Convert.ToInt16(lagDecimal);
            }
            return lagInt;      
        }
    }
}


//Made a random list.

//List<int> iList = new List<int>();
//for (int i = 576; i >= 1; i--)
//{
//    iList.Add(i);
//}
//string straightlist = string.Join(", ", iList);
//Console.Write(straightlist);

//List<int> rList = new List<int>();
//Random r = new Random();

//for (int J = 576; J >= 2; J--)
//{
//    int rInt = r.Next(1, J);
//    rList.Add(iList[rInt]);
//    iList.RemoveAt(rInt);

