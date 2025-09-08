using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        int startIndex = logLine.IndexOf("]: ") + 2;
        return logLine.Substring(startIndex).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int length = logLine.IndexOf("]: ") - 1;
        return logLine.Substring(1, length).ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        return $"{message} ({level})";
    }
}
