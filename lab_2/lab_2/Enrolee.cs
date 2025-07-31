using System;

namespace lab_2
{
    public struct Enrolee : IComparable<Enrolee>
    {
        public string name;
        public int math;
        public int russian;
        public int english;

        public int CompareTo(Enrolee other)
        {
            return String.Compare(this.name, other.name, StringComparison.Ordinal);
        }
    }
}
