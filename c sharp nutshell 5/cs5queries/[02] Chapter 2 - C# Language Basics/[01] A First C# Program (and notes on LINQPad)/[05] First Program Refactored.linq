<Query Kind="Program" />

// Here, we've refactored our logic into a method called FeetToInches.

static void Main()
{
	Console.WriteLine (FeetToInches (30));      // 360
	Console.WriteLine (FeetToInches (100));     // 1200
}

static int FeetToInches (int feet)
{
	int inches = feet * 12;
	return inches;
}