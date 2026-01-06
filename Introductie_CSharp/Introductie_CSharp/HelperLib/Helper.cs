using System;
using System.Collections.Generic;
using System.Text;

namespace Introductie_C_.HelperLib;

public static class Helper
{
    public static void Wissel(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void makeCammelCase(string Zin)
    {
        //  Zin splitsen in woorden
        string[] woorden = Zin.Split(' ');

        // Woorden met hoofdletter schrijven
        for (int i = 0; i < woorden.Length; i++)
        {
            if (woorden[i].Length > 0)
            {
                woorden[i] = char.ToUpper(woorden[i][0]) + woorden[i].Substring(1).ToLower();
            }
        }   

        Console.WriteLine(woorden);
    }
    public static void Maand()
    {

    }

}
