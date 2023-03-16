// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace ICEtask1
{
    class Marking
    {
        static void Main(string[] args)
        {
            int totScripts, subTotQuestion, numLecturer, numQuestionInput, estTime, eachsubTot;
            do
            {

                Console.WriteLine("Enter the total number of scripts that need marking:");
                totScripts = Convert.ToInt32(Console.ReadLine());
                if (totScripts <= 0)
                {
                    Console.WriteLine("Value must be greater than 0");
                }

            }
            while (totScripts <= 0);







            do
            {
                Console.WriteLine("Enter the number of questions in a script:");
                numQuestionInput = Convert.ToInt32(Console.ReadLine());

                if (numQuestionInput < 1 || numQuestionInput > 10)
                {
                    Console.WriteLine("Value must be greater than 0");
                }

            }
            while (totScripts <= 0);

            /*
                        do
                        {
                            Console.WriteLine("Enter the subtotals of each question"); ;
                            subTotQuestion = Convert.ToInt32(Console.ReadLine());
                            if (subTotQuestion <= 0)
                            {
                                Console.WriteLine("Value must be greater than 0");
                            }
                        }
                        while (subTotQuestion <= 0);*/

            int t = 0;
            int a = 1;
            for (int i = 0; i < numQuestionInput; i++)
            {
                Console.WriteLine("write the total marks  of each question  " + a);

                subTotQuestion = Convert.ToInt32(Console.ReadLine());
                t += subTotQuestion;
                a++;
            }

            Console.WriteLine("Total number of marks in a script " + t);



            do
            {
                Console.WriteLine("Enter the number of lecturers who are going to mark the scripts");
                numLecturer = Convert.ToInt32(Console.ReadLine());
                if (numLecturer <= 0)
                {
                    Console.WriteLine("Value must be graeter than 0");
                }

            }



            while (numLecturer <= 0);


            int total1 = totScripts / numLecturer;
            int total2 = total1 * t * 2;
            Console.WriteLine("Total = " + total1);
            //estTime = subTotQuestion * ;
            TimeSpan time = TimeSpan.FromSeconds(total2);
            Console.WriteLine("total time : " + time);



        }


    }
}

