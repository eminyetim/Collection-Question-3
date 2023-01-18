using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        string giveStr =  Convert.ToString(Console.ReadLine());
        int lengStr = giveStr.Length;
        char[] charArr = {'a' , 'e' , 'ı' , 'i' , 'u' , 'ü' ,'o' , 'ö'};
        ArrayList arrList = new ArrayList();

        for (int i = 0; i < lengStr; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if(giveStr[i] == charArr[j] )
                {
                   arrList.Add(giveStr[i]);
                }
            }
        }

        arrList.Sort();
        foreach (var item in arrList)
        {
            System.Console.WriteLine(item);
        }
        
    }

}