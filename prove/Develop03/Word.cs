using System;

public class Word
{
    Random randomGenerator = new Random();
    string hide = " ";

    public Word( string hidden)
    {
        int count = 1;
        hide = hidden;
        //Hides the scripture at a time by replacing with dashes at index points

        while (count != 0)
    {
        //We split the scriptures found in the variable "hide" and give it a variable name
        var allval = hide.Split(" ");

        //Random select number the length of the splitted words
        int index = randomGenerator.Next(allval.Length);
        
        //The number acts as an index
        var vt = (allval[index]);

        //Replace at the random index with "_"
        hide = hide.Replace(vt, "_");


        var userin = Console.ReadKey();
        
        //If user presses Enter key
        if (userin.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            
            //Displays the new word
            Console.WriteLine(hide);

            //We split the new word in order to count the number of dashes in there
            int icount= hide.Split(new string[] {"_"}, StringSplitOptions.None).Length - 1;

            //Convert the number into a string
		    string comp1 = icount.ToString();

            //Find the length of the splitted word from the begining
            var comp2conv = allval.Length;

            //convert the number into string
            string comp2 = comp2conv.ToString();

            //Compare if the dashes are the same as the length of the scripture

            if (comp1 == comp2)
            {
                count = 0;
                Console.WriteLine("Done");
            }
        }
        else
        {
            count = 0;
        }

    }
    }
}