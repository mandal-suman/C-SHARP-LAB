/* 
    Definition 04
        Write a program to implement an interface called Exam with 
        a  method  Pass  (intmark)  that  returns  a  boolean.  Write 
        another  interface  called  Classify  with  a  methodDivision  (int 
        average) which returns a String. Write a class called Result 
        which implements both Exam and Classify. The Pass method 
        should return true if the mark is greater than or equal to 50 
        else false. The Division method must return “First” when the 
        parameter average is 60 or  more, “Second” when average is50 or more but below 60, 
        “No division” when average is less than 50
*/

using System;

namespace Program04 {
    class Program {
        static void Main() {
            Result studentResult = new Result();
            int marks = 55;

            Console.WriteLine($"Assessing Marks: {marks}");
            Console.WriteLine($"Passed status: {studentResult.Pass(marks)}");
            Console.WriteLine($"Classification Division: {studentResult.Division(marks)}");
        }
    }
}