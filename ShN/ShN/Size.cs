using ShN.DataModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShN
{
    public partial class Size : Form
    {
        public Parameters Parameters { get; }

        public Size()
        {
            InitializeComponent();
            Parameters = new Parameters();
        }

        private void Size_Load(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            Parameters.NumNodes = int.Parse(numNodes.Text);
            Parameters.NumResistors = int.Parse(resistors.Text);
            Parameters.NumInductors = int.Parse(inductors.Text);
            Parameters.NumCapacitors = int.Parse(capacitors.Text);
            Parameters.InunNumber = int.Parse(inun.Text);
            Parameters.ItunNumber = int.Parse(itun.Text);
            Parameters.ItutNumber = int.Parse(itut.Text);
            Parameters.InutNumber = int.Parse(inut.Text);
            Parameters.Transformers = int.Parse(transformers.Text);
            Parameters.BpTransistors = int.Parse(bpTransistors.Text);
            Parameters.UpTransistors = int.Parse(upTransistors.Text);
            Parameters.OperationalAmplifiers = int.Parse(operationalAmplifiers.Text);
            Parameters.IdTransformers = int.Parse(idTransformers.Text);
            Parameters.IdOperationalAmplifiers = int.Parse(idOperationalAmplifiers.Text);
            Parameters.Resistors = new List<SimpleElement>();
            Parameters.Inductors = new List<SimpleElement>();
            Parameters.Capacitors = new List<SimpleElement>();
            this.Close();
        }
    }
}
