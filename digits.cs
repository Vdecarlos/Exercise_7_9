using System;

class digits
{   
    /*  calculates how many numbers of 1, 2, 3 or more digits are
    entered by the user until he/she types “end”*/
    static void Main()
    {
        int unitsCounter = 0, tensCounter = 0; 
        int hundredsCounter = 0, manyDigitsCounter = 0;
        
        Console.Write("Insert a number: ");
        string command = Console.ReadLine();  
        // readed as string first to check end word
        
        while (command != "end")
        {
            int number = Convert.ToInt32(command);
            if (number != 0)
            {
                if (number / 10 == 0)
                unitsCounter++; 
                else if (input / 100 == 0)
                b++;  
                else if (input/1000 == 0)
                c++;  
                else
                d++;  
            }
            command = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", a, b, c, d); 
    }
}

