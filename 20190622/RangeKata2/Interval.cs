using System;

namespace RangeKata2
{
    public class Interval
    {
        private string v;
        private int beg;
        private int end;

        public Interval(string v)
        {
            this.v = v;
            beg = Int32.Parse(v.Substring(1, v.IndexOf(",")-1));
            end = Int32.Parse(v.Substring(v.IndexOf(",") + 1 , v.Length - v.IndexOf(",") -2));
            if (v.StartsWith("("))
            {
                beg++;
            }

            if (v.EndsWith(")"))
            {
                end--;
            }

        }

        public bool Contains(int v)
        {
            if (v >= beg && v <= end)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetAllPoints()
        {
            string result = "{" + beg;
            for (int i = beg+1; i <=end; i++)
            {
                result = result + "," + i;
            }
            result += "}";
            return result;
        }

        public bool ContainsRange(string v)
        {
            Interval interval = new Interval(v);

            if(interval.beg >= beg && interval.end <= end)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string EndPoints()
        {
            return "{" + beg + "," + end + "}";
        }
    }
}