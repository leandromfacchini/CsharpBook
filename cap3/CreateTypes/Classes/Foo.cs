using System;

namespace CreateTypes.Classes
{
    public class Foo
    {
        private decimal x;
        public decimal X
        {
            get { return x; }
            set { x = Math.Round(value, 2); }
        }
    }
}