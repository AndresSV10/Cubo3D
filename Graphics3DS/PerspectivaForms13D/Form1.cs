using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphics3DS;


namespace PerspectivaForms13D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Graphics g;
        Graphics3D g3;
        int esc = 5;
        Point3DF[] nodos = new Point3DF[8];
        private void Form1_load(object sender, EventArgs e)
        {
            nodos[0] = new Point3DF(-20, -20, -20);
            nodos[1] = new Point3DF(-20, -20, 20);
  /*          nodos[2] = new Point3DF(-20, 20, 20);
            nodos[3] = new Point3DF(-20, 20, -20);
            nodos[4] = new Point3DF(20, -20, -20);
            nodos[5] = new Point3DF(20, -20, 20);
            nodos[6] = new Point3DF(20, 20, 20);
            nodos[7] = new Point3DF(20, 20, -20);
  */
            
        }

 
        private void pctBox3D1_Click(object sender, EventArgs e)
        {

        }

        private void ptBox_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g3 = new Graphics3D(g); 
            e.Graphics.TranslateTransform(ptBox.Width/2, ptBox.Height/2);
            Pen pen = new Pen(Color.FromArgb(1, 94, 230), 2);
            g3.DrawLine3D(pen, nodos[0], nodos[1]);
            g3.DrawLine3D(pen, nodos[1], nodos[2]);
 /*           g3.DrawLine3D(pen, nodos[2], nodos[3]);
            g3.DrawLine3D(pen, nodos[3], nodos[0]);
            g3.DrawLine3D(pen, nodos[4], nodos[5]);
            g3.DrawLine3D(pen, nodos[5], nodos[6]);
            g3.DrawLine3D(pen, nodos[6], nodos[7]);
            g3.DrawLine3D(pen, nodos[7], nodos[4]);
            g3.DrawLine3D(pen, nodos[0], nodos[4]);
            g3.DrawLine3D(pen, nodos[1], nodos[5]);
            g3.DrawLine3D(pen, nodos[2], nodos[6]);
            g3.DrawLine3D(pen, nodos[3], nodos[7]);

            for (int i = 0; i < nodos.Length;i++)
            {
                PointF p = new PointF()
                {
                    // calculo de las esquinas
                    X = (nodos[i].Z * (float)Math.Cos((45 * Math.PI) / 180) + nodos[i].X) - 3,
                    Y = (nodos[i].Z * (float)Math.Sin((45 * Math.PI) / 180) + nodos[i].Y) - 3
                };
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, 79, 28)), 
                    new RectangleF(p, new SizeF(5f, 5f)));
            }
*/




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void EscalarX(bool aumentar_disminuir)
        {

        }

        private void EscalarY(bool aumentar_disminuir)
        {

        }
        private void EscalarZ(bool aumentar_disminuir)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
