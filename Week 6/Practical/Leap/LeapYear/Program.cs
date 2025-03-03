using LeapYear;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Leap.IsLeapYear(1997);

int testValue = 1997;

Console.WriteLine(testValue + " is a leap year: " +Leap.IsLeapYear(testValue));
Console.WriteLine(Leap.IsLeapYear(1997));
Console.WriteLine(Leap.IsLeapYear(1900));
Console.WriteLine(Leap.IsLeapYear(2000));
