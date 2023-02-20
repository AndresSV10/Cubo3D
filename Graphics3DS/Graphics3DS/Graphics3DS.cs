using System;
using System.Drawing;

namespace Graphics3DS
{
    public class Graphics3D
    {
        private Graphics g;
        private int ang = 45;

        public Graphics3D(Graphics g)
        {
            this.g = g;
        }

        private Point Convertir2D(int X, int Y, int Z)
        {
            Point p = new Point();

            p.X = Convert.ToInt32(Z * Math.Cos((ang * Math.PI) / 180) + X);
            p.Y = Convert.ToInt32(Z * Math.Sin((ang * Math.PI) / 180) + Y);
            return p;
        }

        private PointF Convertir2D(float X, float Y, float Z)
        {
            PointF p = new PointF()
            {
                X = Z * (float)Math.Cos((ang * Math.PI) / 180) + X,
                Y = Z * (float)Math.Sin((ang * Math.PI) / 180) + Y
            };
            return p;
        }

        private Point Convertir2D(Point3D P3D)
        {
            Point p = new Point();

            p.X = Convert.ToInt32(P3D.Z * Math.Cos((ang * Math.PI) / 180) + P3D.X);
            p.Y = Convert.ToInt32(P3D.Z * Math.Sin((ang * Math.PI) / 180) + P3D.Y);

            return p;
        }

        private PointF Convertir2D(Point3DF P3DF)
        {
            PointF p = new PointF()
            {
                X = P3DF.Z * (float)Math.Cos((ang * Math.PI) / 180) + P3DF.X,
                Y = P3DF.Z * (float)Math.Sin((ang * Math.PI) / 180) + P3DF.Y
            };
            return p;
        }

        public void DrawLine3D(Pen pen, int x1, int y1, int z1, int x2, int y2, int z2)
        {
            Point P1 = Convertir2D(x1, y1, z1);
            Point P2 = Convertir2D(x2, y2, z2);
            g.DrawLine(pen, P1, P2);
        }

        public void DrawLine3D(Pen pen, float x1, float y1, float z1, float x2, float y2, float z2)
        {
            PointF P1 = Convertir2D(x1, y1, z1);
            PointF P2 = Convertir2D(x2, y2, z2);
            g.DrawLine(pen, P1, P2);
        }

        public void DrawLine3D(Pen pen, Point3D P3D1, Point3D P3D2)
        {
            Point P1 = Convertir2D(P3D1);
            Point P2 = Convertir2D(P3D2);
            g.DrawLine(pen, P1, P2);
        }

        public void DrawLine3D(Pen pen, Point3DF P3D1, Point3DF P3D2)
        {
            PointF P1 = Convertir2D(P3D1.X, P3D1.Y, P3D1.Z);
            PointF P2 = Convertir2D(P3D2.X, P3D2.Y, P3D2.Z);
            g.DrawLine(pen, P1, P2);
        }

        public void DrawTriangle(Pen pen, int X1, int Y1, int Z1, int X2, int Y2, int Z2, int X3, int Y3, int Z3)
        {
            Point[] pts = {
                Convertir2D(X1,Y1,Z1),
                Convertir2D(X2,Y2,Z2),
                Convertir2D(X3,Y3,Z3),
            };
            g.DrawPolygon(pen, pts);
        }

        public void DrawTriangle(Pen pen, float X1, float Y1, float Z1, float X2, float Y2, float Z2, float X3, float Y3, float Z3)
        {
            PointF[] pts = {
                Convertir2D(X1,Y1,Z1),
                Convertir2D(X2, Y2, Z2),
                Convertir2D(X3,Y3,Z3),
            };
            g.DrawPolygon(pen, pts);
        }

        public void DrawTriangle(Pen pen, Point3D P1, Point3D P2, Point3D P3)
        {
            Point[] pts = {
                Convertir2D(P1),
                Convertir2D(P2),
                Convertir2D(P3)
            };
            g.DrawPolygon(pen, pts);
        }

        public void DrawTriangle(Pen pen, Point3DF P1, Point3DF P2, Point3DF P3)
        {
            PointF[] pts = {
                Convertir2D(P1),
                Convertir2D(P2),
                Convertir2D(P3)
            };
            g.DrawPolygon(pen, pts);
        }
        //Multiplos de 3
        public void DrawTriangle(Pen pen, int[] Points)
        {
            Point[] pts = {
                Convertir2D(Points[0],Points[1],Points[2]),
                Convertir2D(Points[3],Points[4],Points[5]),
                Convertir2D(Points[6],Points[7],Points[8])
            };
            g.DrawPolygon(pen, pts);
        }

