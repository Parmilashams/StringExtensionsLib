using System;
using StringExtensionsLib;

string test1 = "Hello World";
string test2 = "hello world";
string test3 = "";

Console.WriteLine($"\"{test1}\" starts with uppercase: {test1.StartsWithUpper()}");
Console.WriteLine($"\"{test2}\" starts with uppercase: {test2.StartsWithUpper()}");
Console.WriteLine($"\"{test3}\" starts with uppercase: {test3.StartsWithUpper()}");