using System.Collections.Generic;
using System.Linq;

namespace ShN.DataModels
{
    public class Source : Element
    {
        public int PlusNode1 { get; set; }
        public int MinusNode1 { get; set; }
        public int PlusNode2 { get; set; }
        public int MinusNode2 { get; set; }
        public double Y { get; set; }
        public double T1 { get; set; }
        public double T2 { get; set; }

        public override int[] GetNodes()
        {
            return new int[] { PlusNode1, MinusNode1, PlusNode2, MinusNode2 };
        }
    }
}
