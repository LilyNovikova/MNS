using ShN.Utils;
using System.Collections.Generic;

namespace ShN.DataModels
{
    public class Parameters : Model
    {
        public const int M = 100;
        public const int MR = 20;
        public const int MC = 20;
        public const int ML = 20;
        public const int MF = 20;

        public int N { get; set; }

        public int NumNodes { get; set; }//nv, n
        public int NumResistors { get; set; }//nr
        public int NumInductors { get; set; }//
        public int NumCapacitors { get; set; }//
        public int InutNumber { get; set; }//ei
        public int ItutNumber { get; set; }//ji
        public int InunNumber { get; set; }//eu
        public int ItunNumber { get; set; }//ju
        public int IdTransformers { get; set; }//tri
        public int IdOperationalAmplifiers { get; set; }//oui
        public int Transformers { get; set; }//tr
        public int OperationalAmplifiers { get; set; }//ou
        public int UpTransistors { get; set; }//tu
        public int BpTransistors { get; set; }//tb

        public ElementsContainer Elements { get; set; }

        public InOut InOut { get; set; }//lp,lm,kp,km

        public List<double> F { get; set; } //f

        public Complex[,] W = new Complex[M + 1, M + 1];

        public double Om { get; set; }
        public double[,] A { get; set; } = new double[M + 1, M + 1];
        public double[,] B { get; set; } = new double[M + 1, M + 1];


        public double[] Kum { get; set; } = new double[MF + 1];
        public double[] Kua { get; set; } = new double[MF + 1];
        public double[] Rim { get; set; } = new double[MF + 1];
        public double[] Ria { get; set; } = new double[MF + 1];
        public double[] Rom { get; set; } = new double[MF + 1];
        public double[] Roa { get; set; } = new double[MF + 1];
    }
}
