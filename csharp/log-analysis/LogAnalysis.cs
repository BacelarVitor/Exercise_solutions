using System;

public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str,  string substring) 
    {
        var index = str.IndexOf(substring)+substring.Length;
        return str[index..];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string firstSub, string secondSub)
    {
        var firstIndex = str.IndexOf(firstSub)+firstSub.Length;
        var idealLenght = str.LastIndexOf(secondSub) - firstIndex;
        return str.Substring(firstIndex, idealLenght);
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) 
    {
        return str.SubstringAfter(": ");
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) 
    {
        return str.SubstringBetween("[", "]");
    }
}