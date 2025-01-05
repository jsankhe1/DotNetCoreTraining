namespace Assignment.MiniAssignment1;

public class NumberTypesInfo
{
    /*
        Create a console application project named /02UnderstandingTypes/ that outputs the
        number of bytes in memory that each of the following number types uses, and the
        minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
        ulong, float, double, and decimal
    */


    public void PrintNumberTypes()
    {
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "Type", "Size", "MinValue", "MaxValue");
        Console.WriteLine(new string('-', 60));
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "sbytea", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "short", sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "ushort", sizeof(ushort), ushort.MinValue,
            ushort.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "int", sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "long", sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "float", sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "double", sizeof(double), double.MinValue,
            double.MaxValue);
        Console.WriteLine("{0,-10} {1,-10} {2,-20} {3,-20}", "decimal", sizeof(decimal), decimal.MinValue,
            decimal.MaxValue);
    }
}