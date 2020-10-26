using System;
using System.IO;
using System.Windows.Forms;

namespace ShN
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var in_r = new[] {new[] {0, 0}, new[] {1, 2}, new[] {0, 1}};
            var nr = 2;
            var z_r = new[] {0, 0.5, 0.2};

            var res = form_r(in_r, nr, z_r);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrqvsDlg());
        }


        static double[,] form_r(int[][] in_r, int nr, double[] z_r)
        {
            int i, j, g;
            //File.AppendAllLines("d:\\mns.csv", new[] { $"kr;l;i;m;j;g;w{Environment.NewLine}" });
            var w = new double[3, 3];
            for (int kr = 1; kr <= nr; kr++)
            {
                for (int l = 0; l <= 1; l++)
                {
                    i = in_r[kr][l];
                    if (i == 0) continue;
                    for (int m = 0; m <= 1; m++)
                    {
                        j = in_r[kr][m];
                        if (j == 0) continue;
                        g = (1 - 2 * l) * (1 - 2 * m);
                        w[i, j] += g / z_r[kr];
                        var cur = w[i, j];
                        //File.AppendAllLines("d:\\mns.csv",new []{$"{kr};{l};{i};{m};{j};{g};{cur}{Environment.NewLine}"} );
                    }
                }
            }

            return w;
        }


    }
}
