using Graphics3DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escala3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        int esc = 5;
        int tr = 5;
        Graphics3D g3;
        Point3DF[] nodos = new Point3DF[8];
        double angulo_x = 0;
        double angulo_y = 0;
        Point PosMouse;
        bool mover = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            nodos[0] = new Point3DF(-50, -50, -50);
            nodos[1] = new Point3DF(-50, -50, 50);
            nodos[2] = new Point3DF(-50, 50, 50);
            nodos[3] = new Point3DF(-50, 50, -50);
            nodos[4] = new Point3DF(50, -50, -50);
            nodos[5] = new Point3DF(50, -50, 50);
            nodos[6] = new Point3DF(50, 50, 50);
            nodos[7] = new Point3DF(50, 50, -50);

            PosMouse = new Point(0, 0);
        }

        private void ptbox_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g3 = new Graphics3D(g);
            e.Graphics.TranslateTransform(ptbox.Width / 2, ptbox.Height / 2);
            Pen pen = new Pen(Color.FromArgb(1, 94, 230), 2);
            g3.DrawLine3D(pen, nodos[0], nodos[1]);
            g3.DrawLine3D(pen, nodos[1], nodos[2]);
            g3.DrawLine3D(pen, nodos[2], nodos[3]);
            g3.DrawLine3D(pen, nodos[3], nodos[0]);
            g3.DrawLine3D(pen, nodos[4], nodos[5]);
            g3.DrawLine3D(pen, nodos[5], nodos[6]);
            g3.DrawLine3D(pen, nodos[6], nodos[7]);
            g3.DrawLine3D(pen, nodos[7], nodos[4]);
            g3.DrawLine3D(pen, nodos[0], nodos[4]);
            g3.DrawLine3D(pen, nodos[1], nodos[5]);
            g3.DrawLine3D(pen, nodos[2], nodos[6]);
            g3.DrawLine3D(pen, nodos[3], nodos[7]);

            for (int i = 0; i < nodos.Length; i++)
            {
                PointF p = new PointF()
                {
                    // calculo de las esquinas
                    X = (nodos[i].Z * (float)Math.Cos((45 * Math.PI) / 180)
                    + nodos[i].X) - 3,
                    Y = (nodos[i].Z * (float)Math.Sin((45 * Math.PI) / 180)
                    + nodos[i].Y) - 3
                };
                g.FillEllipse(new SolidBrush(Color.FromArgb(255, 79, 28)),
                    new RectangleF(p, new SizeF(5f, 5f)));
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    EscalarX(false);
                    break;
                case Keys.Right:
                    EscalarX(true);
                    break;
                case Keys.Up:
                    EscalarY(false);
                    break;
                case Keys.Down:
                    EscalarY(true);
                    break;
                case Keys.Home:
                    EscalarZ(false);
                    break;
                case Keys.End:
                    EscalarZ(true);
                    break;
                //movimiento  de traslacion
                //Izquierda derecha
                case Keys.A:
                    TrasladarX(false);
                    break;
                case Keys.D:
                    TrasladarX(true);
                    break;
                //Arriba y abajo
                case Keys.W:
                    TrasladarY(false);
                    break;
                case Keys.S:
                    TrasladarY(true);
                    break;

                // Moverse y Parar

                case Keys.R:
                    timer1.Enabled = true;
                    break;

                case Keys.T:
                    timer1.Enabled = false;
                    break;
                


            }
        }
        private void EscalarX(bool aumentar_disminuir)
        {
            if (aumentar_disminuir)
            {
                nodos[4].X += esc;
                nodos[5].X += esc;
                nodos[6].X += esc;
                nodos[7].X += esc;
            }
            else
            {
                nodos[4].X -= esc;
                nodos[5].X -= esc;
                nodos[6].X -= esc;
                nodos[7].X -= esc;
            }
            ptbox.Refresh();
        }

        private void EscalarY(bool aumentar_disminuir)
        {
            if (aumentar_disminuir)
            {
                nodos[2].Y += esc;
                nodos[3].Y += esc;
                nodos[6].Y += esc;
                nodos[7].Y += esc;
            }
            else
            {
                nodos[2].Y -= esc;
                nodos[3].Y -= esc;
                nodos[6].Y -= esc;
                nodos[7].Y -= esc;
            }
            ptbox.Refresh();
        }
        private void EscalarZ(bool aumentar_disminuir)
        {
            if (aumentar_disminuir)
            {
                nodos[1].Z += esc;
                nodos[2].Z += esc;
                nodos[5].Z += esc;
                nodos[6].Z += esc;
            }
            else
            {
                nodos[1].Z -= esc;
                nodos[2].Z -= esc;
                nodos[5].Z -= esc;
                nodos[6].Z -= esc;

            }
            ptbox.Refresh();
        }

        private void TrasladarX(bool der_izq)
        {
            if (der_izq)
            {
                for (int i = 0; i < nodos.Length; i++)
                    nodos[i].X += tr;
            }
            else
            {
                for (int i = 0; i < nodos.Length; i++)
                    nodos[i].X -= tr;

            }
            ptbox.Refresh();
        }
        private void TrasladarY(bool arriba_abajo)
        {
            if (arriba_abajo)
            {
                for (int i = 0; i < nodos.Length; i++)
                    nodos[i].Y += tr;
            }
            else
            {
                for (int i = 0; i < nodos.Length; i++)
                    nodos[i].Y -= tr;

            }
            ptbox.Refresh();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
 
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private Point3DF[] Rotar(Point3DF[] points,
            double angulo_x, double angulo_y)
        {
            Point3DF aux = new Point3DF();
            double grados_x = (angulo_x * Math.PI) / 180;
            double grados_y = (angulo_y * Math.PI) / 180;

            for (int i = 0; i < nodos.Length; i++)
            {
                //Rotacion y
                aux.X = Convert.ToSingle(points[i].X * Math.Cos(grados_x)
                    - points[i].Z * Math.Sin(grados_x));
                aux.Y = points[i].Y;
                aux.Z = Convert.ToSingle(points[i].Z * Math.Cos(grados_x)
                    + points[i].X * Math.Sin(grados_x));
                //Rotacion x
                points[i].X = aux.X;
                points[i].Y = Convert.ToSingle(aux.Y * Math.Cos(grados_y)
                            - aux.Z * Math.Sin(grados_y));
                points[i].Z = Convert.ToSingle(aux.Z * Math.Cos(grados_y)
                    + aux.Y * Math.Sin(grados_y));
            }
            return points;
        }

        private void ptbox_MouseDown(object sender, MouseEventArgs e)
        {
            PosMouse = e.Location;
            mover = true;

        }

        private void ptbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                angulo_x = e.Location.X - PosMouse.X;
                angulo_y = e.Location.Y - PosMouse.Y;
                if (angulo_x > 0)
                {
                    angulo_x = 1;
                }
                else if (angulo_x < 0)
                    angulo_x = -1;
                if (angulo_y > 0)
                    angulo_y = -1;
                else if (angulo_y < 0)
                    angulo_y = 1;
                nodos = Rotar(nodos, angulo_x, angulo_y);
                ptbox.Refresh();
            }
        }

        private void ptbox_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;

        }

        private void ptbox_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angulo_x = 1;
            angulo_y = 1;
            nodos = Rotar(nodos, angulo_x, angulo_y);
            ptbox.Refresh();

        }
    }
}
