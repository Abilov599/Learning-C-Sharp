namespace Extensions.Models;

public static class StringExtension
{
    public static string ToCapitalize(this string str) => 
        char.ToUpper(str[0]) + str[1..].ToLower();
}