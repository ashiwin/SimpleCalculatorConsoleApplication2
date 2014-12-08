// Simple Calculator 2 by Ashiwin, December 2014 //

open System

Console.Title <- "Simple Calculator by Ashiwin"

let mutable ok = true
while ok do

let add x y = x + y;
let sub x y = x - y;
let mul x y = x * y;
let div x y = x / y;

Console.WriteLine("Simple Calculator\nby Ashiwin");
Console.WriteLine("\nHow it works:\nx ? y = z\n\nLegend:\nx - value for x (integer or decimal)\ny - value for y (integer or decimal)\n? - operator\nz - result");
Console.WriteLine("\nKey in a number for x (x):");
let x = Console.ReadLine();
let X : decimal = decimal x;

Console.WriteLine("\nKey in a number for y (y):");
let y = Console.ReadLine();
let Y : decimal = decimal y;

Console.WriteLine("\nChoose an operator (?):");
Console.WriteLine("1 - addition");
Console.WriteLine("2 - subtraction");
Console.WriteLine("3 - multiplication");
Console.WriteLine("4 - division");

let z = Console.ReadLine();

match z with
| "1" -> printfn("\nResult (z): %M") (add X Y)
| "2" -> printfn("\nResult (z): %M") (sub X Y)
| "3" -> printfn("\nResult (z): %M") (mul X Y)
| "4" -> printfn("\nResult (z): %M") (div X Y)
| _ -> printfn("\nInvalid operator.")

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey() |> ignore
Environment.Exit(0)