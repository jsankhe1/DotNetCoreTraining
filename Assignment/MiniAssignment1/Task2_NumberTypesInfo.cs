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
        Console.WriteLine($"Type: sbyte, Size: {sizeof(sbyte)} bytes, MinValue: {sbyte.MinValue}, MaxValue: {sbyte.MaxValue}");
        Console.WriteLine($"Type: byte, Size: {sizeof(byte)} bytes, MinValue: {byte.MinValue}, MaxValue: {byte.MaxValue}");
        Console.WriteLine($"Type: short, Size: {sizeof(short)} bytes, MinValue: {short.MinValue}, MaxValue: {short.MaxValue}");
        Console.WriteLine($"Type: ushort, Size: {sizeof(ushort)} bytes, MinValue: {ushort.MinValue}, MaxValue: {ushort.MaxValue}");
        Console.WriteLine($"Type: int, Size: {sizeof(int)} bytes, MinValue: {int.MinValue}, MaxValue: {int.MaxValue}");
        Console.WriteLine($"Type: uint, Size: {sizeof(uint)} bytes, MinValue: {uint.MinValue}, MaxValue: {uint.MaxValue}");
        Console.WriteLine($"Type: long, Size: {sizeof(long)} bytes, MinValue: {long.MinValue}, MaxValue: {long.MaxValue}");
        Console.WriteLine($"Type: ulong, Size: {sizeof(ulong)} bytes, MinValue: {ulong.MinValue}, MaxValue: {ulong.MaxValue}");
        Console.WriteLine($"Type: float, Size: {sizeof(float)} bytes, MinValue: {float.MinValue}, MaxValue: {float.MaxValue}");
        Console.WriteLine($"Type: double, Size: {sizeof(double)} bytes, MinValue: {double.MinValue}, MaxValue: {double.MaxValue}");
        Console.WriteLine($"Type: decima, Size: {sizeof(decimal)} bytes, MinValue: {decimal.MinValue}, MaxValue: {decimal.MaxValue}");
    }
}