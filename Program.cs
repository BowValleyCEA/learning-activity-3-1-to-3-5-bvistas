// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.ComponentModel.Design;
using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;

LearningActivity31();
LearningActivity32();
LearningActivity33();
LearningActivity34();
LearningActivity35();

void LearningActivity31()
{ 
    float c, fh;
    Console.WriteLine("Enter a temperature(celcius)");
    if (float.TryParse(Console.ReadLine(), out c)) 
    { 
     
    }
   
    fh = (c * 9 / 5) + 32;

    Console.WriteLine(fh + " is the temperature in Fahrenheit");
}
void LearningActivity32()
{
    //array creation
    string[] classmateNames = {"Lucas1", "Lucas2", "Canyon","Hamish", "Mason", "Cat", "Keegan", "Camilo","Julie", "Ahamed", "Shae",
    "Muhammed", "Bruno", "Hoang", 
    };

    for (int i = 0; i < classmateNames.Length; i++) ;

    //print 1 name - [0,1,2,3,4,5,6,7,8,9,10,11,12,13]
    Console.WriteLine(classmateNames[11]);
}
void LearningActivity33()
{

    //Fill in LearningActivity33() and do the following:
    //-create a two-dimensional array for tic tac toe that takes in the values where []( 0:empty, 1: X, 2: O).
    //- print out whether X or O won. Make sure your solution works for every possible input!


    //array creation for the board
    char[,] tBoard = new char[3, 3]
    {
        {'X', 'O', 'O'},
        {'X', 'X', 'O'}, 
        {' ', 'X', 'O'}

    };

    PrintBoard(tBoard);
    CheckWinner(tBoard);

static void PrintBoard(char[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                char cell = board[i, j];
                {
                
                };
                Console.Write(cell + " ");
            }
            Console.WriteLine();
        }
    }
static void CheckWinner(char[,] board)
    {
        //rows and columns
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
            {
                Console.WriteLine($"Player {board[i, 0]} wins!");
                return;
            }

            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
            {
                Console.WriteLine($"Player {board[0, i]} wins!");
                return;
            }
        }

        //diagonals
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
        {
            Console.WriteLine($"Player {board[0, 0]} wins!");
            return;
        }

        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
        {
            Console.WriteLine($"Player {board[0, 2]} wins!");
            return;
        }

        //no winner
        Console.WriteLine("There is no winner yet.");
    }
}

void LearningActivity34()
{
    //loop variable (o/f)
    bool validAge = false;
    //age-enter-loop
    while (!validAge)
    {
        int age;
        Console.WriteLine("Please enter your age:");

        bool success = int.TryParse(Console.ReadLine(), out age);
        if (success && age > 10 && age < 50)
        {

            validAge = true;
            Console.WriteLine("Your age is valid.");
        }
        else //rules 
        {
            if (!success)
            {
                Console.WriteLine("Please enter a WHOLE number...");
            }
            else
            {
                Console.WriteLine("Please enter an age between 10 and 50.");
            }
        }
    }
}

void LearningActivity35()
{
    {
        int[] highScores = { 1272700, 1271100, 1243000, 1218000, 1214300, 1210800, 1210400, 1206800, 1178400 };

        double sum = 0;
        double sumOfSquares = 0;

        for (int i = 0; i < highScores.Length; i++)
        {
            sum += highScores[i];
        }

        double average = sum / highScores.Length;

        for (int i = 0; i < highScores.Length; i++)
        {
            sumOfSquares += Math.Pow(highScores[i] - average, 2);
        }

        double standardDeviation = Math.Sqrt(sumOfSquares / highScores.Length);

        Console.WriteLine($"Average Score: {average}");
        Console.WriteLine($"Standard Deviation: {standardDeviation}");
    }
}

