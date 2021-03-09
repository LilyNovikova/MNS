using ShN.DataModels;
using System;
using System.Windows.Forms;

namespace ShN
{
    public partial class IO : Form
    {
        public InOut InOut { get; private set; }

        public IO()
        {
            InitializeComponent();
        }

        private void IDC_IOOK_BUTTON_Click(object sender, EventArgs e)
        {
            InOut = new InOut()
            {
                LPlus = Int32.Parse(m_lp.Text),
                LMinus = Int32.Parse(m_lm.Text),
                KPlus = Int32.Parse(m_kp.Text),
                KMinus = Int32.Parse(m_km.Text)
            };
            this.Close();
        }
    }
}
