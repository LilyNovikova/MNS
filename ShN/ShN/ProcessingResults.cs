﻿using ShN.DataModels;
using ShN.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShN
{
    public partial class ProcessingResults : Form
    {
        private Parameters parameters;
        public ProcessingResults(Parameters parameters)
        {
            this.parameters = parameters;
            InitializeComponent();
            Calculate();
            resultsLbl.Text = CreateText();
            // File.WriteAllText("d:\\out222.txt", CreateText());
        }

        private void St()
        {
           // LogW($"d:\\w3-1_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.txt");

            var cn = new Complex(0, 0);

            for (var k = parameters.N; k >= 3; k--)
            {
                var l = k;
                var g = 0.001;
                while (parameters.W[l, k].Abs <= g)
                {
                    l--;
                    if (l == 2)
                    {
                        l = k;
                        g *= 0.1;
                    }
                }
                if (l != k)
                {
                    for (int j = k; j <= parameters.N; j++)
                    {
                        //swap
                        var t = parameters.W[k, j];
                        parameters.W[k, j] = parameters.W[l, j];
                        parameters.W[l, j] = t;
                    }
                }
                for (int i = k - 1; i >= 1; i--)
                {
                    if (parameters.W[i, k] == cn) continue;
                    var c = parameters.W[i, k] / parameters.W[k, k];
                    for (int j = 1; j <= k - 1; j++)
                    {
                        if (parameters.W[k, j] != cn)
                        {
                            parameters.W[i, j] -= c * parameters.W[k, j];
                        }
                    }
                }
            }

            // LogW($"d:\\w2-2_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.txt");
        }

        private void Sf1(int kf)
        {
            var ku = -parameters.W[2, 1] / parameters.W[2, 2];
            var d = parameters.W[1, 1] * parameters.W[2, 2] - parameters.W[2, 1] * parameters.W[1, 2];
            var ri = parameters.W[2, 2] / d;
            var ro = parameters.W[1, 1] / d;
            parameters.Kum[kf] = ku.Abs;
            parameters.Kua[kf] = ku.Arg * 180.0f / Math.PI;
            parameters.Rim[kf] = ri.Abs;
            parameters.Ria[kf] = ri.Arg * 180.0f / Math.PI;
            parameters.Rom[kf] = ro.Abs;
            parameters.Roa[kf] = ro.Arg * 180.0f / Math.PI;
        }

        private void Gauss1(int kf)
        {
            // LogW($"d:\\w3_{kf}-gauss_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.txt");
            var cn = new Complex(0, 0);
            for (var k = 1; k < parameters.N; k++)
            {
                var l = k;
                for (var i = k + 1; i <= parameters.N; i++)
                {
                    if (parameters.W[i, k].Abs > parameters.W[l, k].Abs)
                    {
                        l = i;
                    }
                }
                if (l != k)
                {
                    for (var i = 0; i <= parameters.N; i++)
                    {
                        if (i == 0 || i >= k)
                        {
                            var t = parameters.W[k, i];
                            parameters.W[k, i] = parameters.W[l, i];
                            parameters.W[l, i] = t;
                        }
                    }
                }
                var d = 1.0 / parameters.W[k, k];//
                for (var i = k + 1; i <= parameters.N; i++)
                {
                    if (parameters.W[i, k] == cn) continue;
                    var c = parameters.W[i, k] * d;
                    for (var j = k + 1; j <= parameters.N; j++)
                    {
                        if (parameters.W[k, j] != cn)
                        {
                            parameters.W[i, j] -= c * parameters.W[k, j];
                        }
                    }
                    if (parameters.W[k, 0] != cn)
                    {
                        parameters.W[i, 0] -= c * parameters.W[k, 0];
                    }
                }
            }
            parameters.W[0, parameters.N] = -parameters.W[parameters.N, 0] / parameters.W[parameters.N, parameters.N];//
            for (var i = parameters.N - 1; i >= 1; i--)
            {
                var t = parameters.W[i, 0];
                for (var j = i + 1; j <= parameters.N; j++)
                {
                    t += parameters.W[i, j] * parameters.W[0, j];
                }
                parameters.W[0, i] = -t / parameters.W[i, i];//
            }

            // LogW($"d:\\w3_{kf}-2gauss_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.txt");
        }

        private void Gauss()
        {
            //  LogW($"d:\\w3-gauss_{DateTime.Now.ToString("yyyyMMdd_hhmmss")}.txt");
            var cn = new Complex();

            // Прямой ход
            for (var k = 1; k < parameters.N; k++)
            {
                var l = k;
                for (var i = k + 1; i <= parameters.N; i++)
                {
                    if (parameters.W[i, k].Abs > parameters.W[l, k].Abs)
                    {
                        l = i;
                    }
                }
                if (l != k)
                {
                    for (var j = 0; j <= parameters.N; j++)
                    {
                        if (j == 0 || j >= k)
                        {
                            var t = parameters.W[k, j];
                            parameters.W[k, j] = parameters.W[l, j];
                            parameters.W[l, j] = t;
                        }
                    }
                }
                var d0 = parameters.W[k, k];
                var d = 1.0 / parameters.W[k, k];
                for (var i = k + 1; i <= parameters.N; i++)
                {
                    if (parameters.W[i, k] == cn) continue;
                    var c = parameters.W[i, k] * d;
                    for (var j = k + 1; j <= parameters.N; j++)
                    {
                        if (parameters.W[k, j] != cn)
                        {
                            parameters.W[i, j] = parameters.W[i, j] - c * parameters.W[k, j];
                        }
                    }
                    if (parameters.W[k, 0] != cn)
                    {
                        parameters.W[i, 0] = parameters.W[i, 0] - c * parameters.W[k, 0];
                    }
                }
            }

            // Обратный ход
            parameters.W[0, parameters.N] = -parameters.W[parameters.N, 0] / parameters.W[parameters.N, parameters.N];
            for (var i = parameters.N - 1; i >= 1; i--)
            {
                var t = parameters.W[i, 0];
                for (var j = i + 1; j <= parameters.N; j++)
                {
                    t += parameters.W[i, j] * parameters.W[0, j];
                }
                parameters.W[0, i] = -t / parameters.W[i, i];
            }
        }

        private void LogW(string file)
        {
            var txtW = string.Empty;
            var diagonal = string.Empty;
            for (var i = 0; i <= Parameters.M; i++)
            {
                for (var j = 0; j <= Parameters.M; j++)
                {
                    var value = parameters.W[i, j].ToString();
                    txtW += value + "          ".Substring(0, value.Length < 10 ? 10 - value.Length : 1);
                    if (i == j)
                    {
                        diagonal += value + "; ";
                    }
                }
                txtW += Environment.NewLine;
            }
            var sb = new StringBuilder();
            sb.AppendLine(diagonal);
            sb.AppendLine("\n\nW2");
            sb.AppendLine(txtW);
            File.WriteAllText(file, sb.ToString());
        }

        private void Sf2(int kf)
        {
            var ri = parameters.W[0, parameters.InOut.LPlus] - parameters.W[0, parameters.InOut.LMinus];
            var ku = (parameters.W[0, parameters.InOut.KPlus] - parameters.W[0, parameters.InOut.KMinus]) / ri;
            parameters.Kum[kf] = ku.Abs;
            parameters.Kua[kf] = ku.Arg * 180.0f / Math.PI;
            parameters.Rim[kf] = ri.Abs;
            parameters.Ria[kf] = ri.Arg * 180.0f / Math.PI;
        }

        private string CreateText()
        {
            var sb = new StringBuilder();
            sb.AppendLine(DateTime.Now.ToString("yy.MM.dd hh.mm.ss"));
            sb.AppendLine("Описание компонентов");
            sb = AddComponents(sb);


            sb.AppendLine("Результаты моделирования");
            if ((parameters.InOut.LPlus == 1) && (parameters.InOut.LMinus == 0) && (parameters.InOut.KPlus == 2) && (parameters.InOut.KMinus == 0))
            {
                sb.AppendLine("      f кГц          kum       kua               rim            ria             rom          roa");
                for (var kf = 0; kf < parameters.F.Count; kf++)
                {
                    sb.AppendLine(string.Format("{0,10:F3}{1,12:F3}{2,10:F3}" +
                                "{3,12:F3}{4,10:F3}{5,12:F3}{6,10:F3}",
                                  parameters.F[kf], parameters.Kum[kf], parameters.Kua[kf], parameters.Rim[kf],
                                  parameters.Ria[kf], parameters.Rom[kf], parameters.Roa[kf]));
                }
            }

            else
            {
                sb.AppendLine("_____f кГц__________kum_________kua________rim________ria");
                for (int kf = 0; kf < parameters.F.Count; kf++)
                {
                    sb.AppendLine(string.Format("{0,10:F3}{1,20:F3}{2,20:F3}{3,20:F3}{4,20:E6}",
                            parameters.F[kf], parameters.Kum[kf], parameters.Kua[kf], parameters.Rim[kf], parameters.Ria[kf]));
                }
            }
            return sb.ToString();
        }

        private void Write()
        {
            var fout = new StreamWriter("PR.txt");
            fout.Write(CreateText());
            MessageBox.Show("Описание и результаты выведены в файл  PR.txt");
        }

        private StringBuilder AddComponents(StringBuilder sb)
        {
            sb.AppendLine("Описание компонентов");
            if (parameters.NumResistors != 0)
            {
                sb.AppendLine("Resistors");

                sb.AppendLine("           n+        n-     R(ком)");

                foreach (var resistor in parameters.Elements.Resistors)
                {
                    sb.AppendLine(string.Format("R{0:D}{1,10:D}{2,10:D}{3,10:F}",
                        resistor.Id, resistor.PlusNode, resistor.MinusNode, resistor.Z));
                }
            }

            if (parameters.NumCapacitors != 0)
            {
                sb.AppendLine("Capacitors");

                sb.AppendLine("           n+        n-     Z");

                foreach (var capacitor in parameters.Elements.Capacitors)
                {
                    sb.AppendLine(string.Format("C{0:D}{1,10:D}{2,10:D}{3,10:F}",
                        capacitor.Id, capacitor.PlusNode, capacitor.MinusNode, capacitor.Z));
                }
            }

            if (parameters.NumInductors != 0)
            {
                sb.AppendLine("Inductors");

                sb.AppendLine("           n+        n-     Z");

                foreach (var inductor in parameters.Elements.Inductors)
                {
                    sb.AppendLine(string.Format("L{0:D}{1,10:D}{2,10:D}{3,10:F}",
                        inductor.Id, inductor.PlusNode, inductor.MinusNode, inductor.Z));
                }
            }

            return sb;
        }

        private void FormRLC(List<SimpleElement> elements)
        {
            if (elements.Any())
            {
                var type = elements.First().Type;
                var elementsWithEmptyFirstItem = new List<SimpleElement>() { new SimpleElement() }.Concat(elements).ToList();
                var nd = elements.Count;
                var in_d = elementsWithEmptyFirstItem.Select(el => el.GetNodes()).ToArray();
                var z_d = elementsWithEmptyFirstItem.Select(el => el.Z).ToArray();


                if (type != ElementType.Inductor)
                {
                    for (var kd = 1; kd <= nd; kd++)
                    {
                        for (var l = 0; l <= 1; l++)
                        {
                            var i = in_d[kd][l];
                            if (i == 0) continue;
                            for (var m = 0; m <= 1; m++)
                            {
                                var j = in_d[kd][m];
                                if (j == 0) continue;
                                var g = (1 - 2 * l) * (1 - 2 * m);
                                switch (type)
                                {
                                    case ElementType.Resistor:
                                        parameters.A[i, j] += g / z_d[kd];
                                        break;
                                    case ElementType.Capacitor:
                                        parameters.B[i, j] += g * z_d[kd];
                                        break;
                                    default: throw new ArgumentException($"Unexpected element type '{type}'");
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int kd = 1; kd <= nd; kd++)
                    {
                        var i = parameters.N + kd;
                        parameters.B[i, i] = z_d[kd];
                        for (var m = 0; m <= 1; m++)
                        {
                            var j = in_d[kd][m];
                            if (j == 0) continue;
                            var g = 1 - 2 * m;
                            parameters.A[i, j] -= g;
                            parameters.A[j, i] += g;
                        }
                    }
                    parameters.N += nd;
                }
            }
        }

        //eu-w
        private void FormEuW(List<EuW> elements)
        {
            var elementsWithEmptyFirstItem = new List<EuW>() { new EuW() }.Concat(elements).ToList();
            var in_eu = elementsWithEmptyFirstItem.Select(el => el.GetNodes()).ToArray();
            var z_eu = elementsWithEmptyFirstItem.Select(element => element.GetZ()).ToArray();

            for (var keu = 1; keu <= parameters.InunNumber; keu++)
            {
                var i = parameters.N + keu;
                for (var m = 0; m <= 3; m++)
                {
                    var j = in_eu[keu][m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        var g = 1 - 2 * m;
                        parameters.A[i, j] += g * z_eu[keu][0];
                        parameters.B[i, j] += g * z_eu[keu][0] * z_eu[keu][1];
                    }
                    else
                    {
                        var g = 5 - 2 * m;
                        parameters.A[i, j] -= g;
                        parameters.A[j, i] += g;
                        parameters.B[i, j] -= g * z_eu[keu][2];
                    }
                }
            }
            parameters.N += parameters.InunNumber;
        }

        //ei
        private void FormEi(List<Ei> elements)
        {
            var elementsWithEmptyFirstItem = new List<Ei>() { new Ei() }.Concat(elements).ToList();
            var in_ei = elementsWithEmptyFirstItem.Select(el => el.GetNodes()).ToArray();
            var z_ei = elementsWithEmptyFirstItem.Select(element => element.Y).ToArray();

            for (var kei = 1; kei <= parameters.InutNumber; kei++)
            {
                var i1 = parameters.N + kei;
                var i2 = i1 + parameters.InutNumber;
                parameters.A[i2, i1] = z_ei[kei];
                for (var m = 0; m < 4; m++)
                {
                    var j = in_ei[kei][m];
                    if (j == 0) continue;
                    if (m < 2)
                    {
                        var g = 1 - 2 * m;
                        parameters.A[i1, j] -= g;
                        parameters.A[j, i1] += g;
                    }
                    else
                    {
                        var g = 5 - 2 * m;
                        parameters.A[i2, j] -= g;
                        parameters.A[j, i2] += g;
                    }
                }
            }
            parameters.N += 2 * parameters.InutNumber;
        }

        //oui
        private void FormOui(List<Oui> elements)
        {
            var elementsWithEmptyFirstItem = new List<Oui>() { new Oui() }.Concat(elements).ToList();
            var in_oui = elementsWithEmptyFirstItem.Select(el => el.GetNodes()).ToArray();
            for (var koui = 1; koui <= parameters.IdOperationalAmplifiers; koui++)
            {
                var j1 = parameters.N + koui;
                var j2 = j1 + parameters.IdOperationalAmplifiers;
                parameters.A[j2, j1] = -1;
                for (var l = 0; l <= 3; l++)
                {
                    var i = in_oui[koui][l];
                    if (i == 0) continue;
                    if (l < 2)
                    {
                        var g = 1 - 2 * l;
                        parameters.A[i, j1] += g;
                        parameters.A[j1, i] -= g;
                    }
                    else
                    {
                        var g = 5 - 2 * l;
                        parameters.A[i, j2] += g;
                    }
                }
            }
            parameters.N += 2 * parameters.IdOperationalAmplifiers;
        }

        //tu       
        private void FormTu(List<Tu> elements)
        {
            var ay = new double[4, 4];
            var by = new double[4, 4];
            var in_d = new[,] { { 2, 3 }, { 1, 3 }, { 1, 2 }, { 2, 3 } };
            var in_ju = new[] { 1, 3, 2, 3 };
            var elementsWithEmptyFirstItem = new List<Tu>() { new Tu() }.Concat(elements).ToList();
            var z_tu = elementsWithEmptyFirstItem.Select(el => el.GetZ()).ToArray();
            var in_tu = elementsWithEmptyFirstItem.Select(el => el.GetNodes()).ToArray();

            for (var ktu = 1; ktu <= parameters.UpTransistors; ktu++)
            {
                for (var i = 1; i <= 3; i++)
                {
                    for (var j = 1; j <= 3; j++)
                    {
                        ay[i, j] = 0;
                        by[i, j] = 0;
                    }
                }
                for (var k = 0; k <= 3; k++)
                {
                    for (var l = 0; l <= 1; l++)
                    {
                        var i = in_d[k, l];
                        for (var m = 0; m <= 1; m++)
                        {
                            var j = in_d[k, m];
                            var g = (1 - 2 * l) * (1 - 2 * m);
                            if (k == 0)
                            {
                                ay[i, j] += g / z_tu[ktu][k];
                            }
                            else
                            {
                                by[i, j] += g * z_tu[ktu][k];
                            }
                        }
                    }
                }
                for (var l = 2; l <= 3; l++)
                {
                    var i = in_ju[l];
                    for (var m = 0; m <= 1; m++)
                    {
                        var j = in_ju[m];
                        var g = (5 - 2 * l) * (1 - 2 * m);
                        ay[i, j] += g * z_tu[ktu][4];
                    }
                }

                for (var i = 1; i <= 3; i++)
                {
                    var ii = in_tu[ktu][i];
                    if (ii == 0) continue;
                    for (var j = 1; j <= 3; j++)
                    {
                        var jj = in_tu[ktu][j];
                        if (jj == 0) continue;
                        parameters.A[ii, jj] += ay[i, j];
                        parameters.B[ii, jj] += by[i, j];
                    }
                }
            }
        }

        //s
        private void FormS()
        {
            for (int i = 1; i <= parameters.N; i++)
            {
                parameters.W[i, 0] = new Complex(0, 0);
            }
            if (parameters.InOut.LPlus != 0)
            {
                parameters.W[parameters.InOut.LPlus, 0] = new Complex(-1, 0);
            }
            if (parameters.InOut.LMinus != 0)
            {
                parameters.W[parameters.InOut.LMinus, 0] = new Complex(1, 0);
            }
        }

        private void FormW()
        {
            for (var i = 0; i <= Parameters.M; i++)
            {
                for (var j = 0; j <= Parameters.M; j++)
                {
                    var t = parameters.B[i, j];
                    if (t != 0) t *= parameters.Om;
                    var a = parameters.A[i, j];
                    parameters.W[i, j] = new Complex(a, t);
                }
            }
        }

        private void Calculate()
        {
            parameters.A = new double[Parameters.M + 1, Parameters.M + 1];
            parameters.B = new double[Parameters.M + 1, Parameters.M + 1];
            parameters.W = new Complex[Parameters.M + 1, Parameters.M + 1];

            for (var kf = 0; kf < parameters.F.Count; kf++)
            {
                SetAllToZero();
                parameters.N = parameters.NumNodes;
                parameters.Om = 2 * Math.PI * parameters.F[kf];
                parameters.Elements.Resistors.Do(FormRLC);
                //  FormW();
                //  LogW($"d:\\r_{kf}.txt");
                parameters.Elements.Inductors.Do(FormRLC);
                //   FormW();
                // LogW($"d:\\l_{kf}.txt");
                parameters.Elements.Capacitors.Do(FormRLC);
                //   FormW();
                //  LogW($"d:\\c_{kf}.txt");
                parameters.Elements.Ei.Do(FormEi);
                //   FormW();
                //   LogW($"d:\\ei_{kf}.txt");
                parameters.Elements.EuW.Do(FormEuW);
                //  FormW();
                //  LogW($"d:\\eu_{kf}.txt");
                parameters.Elements.Oui.Do(FormOui);
                //   FormW();
                // LogW($"d:\\oui_{kf}.txt");
                parameters.Elements.Tu.Do(FormTu);
                //   FormW();
                // LogW($"d:\\tu_{kf}.txt");
                FormW();
                FormS();

                if ((parameters.InOut.LPlus == 1) && (parameters.InOut.LMinus == 0) && (parameters.InOut.KPlus == 2) && (parameters.InOut.KMinus == 0))
                {
                    St();
                    Sf1(kf);
                }
                else
                {
                    Gauss();
                    Sf2(kf);
                }
            }
        }

        private void SetAllToZero()
        {
            for (int i = 0; i <= Parameters.M; i++)
            {
                for (int j = 0; j <= Parameters.M; j++)
                {
                    parameters.A[i, j] = 0;
                    parameters.B[i, j] = 0;
                    parameters.W[i, j] = new Complex();
                }
            }
        }

        private void resultsLbl_Click(object sender, EventArgs e)
        {

        }
    }
}