using System.Collections.Generic;

namespace Frqvs.DataModels
{
    public class Parameters : Model
    {
        public int NumNodes { get; set; }
        public int NumResistors { get; set; }
        public int NumInductors { get; set; }
        public int NumCapacitors { get; set; }
        public int Inut { get; set; }
        public int Itut { get; set; }
        public int Inun { get; set; }
        public int Itun { get; set; }
        public int IdTransformers { get; set; }
        public int IdOperationalAmplifiers { get; set; }
        public int Transformers { get; set; }
        public int OperationalAmplifiers { get; set; }
        public int UpTransistors { get; set; }
        public int BpTransistors { get; set; }

        public List<Element> Resistors { get; set; }
        public List<Element> Inductors { get; set; }
        public List<Element> Capacitors { get; set; }
    }
}
