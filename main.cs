using System;
using System.Threading;
using System.Globalization;

class Program
{
    static void DisplayTime()
    {
        DateTime utcNow = DateTime.UtcNow;
        string border = new string('═', 60);

        Console.WriteLine(border);
        Console.WriteLine("🌍 Moscow / Москва / モスクワ (MSK): ".PadRight(30) + utcNow.AddHours(3).ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
        Console.WriteLine("🗽 New York / Нью-Йорк / ニューヨーク (EST): ".PadRight(30) + utcNow.AddHours(-5).ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
        Console.WriteLine("🌁 London / Лондон / ロンドン (GMT): ".PadRight(30) + utcNow.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
        Console.WriteLine("🗼 Tokyo / Токио / 東京 (JST): ".PadRight(30) + utcNow.AddHours(9).ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
        Console.WriteLine("🌉 Sydney / Сидней / シドニー (AEDT): ".PadRight(30) + utcNow.AddHours(11).ToString("hh:mm:ss tt", CultureInfo.InvariantCulture));
        Console.WriteLine(border);
    }

    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "World Time";
        Console.CursorVisible = false; 
        while (true)
        {
            Console.SetCursorPosition(0, 0); 
            DisplayTime();
            Thread.Sleep(1000);
        }
    }
}