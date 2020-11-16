using System;
public class Average
{   
    /* This program calculates the average of a set of marks, until 
    the user types “end”*/
    
    public static void Main()
    {
        double notesSum=0, numberToWork, counter=0, result;
        string mark;
        
        Console.Write("Insert a mark: ");
        mark = Console.ReadLine();
        	 
        while (mark != "end")
        {  
            numberToWork = Convert.ToDouble(mark);
            
            counter++;  
            notesSum += numberToWork;
              
            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }
        if (counter != 0)
        {
            result = notesSum / counter;  
            Console.WriteLine("The average is {0}.", result);
        }
    }
}
