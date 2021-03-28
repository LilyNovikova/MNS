using Newtonsoft.Json;
using ShN.DataModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ShN
{
    public partial class FrqvsDlg : Form
    {
        private const string FileFilter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        private Parameters parameters;
        public FrqvsDlg()
        {
            InitializeComponent();
            ID_RED.Enabled = false;
            //parameters = JsonConvert.DeserializeObject<Parameters>(File.ReadAllText("D:\\input_task3.json"));
        }

        private void ID_EXIT_Click(object sender, EventArgs e)
        {
            if (parameters != null)
            {
                SaveToFile();
            }

            Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            using (var size = new Size())
            {
                size.ShowDialog(this);
                parameters = size.Parameters;
                paramsLbl.Text = parameters.ToString();
            }

            if (parameters.NumResistors > 0)
            {
                using (var elementsParameters = new ElementsParameters(parameters))
                {
                    elementsParameters.ShowDialog(this);
                    parameters.Elements = elementsParameters.ElementsContainer;
                    paramsLbl.Text = parameters.ToString();
                }
            }
            ID_F_Click(sender, e);
            ID_IO_Click(sender, e);
            ID_RED.Enabled = true;
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            using (var editor = new Editor(parameters))
            {
                editor.ShowDialog(this);
                parameters = editor.Parameters;
                paramsLbl.Text = parameters.ToString();
            }
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = FileFilter;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    parameters = JsonConvert.DeserializeObject<Parameters>(File.ReadAllText(openFileDialog.FileName));
                    ID_RED.Enabled = true;
                }
            }
            if (parameters.F == null)
            {
                ID_F_Click(sender, e);
            }
            if (parameters.InOut == null)
            {
                ID_IO_Click(sender, e);
            }
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            using (var io = new IO())
            {
                io.ShowDialog(this);
                parameters.InOut = io.InOut;
                paramsLbl.Text = parameters.ToString();
            }
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            using (var function = new Function(parameters))
            {
                function.ShowDialog(this);
                parameters.F = function.F;
                paramsLbl.Text = parameters.ToString();
            }
        }

        private void ID_SAVE_PARAMS_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void SaveToFile()
        {
            using (var saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = FileFilter;
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, JsonConvert.SerializeObject(parameters));
                }
            }
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            using (var browser = new Browser())
            {
                browser.ShowDialog(this);
            }
        }

        private void ID_CALC_Click(object sender, EventArgs e)
        {
            using (var processing = new ProcessingResults(parameters))
            {
                processing.ShowDialog(this);
            }
        }
    }
}
