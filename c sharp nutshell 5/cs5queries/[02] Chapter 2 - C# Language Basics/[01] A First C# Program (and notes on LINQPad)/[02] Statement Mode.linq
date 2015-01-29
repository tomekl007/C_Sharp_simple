<Query Kind="Statements" />

// A First C# Program - in LINQPad's "C# Statements" Mode.
//
// Look at the "Language" dropdown above - notice we've changed it to "C# Statements". This lets
// us do away with the "static void Main" method declaration.

int x = 12 * 30;              // Statement 1
Console.WriteLine (x);        // Statement 2

// Another way to call Console.WriteLine in LINQPad is to call the .Dump() extension method:
x.Dump();

// Both Console.WriteLine and the Dump method give rich formatting in LINQPad - automatically
// expanding objects and collections.