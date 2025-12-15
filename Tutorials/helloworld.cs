using System;
﻿namespace TourOfCsharp;
class main {
    static void Main() {
        //Line to print Hello World to the console
        Console.WriteLine("Hello, World!");

        string helloInAnotherLanguage = "RAWR!";
        Console.WriteLine(helloInAnotherLanguage);

        helloInAnotherLanguage = "Meow!";
        Console.WriteLine(helloInAnotherLanguage);

        Console.WriteLine($"{helloInAnotherLanguage} means 'Hello!'");

        string bestFriend = "Alex";
        Console.WriteLine($"{bestFriend} is my best friend!");
        Console.WriteLine($"The name {bestFriend} has {bestFriend.Length} letters.");

        string greeting = "      Hello World!       ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");

        helloInAnotherLanguage = helloInAnotherLanguage.ToUpper();
        Console.WriteLine(helloInAnotherLanguage);

        helloInAnotherLanguage = helloInAnotherLanguage.ToLower();
        Console.WriteLine(helloInAnotherLanguage);

        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);

        sayHello = sayHello.Replace("Hello", "RAWR");
        Console.WriteLine(sayHello);

        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.Contains("goodbye"));
        Console.WriteLine(songLyrics.Contains("greetings"));

        //A simple Exercise
        Console.WriteLine("The lyrics start with 'You': {0}", songLyrics.StartsWith("You"));
        Console.WriteLine("The lyrics start with 'goodbye': {0}", songLyrics.StartsWith("goodbye"));
        Console.WriteLine("The lyrics end with 'goodbye': {0}", songLyrics.EndsWith("goodbye"));
        Console.WriteLine("The lyrics end with 'hello': {0}", songLyrics.EndsWith("hello"));
    }
}