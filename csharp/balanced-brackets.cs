using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    private static readonly Dictionary<char, char> PAIRED_BRACKETS = new[] { "()", "{}", "[]" }.ToDictionary(x => x[0], x => x[1]);

    public static string IsBalanced(string expression)
    {        
        if (expression == null) throw new ArgumentNullException(nameof(expression));
    
        Func<char, bool> isBracket = c => PAIRED_BRACKETS.ContainsKey(c) || PAIRED_BRACKETS.ContainsValue(c);
        
        var stack = new Stack<char>();
        foreach (var c in expression.Where(isBracket))
        {
            var isOpening = PAIRED_BRACKETS.ContainsKey(c);
            var pair = isOpening ? PAIRED_BRACKETS[c] : PAIRED_BRACKETS.First(x => x.Value == c).Key;
            
            if (isOpening) stack.Push(c);            
            else
            {                
                if (!stack.Any()) return "NO";                
                if (stack.Peek() != pair) return "NO";                
                stack.Pop();
            }
        }

        return !stack.Any() ? "YES" : "NO";
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = IsBalanced(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
