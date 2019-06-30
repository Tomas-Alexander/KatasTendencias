
using System;

namespace RangeKata1
{
    public class Interval
    {
        private string v;
        public int beginning { get; set; }
        public int end { get; set; }

        public Interval(string v)
        {
            if (v[0] == '[')
            {
                beginning = Int32.Parse(v[v.IndexOf("[") + 1].ToString());
            }
            if (v[0] == '(')
            {
                beginning = Int32.Parse(v[v.IndexOf("(") + 1].ToString()) + 1;
            }

            if (v[v.Length-1] == ']')
            {
                end = Int32.Parse(v[v.IndexOf("]") - 1].ToString());
            }
            if (v[v.Length - 1] == ')')
            {
                end = Int32.Parse(v[v.IndexOf(")") - 1].ToString()) -1;
            }
            beginning = Int32.Parse(v[v.IndexOf("[") + 1].ToString());
            

            this.v = v;
        }

        public bool Contains(int v)
        {
            if (v >= beginning && v <= end)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public string getAllPoints()
        {
            string result = "{";
            for (int i = beginning; i<end;i++)
            {
                result += i+",";
            }
            result += end+"}";
            return result;
        }

        public bool ContainsRange(string v)
        {
            throw new NotImplementedException();
        }
    }
}