﻿using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string a = "";
            for (int i = 0; i < orig.Length; i++)
            {
                for (int v = 0; v < n; v++)
                {
                    a = a + orig[i];
                }
            }
            return a;
        }
    }
}
