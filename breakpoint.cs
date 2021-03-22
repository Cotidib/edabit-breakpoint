using System;
using System.Collections.Generic;
using System.Linq;


static bool BreakPoint(int num) 
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

//BreakPoint(159780);
//BreakPoint(112);
//BreakPoint(1034);
//BreakPoint(10);
//BreakPoint(343);
