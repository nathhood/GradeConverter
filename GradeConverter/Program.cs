﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeConverter
{
    class Program

    {
        static void Main(string[] args)
        {
            int type;

            do
            {

                Console.WriteLine("MAIN MENU");
                Console.WriteLine("=========");
                Console.WriteLine("1. Convert to a Level grade");
                Console.WriteLine("2. Convert to a Letter grade");
                Console.WriteLine("3. Exit \n");
                Console.WriteLine("Please enter your selection: ");
                
                    type = Int32.Parse(Console.ReadLine());

                if (type == 1) percentageToLevel();
                if (type == 2) percentageToAlpha();

            }
            while (type != 3);

        }

        // Conversion function percentage to Alpha
        public static void percentageToAlpha()
        {

            int grade;
            String alphaGrade;
            String messageOut;

            Console.WriteLine("Please enter the numeric grade: ");
            grade = Int32.Parse(Console.ReadLine());

            if (grade < 50)
            {
                alphaGrade = "F";
            }
            else if ((grade >= 50) && (grade <= 52))
            {
                alphaGrade = "D-";
            }
            else if ((grade >= 53) && (grade <= 56))
            {
                alphaGrade = "D";
            }
            else if ((grade >= 57) && (grade <= 59))
            {
                alphaGrade = "D+";
            }
            else if ((grade >= 60) && (grade <= 62))
            {
                alphaGrade = "C-";
            }
            else if ((grade >= 63) && (grade <= 66))
            {
                alphaGrade = "C";
            }
            else if ((grade >= 67) && (grade <= 69))
            {
                alphaGrade = "C+";
            }
            else if ((grade >= 70) && (grade <= 72))
            {
                alphaGrade = "B-";
            }
            else if ((grade >= 73) && (grade <= 76))
            {
                alphaGrade = "B";
            }
            else if ((grade >= 77) && (grade <= 79))
            {
                alphaGrade = "B+";
            }
            else if ((grade >= 80) && (grade <= 84))
            {
                alphaGrade = "A-";
            }
            else if ((grade >= 85) && (grade <= 89))
            {
                alphaGrade = "A";
            }
            else if ((grade >= 90) && (grade <= 100))
            {
                alphaGrade = "A+";
            }
            else
            {
                alphaGrade = "Error - invalid mark, try again!";
            }

            messageOut = (grade + "% = " + alphaGrade);
            Console.WriteLine(messageOut);
        }

        // Conversion function percentage to level
        public static void percentageToLevel()

        {
            int grade;
            String levelGrade;
            String messageOut;

            Console.WriteLine("Please enter the numeric grade: ");
            grade = Int32.Parse(Console.ReadLine());

            if (grade < 50)
            {
                levelGrade = "R";
            }
            else if ((grade >= 50) && (grade <= 52))
            {
                levelGrade = "L1-";
            }
            else if ((grade >= 53) && (grade <= 56))
            {
                levelGrade = "L1";
            }
            else if ((grade >= 57) && (grade <= 59))
            {
                levelGrade = "L1+";
            }
            else if ((grade >= 60) && (grade <= 62))
            {
                levelGrade = "L2-";
            }
            else if ((grade >= 63) && (grade <= 66))
            {
                levelGrade = "L2";
            }
            else if ((grade >= 67) && (grade <= 69))
            {
                levelGrade = "L2+";
            }
            else if ((grade >= 70) && (grade <= 72))
            {
                levelGrade = "L3-";
            }
            else if ((grade >= 73) && (grade <= 76))
            {
                levelGrade = "L3";
            }
            else if ((grade >= 77) && (grade <= 79))
            {
                levelGrade = "L3+";
            }
            else if ((grade >= 80) && (grade <= 84))
            {
                levelGrade = "L4-";
            }
            else if ((grade >= 85) && (grade <= 89))
            {
                levelGrade = "L4";
            }
            else if ((grade >= 90) && (grade <= 100))
            {
                levelGrade = "L4+";
            }
            else
            {
                levelGrade = "Error - invalid mark, try again!!";
            }

            messageOut = (grade + "% = " + levelGrade);
            Console.WriteLine(messageOut);

        }
    }
}
