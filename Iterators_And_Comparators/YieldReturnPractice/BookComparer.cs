﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CompletePractice
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            int result = x.Title.CompareTo(y.Title);

            if (result == 0)
            {
                result = x.Year.CompareTo(y.Year) * -1;
            }

            return result;
        }
    }
}