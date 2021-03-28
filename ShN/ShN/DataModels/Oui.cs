namespace ShN.DataModels
{
    public class Oui : Element
    {
        public int PlusNode1 { get; set; }
        public int MinusNode1 { get; set; }
        public int PlusNode2 { get; set; }
        public int MinusNode2 { get; set; }

        public override ElementType Type => ElementType.Oui;

        public override int[] GetNodes()
        {
            return new int[] { PlusNode1, MinusNode1, PlusNode2, MinusNode2 };
        }
    }
}
