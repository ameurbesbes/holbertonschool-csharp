using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        foreach (int x in myLList)
        {
            if (i == index)
            {
                myLList.Remove(x);
                return;
            }
            i++;
        }
    }
}