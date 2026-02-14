using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace lesson15
{
    public static class Extension
    {
       // Write WhereMy and FirstOrDefaultMy extension methodd for List class that works exatly the same as original Where and FirstOrDefault ones.

        public static IEnumerable<TSource> WhereMy<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return source.Where(predicate);
        }

        public static TSource? FirstOrDefaultMy<TSource>(this IEnumerable<TSource> source)
        {
            return source.FirstOrDefault();
        }
           
    }
}
