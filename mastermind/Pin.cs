using System;
using System.Collections.Generic;
using System.Text;

namespace mastermind
{
    public class Pin
    {

        public string Value {  set;  get; }
        public int Position { set; get; }

        public Pin(string aValue, int aPosition)
        {
            Value = aValue;
            Position = aPosition;
        }

    }
}
