using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beerhall.Components
{
    public static class StringExtensions
    {
        public static string AddCssClass(this string source, string newClass)
        {
            return source += $" {newClass}";
        }
        public static string AddCssClassWhen(this string source, bool predicate, string newClass)
        {
            return source += predicate ? $" {newClass}" : string.Empty;
        }
    }
}
