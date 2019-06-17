namespace RomanNumeralsKata2
{
    public class Roman
    {
        public static string Parse(int v)
        {
            int number = v
            for (int i = number.ToString().Length; i > 0; i--)
            {

                switch (v)
                {
                    case 1:
                        return "I";
                    case 2:
                        return "II";
                    case 3:
                        return "III";
                    case 4:
                        return "IV";
                    case 5:
                        return "V";
                    case 6:
                        return "VI";
                    case 7:
                        return "VII";
                    case 8:
                        return "VIII";
                    case 9:
                        return "IX";
                    case 10:
                        return "X";
                    default:
                        return "";
                }
            }
            
        }
    }
}