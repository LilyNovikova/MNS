namespace ShN.DataModels
{
    public class Element : Model
    {
        public int Id { get; set; }
        public int PlusNode { get; set; }
        public int MinusNode { get; set; }
        public double Z { get; set; }
        public ElementType Type { get; set; }
    }

    public enum ElementType
    {
        Capacitor,
        Inductor,
        Resistor
    }
}
