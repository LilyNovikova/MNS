using System;
using System.Windows.Forms;

namespace ShN
{
    public partial class Browser : Form
    {
        private const string Local = "http://localhost/MF/";
        private const string ReplaceLocal = "D:\\html\\";

        public Browser()
        {
            InitializeComponent();
            expectionLbl.Visible = false;
        }

        private void IDC_INP_Click(object sender, EventArgs e)
        {
            var str = IDC_COMBO.Text;
            var address = str.Replace(Local, ReplaceLocal);
            IDC_COMBO.Items.Add(str);
            IDC_EXPLORER.Navigate(address);
            IDC_PROGRESS.Visible = true;
            expectionLbl.Visible = false;
        }

        private void IDC_EXPLORER_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            IDC_PROGRESS.Minimum = 0;
            IDC_PROGRESS.Maximum = 100;
            IDC_PROGRESS.Step = 0;
            IDC_PROGRESS.Value = 0;
        }

        private void IDC_EXPLORER_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            IDC_PROGRESS.Value = 0;
        }

        private void IDC_EXPLORER_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                if (e.MaximumProgress != 0)
                {
                    IDC_PROGRESS.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
                }
            }
            catch (ArgumentOutOfRangeException exception)
            {
                IDC_PROGRESS.Visible = false;
                expectionLbl.Visible = true;
                expectionLbl.Text =
                    $@"Invalid progress values. Max: {e.MaximumProgress}, current: {e.CurrentProgress}";
            }

        }

        private void IDC_FORWARD_Click(object sender, EventArgs e)
        {
            IDC_EXPLORER.GoForward();
        }

        private void IDC_BACK_Click(object sender, EventArgs e)
        {
            IDC_EXPLORER.GoBack();
        }

        private void IDC_STOP_Click(object sender, EventArgs e)
        {
            IDC_EXPLORER.Stop();
            IDC_PROGRESS.Value = 0;
        }

        private void IDC_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
