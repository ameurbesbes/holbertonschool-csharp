﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int i = 0;
        foreach (int l in myLList) { i++; }
        return i;
    }
}