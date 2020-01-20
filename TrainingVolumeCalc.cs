using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Training_Volume_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Weight = 130; //Enter your the weight you lifted 
            int Reps = 5 ; //Enter the reps you peformed in the exercise
            int Sets = 5; //Enter total number of sets you peformed

            int x = Weight * Reps * Sets;

            WriteLine(x);
            ReadLine();
        }
    }
}
