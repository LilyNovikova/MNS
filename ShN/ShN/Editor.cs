using ShN.DataModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ShN
{
    public partial class Editor : Form
    {
        public Parameters Parameters { get; }
        public Editor(Parameters parameters)
        {
            InitializeComponent();
            Parameters = parameters;
            IDC_ZR_STATIC.Show();
            IDC_ZC_STATIC.Hide();
            IDC_ZI_STATIC.Hide();
            IDC_IN.Enabled = false;
        }

        private void m_redlst_DoubleClick(object sender, EventArgs e)
        {
            var elementType = (ElementType)m_redlst.SelectedItem;
            switch (elementType)
            {
                case ElementType.Resistor:
                    IDC_ZR_STATIC.Show();
                    IDC_ZC_STATIC.Hide();
                    IDC_ZI_STATIC.Hide();
                    m_n.Focus();
                    break;
                case ElementType.Capacitor:
                    IDC_ZR_STATIC.Hide();
                    IDC_ZC_STATIC.Show();
                    IDC_ZI_STATIC.Hide();
                    m_n.Focus();
                    break;
                case ElementType.Inductor:
                    IDC_ZR_STATIC.Hide();
                    IDC_ZC_STATIC.Hide();
                    IDC_ZI_STATIC.Show();
                    m_n.Focus();
                    break;
            }
        }

        private void IDC_OUT_Click(object sender, EventArgs e)
        {
            var elementType = (ElementType)m_redlst.SelectedItem;
            var index = Int32.Parse(m_n.Text);
            SimpleElement element = null;
            switch (elementType)
            {
                case ElementType.Resistor:
                    element = Parameters.Resistors.FirstOrDefault(el => el.Id == index);
                    break;
                case ElementType.Capacitor:
                    element = Parameters.Capacitors.FirstOrDefault(el => el.Id == index);
                    break;
                case ElementType.Inductor:
                    element = Parameters.Inductors.FirstOrDefault(el => el.Id == index);
                    break;
            }

            if (element != null)
            {
                m_np1.Text = element.PlusNode.ToString();
                m_nm1.Text = element.MinusNode.ToString();
                m_z1.Text = element.Z.ToString();
                IDC_IN.Enabled = true;
            }
            else
            {
                infoLbl.Text = $@"No {elementType} with id {index}";
            }
        }

        private void IDC_IN_Click(object sender, EventArgs e)
        {
            var elementType = (ElementType)m_redlst.SelectedItem;
            var index = Int32.Parse(m_n.Text);
            var element = new SimpleElement()
            {
                PlusNode = Int32.Parse(m_np1.Text),
                MinusNode = Int32.Parse(m_nm1.Text),
                Z = double.Parse(m_z1.Text),
                Id = index,
                Type = elementType
            };
            switch (elementType)
            {
                case ElementType.Resistor:
                    Parameters.Resistors = Parameters.Resistors.Select(el => el.Id == index ? element : el).ToList();
                    break;
                case ElementType.Capacitor:
                    Parameters.Capacitors = Parameters.Capacitors.Select(el => el.Id == index ? element : el).ToList();
                    break;
                case ElementType.Inductor:
                    Parameters.Inductors = Parameters.Inductors.Select(el => el.Id == index ? element : el).ToList();
                    break;
            }

            IDC_IN.Enabled = false;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
