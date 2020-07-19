/* Programmer: Austin Parker
   Date: March 2nd, 2020
   Purpose: This program determines if three input values could equal a triangle
 */
using static System.Console;



namespace Triangle
{
    class Triangle
    {
        static void Main()
        {



            while (true)
            {
                //Welcome information and instructions for starting or ending application
                WriteLine("   Would you like to Start or Continue the application? \n" +
                          "\n   Please enter \"0\" to END program or \"1\" to CONTINUE");
                //Determines if start or end application input is valid. If not displays error message
                int startProgram;
                string startProgramValue = ReadLine();
                while ((int.TryParse(startProgramValue, out startProgram) == false)
                       || startProgram < 0 || startProgram > 1)
                {
                    WriteLine(
                        "Invalid input for starting or ending application, please enter \"0\" to END program or \"1\" to CONTINUE. ");
                    startProgramValue = ReadLine();
                }

                Clear();

                //Ends program if "0" is entered
                if (startProgram == 0)
                {
                    WriteLine("Thanks for using the Triangle application!\n" +
                        "\n   Please press \"Enter\" to close application");
                    Read();
                    break;
                }


                //Asks for each segment information. Displays error message if invalid input and stores input if valid
                Write("Enter first line segment: ");
                int inputOne;
                string oneValue = ReadLine();
                while ((int.TryParse(oneValue, out inputOne) == false)
                       || inputOne < 1 || inputOne > 1000000)
                {
                    WriteLine("Invalid input for line segment, please enter a number.");
                    oneValue = ReadLine();
                }
                Clear();

                Write("Enter second line segment: ");
                int inputTwo;
                string twoValue = ReadLine();
                while ((int.TryParse(twoValue, out inputTwo) == false)
                       || inputTwo < 1 || inputTwo > 1000000)
                {
                    WriteLine("Invalid input for line segment, please enter a number.");
                    twoValue = ReadLine();
                }
                Clear();

                Write("Enter third line segment: ");
                int inputThree;
                string threeValue = ReadLine();
                while ((int.TryParse(threeValue, out inputThree) == false)
                       || inputThree < 1 || inputThree > 1000000)
                {
                    WriteLine("Invalid input for line segment, please enter a number.");
                    threeValue = ReadLine();
                }
                Clear();

                //Displays results based on user input values
                if (inputOne > inputThree && inputTwo > inputThree)
                {
                    WriteLine("Your three line segments ({0}, {1}, {2}) DO make a triangle!\n", inputOne, inputTwo, inputThree);
                }
                else
                {
                    WriteLine("Your three line segments ({0}, {1}, {2}) DO NOT make a triangle.\n", inputOne, inputTwo, inputThree);
                }
            }
        }
    }
}


