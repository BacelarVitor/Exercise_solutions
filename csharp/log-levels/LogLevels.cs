using System;
using System.Collections.Immutable;

static class LogLine
{
    public static string Message(string logLine)
    {
        var message = logLine.Split(": ")[1];
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        var level = logLine.Split(": ")[0];
        return level.Replace("[", string.Empty).Replace("]", string.Empty).ToLower().Trim();
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
