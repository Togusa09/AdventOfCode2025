// See https://aka.ms/new-console-template for more information
using AdventOfCode.Cmd.Task1;
using AdventOfCode.Cmd.Task2;
using System.Threading.Tasks;

//var task1File = File.ReadAllLines("task1.txt");

//var task1A = new Task1A();
//var result1A = task1A.Run(task1File);
//Console.WriteLine(result1A);

//var task1B = new Task1B();
//var result1B = task1B.Run(task1File);
//Console.WriteLine(result1B);

var task2File = File.ReadAllLines("task2.txt");

//var task2A = new Task2A();
//var result2A = task2A.Run(task2File);
//Console.WriteLine(result2A);

var task2B = new Task2B();
var result2B = task2B.Run(task2File);
Console.WriteLine(result2B);