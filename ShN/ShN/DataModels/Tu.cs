namespace ShN.DataModels
{
    public class Tu : Element
    {
        public int NodeZ { get; set; }
        public int NodeS { get; set; }
        public int NodeI { get; set; }

        public double Rc { get; set; }
        public double Czi { get; set; }
        public double Czs { get; set; }
        public double Csi { get; set; }
        public double S { get; set; }

        public override ElementType Type => ElementType.Tu;

        public override int[] GetNodes()
        {
            return new int[] { NodeZ, NodeS, NodeI };
        }

        public double[] GetZ()
        {
            return new double[] { Rc, Czi, Czs, Csi, S };
        }
    }
}
