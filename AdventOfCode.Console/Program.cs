// See https://aka.ms/new-console-template for more information
using AdventOfCode.Cmd.Task1;
using System.Threading.Tasks;

Console.WriteLine("Hello, World!");

var fileContent = File.ReadAllLines("task1.txt");

var task1A = new Task1A();
var result1A = task1A.Run(fileContent);
Console.WriteLine(result1A);

var task1B = new Task1B();
var result1B = task1B.Run(fileContent);
Console.WriteLine(result1B);