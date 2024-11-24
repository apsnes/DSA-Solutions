public class Solution {
    public string IntToRoman(int num)
    {
        StringBuilder sb = new();
        while (num > 0)
        {
            if (num >= 1000) { sb.Append("M"); num -= 1000; }
            else if (num >= 900) { sb.Append("CM"); num -= 900; }
            else if (num >= 500) { sb.Append("D"); num -= 500; }
            else if (num >= 400) { sb.Append("CD"); num -= 400; }
            else if (num >= 100) { sb.Append("C"); num -= 100; }
            else if (num >= 90) { sb.Append("XC"); num -= 90; }
            else if (num >= 50) { sb.Append("L"); num -= 50; }
            else if (num >= 40) { sb.Append("XL"); num -= 40; }
            else if (num >= 10) { sb.Append("X"); num -= 10; }
            else if (num >= 9) { sb.Append("IX"); num -= 9; }
            else if (num >= 5) { sb.Append("V"); num -= 5; }
            else if (num >= 4) { sb.Append("IV"); num -= 4; }
            else { sb.Append("I"); num -= 1; }
        }
        return sb.ToString();
    }
}
