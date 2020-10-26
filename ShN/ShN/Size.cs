using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShN.DataModels;

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
            Parameters.NumNodes = Int32.Parse(numNodes.Text);
            Parameters.NumResistors = Int32.Parse(resistors.Text);
            Parameters.NumInductors = Int32.Parse(inductors.Text);
            Parameters.NumCapacitors = Int32.Parse(capacitors.Text);
            Parameters.Inun = Int32.Parse(inun.Text);
            Parameters.Itun = Int32.Parse(itun.Text);
            Parameters.Itut = Int32.Parse(itut.Text);
            Parameters.Inut = Int32.Parse(inut.Text);
            Parameters.Transformers = Int32.Parse(transformers.Text);
            Parameters.BpTransistors = Int32.Parse(bpTransistors.Text);
            Parameters.UpTransistors = Int32.Parse(upTransistors.Text);
            Parameters.OperationalAmplifiers = Int32.Parse(operationalAmplifiers.Text);
            Parameters.IdTransformers = Int32.Parse(idTransformers.Text);
            Parameters.IdOperationalAmplifiers = Int32.Parse(idOperationalAmplifiers.Text);
            Parameters.Resistors = new List<Element>();
            Parameters.Inductors=new List<Element>();
            Parameters.Capacitors = new List<Element>();
            this.Close();
        }
    }
}
