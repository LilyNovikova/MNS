namespace ShN.DataModels
{
    public class SimpleElement : Element
    {
        public double Z { get; set; }
        public int PlusNode { get; set; }
        public int MinusNode { get; set; }

        public override int[] GetNodes()
        {
            return new int[] { PlusNode, MinusNode };
        }
    }
}
