<Query Kind="Program" />

[Flags]
public enum BorderSides { Left=1, Right=2, Top=4, Bottom=8 }

static bool IsFlagDefined (Enum e)
{
	decimal d;
	//Converts the string representation of a number to its Decimal equivalent. A return value indicates whether the conversion succeeded or failed.
	return !decimal.TryParse (e.ToString(), out d);
}

static void Main()
{
	for (int i = 0; i <= 16; i++)
	{
		BorderSides side = (BorderSides)i;
		Console.WriteLine (IsFlagDefined (side) + " " + side);
	}
}