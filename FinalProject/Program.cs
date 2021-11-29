using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine(" Please Enter your Name?");
            string username = Console.ReadLine();

            Console.WriteLine("Let's get you to your desired weight");

            Console.WriteLine("In order to help reach your health goals, we will need some general information first!");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Do you identify as Male or Female");
            string usergender = Console.ReadLine();
            if (usergender == "Male")
            {
                Console.WriteLine("Please enter your weight in lbs.");
                double userweight = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your height in inches");
                double userheight = int.Parse(Console.ReadLine());
                double userheightm = userheight * userheight;
                int con = 703;


                double userBMI = con * userweight / userheightm;


                Console.WriteLine($"According to the information you have provided your estimated Body Mass Index is {userBMI}!");



                if (userBMI < 18.5)
                {
                    Console.WriteLine("You may be lightly Underweight");

                }
                if (userBMI == 18.5 - 24.0)
                {
                    Console.WriteLine("Your BMI is Average");
                }


                if (userBMI <= 29.9)
                {
                    Console.WriteLine("You may be slightly Overweight");

                }


            }
            if (usergender == "Female")
            {
                Console.WriteLine("Please enter your weight in lbs.");
                double userweight = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your height in inches");
                double userheight = int.Parse(Console.ReadLine());
                double userheightm = userheight * userheight;
                int con = 703;


                double userBMI = con * userweight / userheightm;


                Console.WriteLine($"According to the information you have provided your estimated Body Mass Index is {userBMI}");

                if (userBMI < 18.5)
                {
                    Console.WriteLine("You may be lightly Underweight");

                }
                if (userBMI == 18.5 - 24.0)
                {
                    Console.WriteLine("Your BMI is Average");
                }


                if (userBMI <= 29.9)
                {
                    Console.WriteLine("You may be slightly Overweight. According to CDC Anyone who is overweight should try to avoid gaining additional weight. Additionally, if you are overweight with other risk factors (such as high LDL cholesterol, low HDL cholesterol, or high blood pressure), you should try to lose weight. Even modest weight loss may help lower the risk of disease. Talk with your healthcare provider to determine appropriate ways to lose weight.");

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
                Console.WriteLine(" A calorie is a unit of energy. When you hear something contains 100 calories, it's a way of describing how much energy your body could get from eating or drinking. Please enter the amount of calaries you consume a day.");

           double usercalperday = double.Parse(Console.ReadLine());
           
           if (usercalperday > 2500)

            Console.WriteLine($" {username} Your calorie intake perday is {usercalperday}, which is just above the national average. How many meals are you eating perday?");


           if (usercalperday < 2300)

            Console.WriteLine($"{username} Your calorie intake perday is {usercalperday}, which just below the national average. How many meals are you eating perday?");



           


            
        }   
    }
}
















