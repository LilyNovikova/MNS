using ShN.DataModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShN
{
    public partial class ElementsParameters : Form
    {
        private Parameters parameters;
        public List<SimpleElement> Resistors { get; set; } = new List<SimpleElement>();
        public List<SimpleElement> Inductors { get; set; } = new List<SimpleElement>();
        public List<SimpleElement> Capacitors { get; set; } = new List<SimpleElement>();
        public ElementsParameters(Parameters parameters)
        {
            this.parameters = parameters;
            InitializeComponent();
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {
            var currentId = int.Parse(m_nextr.Text);
            if (currentId <= parameters.NumResistors)
            {
                Resistors.Add(ReadElementData(ElementType.Resistor, parameters.NumResistors, Resistors.Count));
            }
            else if (currentId <= parameters.NumCapacitors + parameters.NumResistors)
            {
                Capacitors.Add(ReadElementData(ElementType.Capacitor, parameters.NumCapacitors, Capacitors.Count));
            }
            else if (currentId <= parameters.NumCapacitors + parameters.NumResistors + parameters.NumInductors)
            {
                Inductors.Add(ReadElementData(ElementType.Inductor, parameters.NumInductors, Inductors.Count));
            }

            if (currentId == parameters.NumCapacitors + parameters.NumResistors + parameters.NumInductors)
            {
                Close();
            }

            if (currentId == parameters.NumResistors)
            {
                elementTypeTxt.Text = ElementType.Capacitor.ToString();
                valueLbl.Text = "Ёмкость (мкФ)";
            }
            else if (currentId == parameters.NumCapacitors + parameters.NumResistors)
            {
                elementTypeTxt.Text = ElementType.Inductor.ToString();
                valueLbl.Text = "Индкутивность (Гн)";
            }
        }

        private SimpleElement ReadElementData(ElementType type, int numberOfElements, int currentId)
        {
            var element = new SimpleElement
            {
                Id = currentId + 1,
                PlusNode = int.Parse(m_npr.Text),
                MinusNode = int.Parse(m_nmr.Text),
                Z = double.Parse(m_zr.Text),
                Type = type
            };
            m_nextr.Text = (int.Parse(m_nextr.Text) + 1).ToString();
            m_npr.Text = "0";
            m_nmr.Text = "0";
            m_zr.Text = "0";
            m_npr.Focus();
            return element;
        }
    }
}
