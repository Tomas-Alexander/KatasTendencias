namespace StringCalculatorKata2
{
    public class StringCalculator
    {
        public static string Add(string v)
        {
            if (v.Length == 0)
            {
                return "0";
            }
            string separator = ",";
            if (v.StartsWith("//"))
            {
                separator = v.Substring(2, v.IndexOf("\n")-2);
                v = v.Substring(v.IndexOf("\n") + 1);
            }
            float result = 0;
            string s = v.Replace("\n", separator);
            if (s.EndsWith(","))
            {
                return "Number expected but EOF found.";
            }
            string[] numbers = s.Split(separator);
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!float.TryParse(numbers[i], out float b))
                {
                    return "Number expected but '\n' found at position " + (v.Replace("\n", ",").IndexOf("," + numbers[i] + ",") + 1) + ".";
                }
                result += b;
            }

            return result.ToString();
        }
    }
}