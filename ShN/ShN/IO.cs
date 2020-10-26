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
                OnePlus = Int32.Parse(m_lp.Text),
                OneMinus = Int32.Parse(m_lm.Text),
                KPlus = Int32.Parse(m_kp.Text),
                KMinus = Int32.Parse(m_km.Text)
            };
            this.Close();
        }
    }
}
