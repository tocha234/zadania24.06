using System;

class Program
{
    static void Main(string[] args)
    {
        int elapsedTime = 332;
        string formattedTime = FormatTime(elapsedTime);
        Console.WriteLine(formattedTime);
    }

    static string FormatTime(int elapsedTime)
    {
        int hours = elapsedTime / 3600;
        int minutes = (elapsedTime % 3600) / 60;
        int seconds = (elapsedTime % 3600) % 60;

        string formattedHours = hours.ToString("D2");
        string formattedMinutes = minutes.ToString("D2");
        string formattedSeconds = seconds.ToString("D2");

        return $"{formattedHours}:{formattedMinutes}:{formattedSeconds}";
    }
}
