using System;
using System.Collections.Generic;
using System.Linq;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BreakPoint(159780);
            //BreakPoint(112);
            //BreakPoint(1034);
            //BreakPoint(10);
            //BreakPoint(343);
        }

         /*
        A number has a breakpoint if it can be split in a way where the digits on the left side
        and the digits on the right side sum to the same number.
        For instance, the number 35190 can be sliced between the digits 351 and 90, since 3 + 5 + 1 = 9 
        and 9 + 0 = 9. On the other hand, the number 555 does not have a breakpoint (you must split between digits).
        Create a function that returns true if a number has a breakpoint, and false otherwise.
        --------------Test:-----------------------------------------------------------------------------------------
        BreakPoint(159780) ➞ true
        BreakPoint(112) ➞ true
        BreakPoint(1034) ➞ true
        BreakPoint(10) ➞ false
        BreakPoint(343) ➞ false


        Mi idea para resolver:
        Recorrer una lista con los digitos de num. Por cada iteracion, sumar los elementos
        que quedan a la izquierda y comparar con la suma de los elementos que quedan a la izquierda.
        Detalles: Separar en dos listas: Una con los elementos de la derecha y otra con los elementos de la izquierda.
        */

        public static bool BreakPoint(int num) 
        {

            bool hasBreakpoint = false;

            //Convert Number to Array of his digits
            List<int> digits = new List<int>();
            for(; num !=0; num /= 10){
                digits.Add(num % 10);
            }
            digits.Reverse();
            //digits.ForEach(Console.WriteLine);

            for(int i=0; i < digits.Count; i++){
                List<int> leftSide = new List<int>();
                List<int> rightSide = new List<int>();
                //Populate list with left side of the iteration
                for(int j=0; j<i; j++){
                    leftSide.Add(digits[j]);
                }
                //Populate list with right side of the iteration
                for(int k=i; k<digits.Count; k++){
                    rightSide.Add(digits[k]);
                }

                // + elements of each list

                if(leftSide.Sum() == rightSide.Sum()){
                    hasBreakpoint = true;
                }

            }

            Console.WriteLine(hasBreakpoint);
            return hasBreakpoint;
        }

        
    }
}
