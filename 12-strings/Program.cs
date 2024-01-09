
using System.Runtime.InteropServices;
using static System.Console;

string s1 = "Please";
string s2 = "github repo of solarix";
string s3 = s1 + " add a star to the " + s2;

WriteLine(s3 + 23);
WriteLine(String.Format("{0} add a star to the {1}23",s1,s2)); // QString("").arg()

// String Interpolation
WriteLine($"{s1} add a star to the {s2}23");
WriteLine($"Decimal {15} is in Hex 0x{15:X2}");

WriteLine("   Windows-Text-Row  \r\n  ".Trim());     // QString::trim()

WriteLine("\r\n   Windows-Text-Row".TrimStart());

WriteLine("K3rb4l Space Program".IndexOf("Space")); // QString::indexOf()
WriteLine("K3rb4l Space Program".Substring(7,5));   // QString::mid()
WriteLine("K3rb4l Space Program".Split(" ")[1]);    // QString::split()
WriteLine("Windows is the best operating system".Replace("Windows","Linux"));    // QString::replace()


// Escaping
WriteLine("Newline on Linux is \\n, on Windows \\r\\n");
WriteLine(@"Newline on Linux is \n, on Windows \r\n");
WriteLine(@"Multiline 1
Multiline 2");

// RAW Strings
WriteLine("""
Multiline "1"
Multiline "2"
""");

// Fast StringBuilder
var sb = new System.Text.StringBuilder("Stringbuilder: ");
for (int i = 0; i < 10; i++) {
    sb.Append(i.ToString());
}
WriteLine(sb);

// https://learn.microsoft.com/en-us/dotnet/csharp/how-to/compare-strings
WriteLine($"ORANGE/orange: {String.Compare("ORANGE","orange")}");
WriteLine($"ORANGE/orange: {String.Compare("ORANGE","orange",StringComparison.Ordinal)}");
WriteLine($"orange/ORANGE: {String.Compare("orange","ORANGE",StringComparison.Ordinal)}");
WriteLine($"ORANGE/orange: {String.Compare("ORANGE","orange",StringComparison.OrdinalIgnoreCase)}");

// Culture Compare
WriteLine($"Straße/Strasse: {"Straße" == "Strasse"}");
WriteLine($"Straße/Strasse: {String.Equals("Straße","Strasse",StringComparison.Ordinal)}");
WriteLine($"Straße/Strasse: {String.Equals("Straße","Strasse",StringComparison.CurrentCulture)}");
WriteLine($"Straße/Strasse: {String.Equals("Straße","Strasse",StringComparison.InvariantCulture)}");
WriteLine($"Straße/Strasse: {String.Equals("Straße","Strasse",StringComparison.InvariantCulture)}");

// Outputs both "1"? Should be equal in German?
var en = new System.Globalization.CultureInfo("en-US");
WriteLine($"Straße/Strasse ({en.Name}): {String.Compare("Straße","Strasse",en,System.Globalization.CompareOptions.None)}");
var de = new System.Globalization.CultureInfo("de-DE");
WriteLine($"Straße/Strasse ({de.Name}): {String.Compare("Straße","Strasse",de,System.Globalization.CompareOptions.None)}");

