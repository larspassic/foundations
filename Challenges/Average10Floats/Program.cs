﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average10Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Ask user for input
                Console.WriteLine("This program will calculate the average of up to 10 numbers.");

                //Establish the array to hold the numbers
                float[] floatArray = new float[10];

                //Define an integer to hold how many elements we have in the array
                int numberOfFloats = 0;

                //Since we are collecting up to 10 numbers, use a loop to gather input
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Please enter a number (or just press enter to average the current set of numbers):");
                    
                    //Take user input as string
                    string userInputString = Console.ReadLine();
                    
                    if (userInputString == "") //Break out of the loop if the user hit enter without typing a number
                    {
                        break;
                    }
                    
                    float userInputFloat = float.Parse(userInputString);
                    
                    floatArray[i] = userInputFloat;
                    numberOfFloats++;
                }

                //Loop to add up all of the numbers in the floatArray

                float sumFloats = 0;
                for (int i=0; i < floatArray.Length; i++)
                {
                    sumFloats += floatArray[i];
                }

                float averageFloats = sumFloats / numberOfFloats;

                //Send output to the user
                Console.WriteLine($"The average of the numbers you entered was {averageFloats}");
                Console.WriteLine();

            }
        }
    }
}
