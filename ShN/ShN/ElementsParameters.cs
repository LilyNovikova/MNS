using ShN.DataModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShN
{
    public partial class ElementsParameters : Form
    {
        private Parameters parameters;
        private Label[] labels;
        private TextBox[] textBoxes;

        public ElementsContainer ElementsContainer { get; private set; }


        public ElementsParameters(Parameters parameters)
        {
            this.parameters = parameters;
            InitializeComponent();
            ElementsContainer = new ElementsContainer();

            labels = new[] { label0, label1, label2, label3, label4, label5, label6, label7 };
            textBoxes = new[] { txt0, txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            SetValueForLabels("n+", "n-", "Сопротивление (кОм)");
            HideLastElements(5);
            elementTypeTxt.Text = ElementType.Resistor.ToString();
            elementId.Text = "0";
        }

        private void SetView()
        {
            if (parameters.NumResistors > 0 && (ElementsContainer.Resistors != null ? ElementsContainer.Resistors.Count : 0) < parameters.NumResistors)
            {
                elementTypeTxt.Text = ElementType.Resistor.ToString();
                SetValueForLabels("n+", "n-", "Сопротивление (кОм)");
                HideLastElements(5);
            }

            else if (parameters.NumCapacitors > 0 && (ElementsContainer.Capacitors != null ? ElementsContainer.Capacitors.Count : 0) < parameters.NumCapacitors)
            {
                elementTypeTxt.Text = ElementType.Capacitor.ToString();
                SetValueForLabels("n+", "n-", "Ёмкость (мкФ)");
                HideLastElements(5);
            }

            else if (parameters.NumInductors > 0 && (ElementsContainer.Inductors != null ? ElementsContainer.Inductors.Count : 0) < parameters.NumInductors)
            {
                elementTypeTxt.Text = ElementType.Inductor.ToString();
                SetValueForLabels("n+", "n-", "Индкутивность (Гн)");
                HideLastElements(5);
            }

            else if (parameters.InunNumber > 0 && (ElementsContainer.EuW != null ? ElementsContainer.EuW.Count : 0) < parameters.InunNumber)
            {
                elementTypeTxt.Text = ElementType.EuW.ToString();
                SetValueForLabels("n1+", "n1-", "n2+", "n2-", "Y", "T0", "T1");
                HideLastElements(1);
            }

            else if (parameters.InutNumber > 0 && (ElementsContainer.Ei != null ? ElementsContainer.Ei.Count : 0) < parameters.InutNumber)
            {
                elementTypeTxt.Text = ElementType.Ei.ToString();
                SetValueForLabels("n1+", "n1-", "n2+", "n2-", "Y");
                HideLastElements(3);
            }

            else if (parameters.IdOperationalAmplifiers > 0 && (ElementsContainer.Oui != null ? ElementsContainer.Oui.Count : 0) < parameters.IdOperationalAmplifiers)
            {
                elementTypeTxt.Text = ElementType.Ei.ToString();
                SetValueForLabels("n1+", "n1-", "n2+", "n2-");
                HideLastElements(4);
            }

            else if (parameters.UpTransistors > 0 && (ElementsContainer.Tu != null ? ElementsContainer.Tu.Count : 0) < parameters.UpTransistors)
            {
                elementTypeTxt.Text = ElementType.Tu.ToString();
                SetValueForLabels("nZ", "nS", "nI", "Rc", "Czi", "Czs", "Csi", "S");
                HideLastElements(0);
            }
            else
            {
                Close();
            }
        }

        private void IDC_NEXTR_BUTTON_Click(object sender, EventArgs e)
        {            
            var currentId = int.Parse(elementId.Text); ;
            if (parameters.NumResistors > 0 && (ElementsContainer.Resistors != null ? ElementsContainer.Resistors.Count : 0) < parameters.NumResistors)
            {
                elementTypeTxt.Text = ElementType.Resistor.ToString();
                SetValueForLabels("n+", "n-", "Сопротивление (кОм)");
                HideLastElements(5);
                ElementsContainer.Resistors = ElementsContainer.Resistors ?? new List<SimpleElement>();
                var element = ReadRLC(ElementType.Resistor);
                ElementsContainer.Resistors.Add(element);
            }

            else if (parameters.NumCapacitors > 0 && (ElementsContainer.Capacitors != null ? ElementsContainer.Capacitors.Count : 0) < parameters.NumCapacitors)
            {
                elementTypeTxt.Text = ElementType.Capacitor.ToString();
                SetValueForLabels("n+", "n-", "Ёмкость (мкФ)");
                HideLastElements(5);
                ElementsContainer.Capacitors = ElementsContainer.Capacitors ?? new List<SimpleElement>();
                var element = ReadRLC(ElementType.Capacitor);
                ElementsContainer.Capacitors.Add(element);
            }

            else if (parameters.NumInductors > 0 && (ElementsContainer.Inductors != null ? ElementsContainer.Inductors.Count : 0) < parameters.NumInductors)
            {
                elementTypeTxt.Text = ElementType.Inductor.ToString();
                SetValueForLabels("n+", "n-", "Индкутивность (Гн)");
                HideLastElements(5);
                ElementsContainer.Inductors = ElementsContainer.Inductors ?? new List<SimpleElement>();
                var element = ReadRLC(ElementType.Inductor);
                ElementsContainer.Inductors.Add(element);
            }

            else if (parameters.InunNumber > 0 && (ElementsContainer.EuW != null ? ElementsContainer.EuW.Count : 0) < parameters.InunNumber)
            {
                elementTypeTxt.Text = ElementType.EuW.ToString();
                SetValueForLabels("n1+", "n1-", "n2+", "n2-", "Y", "T0", "T1");
                HideLastElements(1);
                ElementsContainer.EuW = ElementsContainer.EuW ?? new List<EuW>();
                var element = new EuW
                {
                    Id = currentId,
                    PlusNode1 = int.Parse(txt0.Text),
                    MinusNode1 = int.Parse(txt1.Text),
                    PlusNode2 = int.Parse(txt2.Text),
                    MinusNode2 = int.Parse(txt3.Text),
                    Y = double.Parse(txt4.Text),
                    T1 = double.Parse(txt5.Text),
                    T2 = double.Parse(txt6.Text),
                    Type = ElementType.EuW
                };
                elementId.Text = (int.Parse(elementId.Text) + 1).ToString();
                SetValueForTextBoxes(7);
                txt0.Focus();
                ElementsContainer.EuW.Add(element);
            }

            else if (parameters.InutNumber > 0 && (ElementsContainer.Ei != null ? ElementsContainer.Ei.Count : 0) < parameters.InutNumber)
            {
                elementTypeTxt.Text = ElementType.Ei.ToString();
                SetValueForLabels("n1+", "n1-", "n2+", "n2-", "Y");
                HideLastElements(3);
                ElementsContainer.Ei = ElementsContainer.Ei ?? new List<Ei>();
                var element = new Ei
                {
                    Id = currentId,
                    PlusNode1 = int.Parse(txt0.Text),
                    MinusNode1 = int.Parse(txt1.Text),
                    PlusNode2 = int.Parse(txt2.Text),
                    MinusNode2 = int.Parse(txt3.Text),
                    Y = double.Parse(txt4.Text),
                    Type = ElementType.Ei
                };
                elementId.Text = (int.Parse(elementId.Text) + 1).ToString();
                SetValueForTextBoxes(5);
                txt0.Focus();
                ElementsContainer.Ei.Add(element);
            }

            else if (parameters.IdOperationalAmplifiers > 0 && (ElementsContainer.Oui != null ? ElementsContainer.Oui.Count : 0) < parameters.IdOperationalAmplifiers)
            {
                elementTypeTxt.Text = ElementType.Oui.ToString();
                SetValueForLabels("n1+", "n1-", "n2+", "n2-");
                HideLastElements(4);
                ElementsContainer.Oui = ElementsContainer.Oui ?? new List<Oui>();
                var element = new Oui
                {
                    Id = currentId,
                    PlusNode1 = int.Parse(txt0.Text),
                    MinusNode1 = int.Parse(txt1.Text),
                    PlusNode2 = int.Parse(txt2.Text),
                    MinusNode2 = int.Parse(txt3.Text),
                    Type = ElementType.Oui
                };
                elementId.Text = (int.Parse(elementId.Text) + 1).ToString();
                SetValueForTextBoxes(4);
                txt0.Focus();
                ElementsContainer.Oui.Add(element);
            }

            else if (parameters.UpTransistors > 0 && (ElementsContainer.Tu != null ? ElementsContainer.Tu.Count : 0) < parameters.UpTransistors)
            {
                elementTypeTxt.Text = ElementType.Tu.ToString();
                SetValueForLabels("nZ", "nS", "nI", "Rc", "Czi", "Czs", "Csi", "S");
                HideLastElements(0);
                ElementsContainer.Tu = ElementsContainer.Tu ?? new List<Tu>();
                var element = new Tu
                {
                    Id = currentId,
                    NodeZ = int.Parse(txt0.Text),
                    NodeS = int.Parse(txt1.Text),
                    NodeI = int.Parse(txt2.Text),
                    Rc = double.Parse(txt3.Text),
                    Czi = double.Parse(txt4.Text),
                    Czs = double.Parse(txt5.Text),
                    Csi = double.Parse(txt6.Text),
                    S = double.Parse(txt7.Text),
                    Type = ElementType.Tu
                };
                elementId.Text = (int.Parse(elementId.Text) + 1).ToString();
                SetValueForTextBoxes(8);
                txt0.Focus();
                ElementsContainer.Tu.Add(element);
            }
            SetView();

            SimpleElement ReadRLC(ElementType type)
            {
                var element = new SimpleElement
                {
                    Id = currentId,
                    PlusNode = int.Parse(txt0.Text),
                    MinusNode = int.Parse(txt1.Text),
                    Z = double.Parse(txt2.Text),
                    Type = type
                };
                elementId.Text = (int.Parse(elementId.Text) + 1).ToString();
                SetValueForTextBoxes(3);
                txt0.Focus();
                return element;
            }
        }

        private void HideLastElements(int amount)
        {
            for (var i = 0; i < labels.Length - amount; i++)
            {
                labels[i].Visible = true;
                textBoxes[i].Visible = true;
            }
            for (var i = labels.Length - 1; i >= labels.Length - amount; i--)
            {
                labels[i].Visible = false;
                textBoxes[i].Visible = false;
            }
            Refresh();
        }

        private void SetValueForTextBoxes(int amount, string value = "0")
        {
            for (var i = 0; i < textBoxes.Length - amount; i++)
            {
                textBoxes[i].Text = value;
            }
            Refresh();
        }

        private void SetValueForLabels(params string[] values)
        {
            for (var i = 0; i < values.Length; i++)
            {
                labels[i].Text = values[i];
            }
            Refresh();
        }
    }
}
