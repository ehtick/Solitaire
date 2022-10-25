using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;

namespace Solitaire.Utils;

public static class LinqExtensions
{
    /// </summary>
    private static readonly Random Random = new();

    /// <summary>
    /// Shuffles the specified list.
    /// </summary> 
    public static void Shuffle<T>(this IList<T> list)
    {
        var n = list.Count;
        while (n > 1)
        {
            n--;
            var k = Random.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }
}