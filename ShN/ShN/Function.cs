using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShN.DataModels;

namespace ShN
{
    public partial class Function : Form
    {
        private int m_f;
        private Parameters parameters;
        public List<double> F { get; set; }
        public Function(Parameters parameters)
        {
            this.parameters = parameters;
            InitializeComponent();
        }

        private void IDC_F_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 0;
            IDC_T1.Text = "Значение частоты (кгц)";
            IDC_T2.Text = "";
            IDC_T3.Text = "";
        }

        private void DF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 1;
            IDC_T1.Text = "Минимальная частота Fmin(кгц)";
            IDC_T2.Text = "Максимальная частота Fmax(кгц)";
            IDC_T3.Text = "Шаг изменения частоты dF(кгц)";
        }

        private void KF_CheckedChanged(object sender, EventArgs e)
        {
            IDC_F1.Focus();
            m_f = 2;
            IDC_T1.Text = "Минимальная частота Fmin(кгц)";
            IDC_T2.Text = "Максимальная частота Fmax(кгц)";
            IDC_T3.Text = "Отношение соседних частот K";
        }

        private void IDC_FOK_BUTTON_Click(object sender, EventArgs e)
        {
            F = new List<double>();
            var nf = 0;
            switch (m_f)
            {
                case 0:
                    F.Add(double.Parse(IDC_F1.Text));
                    nf = 1;
                    break;
                case 1:
                    var fmin1 = double.Parse(IDC_F1.Text);
                    var fmax1 = double.Parse(IDC_F2.Text);
                    var df = double.Parse(IDC_F3.Text);
                    F.Add(fmin1);
                    for (var i = 1; F[i - 1] + df <= fmax1; i++)
                    {
                        F.Add(F[i - 1] + df);
                    }
                    nf = F.Count;
                    break;
                case 2:
                    var fmin2 = double.Parse(IDC_F1.Text);
                    var fmax2 = double.Parse(IDC_F2.Text);
                    var kk = double.Parse(IDC_F3.Text);
                    F.Add(fmin2);
                    for (var i = 1; F[i - 1] * kk <= fmax2; i++)
                    {
                        F.Add(F[i - 1] * kk);
                    }
                    nf = F.Count;
                    break;
            }
            this.Close();
        }
    }
}
