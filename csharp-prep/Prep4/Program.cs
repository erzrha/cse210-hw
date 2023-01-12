using System;

class Program
{
    static void Main(string[] args)
    {   
        int point = 0;
        int high = 0;
        List<int> num = new List<int>();
        Console.Write("Enter number: ");
        string my_num = Console.ReadLine();
        int ans = int.Parse(my_num);
        point +=ans;
        num.Add(ans);
        while (ans != 0)
        {
            Console.Write("Enter number: ");
            my_num = Console.ReadLine();
            ans = int.Parse(my_num);
            point+=ans;
            num.Add(ans);
            if (ans> high)
            {
                high=ans;
            }
        }   
        if (ans ==0)
        {
            Console.Write("The sum is: ");
            Console.WriteLine(point);
            Console.Write("The average is: ");
            Console.WriteLine(point/num.Count);
            Console.Write("The largest number is: ");
            Console.WriteLine(high);
            
        }
    }

}