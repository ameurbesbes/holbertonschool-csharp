using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int i = int.MinValue;
        string keyofi = "None";
        foreach(KeyValuePair<string,int>pair in myList)
        {
            if (pair.Value > i)
            {
                i = pair.Value;
                keyofi = pair.Key;
            }
        }
        return keyofi;
    }
}