        public void DrawTriangle(Pen pen, float[] Points)
        {
            PointF[] pts = {

                Convertir2D(Points[3],Points[4],Points[5]),
                Convertir2D(Points[6],Points[7],Points[8])
            };
            g.DrawPolygon(pen, pts);
        }

        public void DrawTriangle(Pen pen, Point3D[] Points)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < 3; i++)
            {
                pts[i] = Convertir2D(Points[i]);
            }
            g.DrawPolygon(pen, pts);
        }

        public void DrawTriangle(Pen pen, Point3DF[] Points)
        {
            PointF[] pts = {
                Convertir2D(Points[0]),
                Convertir2D(Points[1]),
                Convertir2D(Points[2])
            };
            g.DrawPolygon(pen, pts);
        }

        public void DrawPolygon(Pen pen, Point3D[] Points)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawPolygon(pen, pts);
        }

        public void DrawPolygon(Pen pen, Point3DF[] Points)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawPolygon(pen, pts);
        }

        public void DrawCurve(Pen pen, Point3D[] Points)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts);
        }

        public void DrawCurve(Pen pen, Point3DF[] Points)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts);
        }

        public void DrawCurve(Pen pen, Point3D[] Points, float tension)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts, tension);
        }

        public void DrawCurve(Pen pen, Point3DF[] Points, float tension)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts, tension);
        }

        public void DrawCurve(Pen pen, Point3DF[] Points, int offset, int numberOfSegments)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts, offset, numberOfSegments);
        }

        public void DrawCurve(Pen pen, Point3D[] Points, int offset, int numberOfSegments, float tension)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts, offset, numberOfSegments, tension);
        }

        public void DrawCurve(Pen pen, Point3DF[] Points, int offset, int numberOfSegments, float tension)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawCurve(pen, pts, offset, numberOfSegments, tension);
        }

        public void DrawClosedCurve(Pen pen, Point3D[] Points)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawClosedCurve(pen, pts);
        }

        public void DrawClosedCurve(Pen pen, Point3DF[] Points)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawClosedCurve(pen, pts);
        }

        public void DrawClosedCurve(Pen pen, Point3D[] Points, float tension, System.Drawing.Drawing2D.FillMode fillmode)
        {
            Point[] pts = new Point[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawClosedCurve(pen, pts, tension, fillmode);
        }

        public void DrawClosedCurve(Pen pen, Point3DF[] Points, float tension, System.Drawing.Drawing2D.FillMode fillmode)
        {
            PointF[] pts = new PointF[Points.Length];
            for (int i = 0; i < pts.Length; i++)
                pts[i] = Convertir2D(Points[i]);
            g.DrawClosedCurve(pen, pts, tension, fillmode);
        }

        public void DrawBezier3D(Pen pen, Point3D P1, Point3D P2, Point3D P3, Point3D P4)
        {
            Point p1 = Convertir2D(P1);
            Point p2 = Convertir2D(P2);
            Point p3 = Convertir2D(P3);
            Point p4 = Convertir2D(P4);
            g.DrawBezier(pen, p1, p2, p3, p4);
        }

        public void DrawBezier3D(Pen pen, Point3DF P1, Point3DF P2, Point3DF P3, Point3DF P4)
        {
            PointF p1 = Convertir2D(P1);
            PointF p2 = Convertir2D(P2);
            PointF p3 = Convertir2D(P3);
            PointF p4 = Convertir2D(P4);
            g.DrawBezier(pen, p1, p2, p3, p4);
        }

        public void DrawBezier3D(Pen pen, float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3, float x4, float y4, float z4)
        {
            float px1 = Convertir2D(x1, y1, z1).X;
            float py1 = Convertir2D(x1, y1, z1).Y;
            float px2 = Convertir2D(x2, y2, z2).X;
            float py2 = Convertir2D(x2, y2, z2).Y;
            float px3 = Convertir2D(x3, y3, z3).X;
            float py3 = Convertir2D(x3, y3, z3).Y;
            float px4 = Convertir2D(x4, y4, z4).X;
            float py4 = Convertir2D(x4, y4, z4).Y;
            g.DrawBezier(pen, px1, py1, px2, py2, px3, py3, px4, py4);
        }

    }

    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3D(int X, int Y, int Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }

    public class Point3DF
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Point3DF()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3DF(float X, float Y, float Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
