using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_FunctionalProgramming
{
    public static class DiceRoll
    {
        static Random rand = new Random();

        public static int RollTheDie(int number)
        {
            return rand.Next(1, number + 1);
        } 

        public static int FunctionalDieRoll(this int number)
        {
            return rand.Next(1, number + 1);
        }

        public static double Add(double num1, double num2) { return num1 + num2; }

        public static double AddFunc(this double num1, double num2) { return num1 + num2; }

        // Extension Method
        // Static Class
        // static method
        // this

        // A number then adding loop, and it will loop that many times
        // Take a delegate

        // Predicate
        // Func
        // 

        public static void Loop(this int number, Action display )
        {
            for (int i = 0; i < number; i++)
            {
                display();
            }
        }

    } // class

} // namespace
