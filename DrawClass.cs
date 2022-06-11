using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Numerics;
using System.Drawing.Drawing2D;

namespace MKUniProgTask
{
    public static class DrawClass
    {
        // Draws a 300 diameter circle to represent our wafer.
        public static void DrawCircle(this Graphics g, Pen pen, float midX, float midY, float rad)
        {
            g.DrawEllipse(pen, midX - rad, midY - rad, rad + rad, rad + rad);
        }

        // Fills in the gray area of our circle to represent our wafer.
        public static void FillCircle(this Graphics g, Brush brush, float midX, float midY, float rad)
        {
            g.FillEllipse(brush, midX - rad, midY - rad, rad + rad, rad + rad);
        }

        // Draws the test points within our wafer. Note: Does get offset the more test points we add.
        public static void DrawDots(int inDots, Graphics g, Brush b, Pen p, int midX, int midY, int rad)
        {
            // Different colored brush for our dots to be seen.
            Brush dotBrush = (Brush)Brushes.Red;

            // Using a vector 2 to rotate around our center point; show that center point.
            Vector2 midPoint = new Vector2(midX, midY);
            g.FillRectangle(dotBrush, midPoint.X, midPoint.Y, 2, 2);
            Matrix transMat = new Matrix();

            int numDots = inDots - 1;
            int numRings = numDots / 8;

            Vector2 curDot = new Vector2();
            switch (numRings)
            {
                case 0:
                    return;
                default:
                    int slice = rad / (numRings + 1);
                    int curSlice = slice;
                    //Vector2 curDot = new Vector2(midPoint.X, midPoint.Y - curSlice);
                    for (int ring = 0; ring < numRings; ring++)
                    {
                        curDot = new Vector2(midPoint.X, midPoint.Y - curSlice);
                        // Draws circles that our dots should lie on.
                        DrawCircle(g, p, midX, midY, curSlice);
                        // Draws 8 dots around the specified circle.
                        for (int i = 0; i < 8; i++)
                        {
                            g.FillRectangle(dotBrush, curDot.X, curDot.Y, 2, 2);
                            curDot = Rotate(midPoint, curDot);
                        }
                        curSlice += slice;
                    }
                    break;
            }
        }

        // Rotates the outer point 45 degrees from the inner point.
        private static Vector2 Rotate(Vector2 inMid, Vector2 inOuter)
        {
            double angle = Math.PI / 4;
            Vector2 temp = new Vector2();
            double sin = Math.Sin(angle);
            double cos = Math.Cos(angle);

            temp.X = inOuter.X - inMid.X;
            temp.Y = inOuter.Y - inMid.Y;

            Vector2 point = new Vector2();
            point.X = (float)(temp.X * cos - temp.Y * sin) + inMid.X;
            point.Y = (float)(temp.X * sin + temp.Y * cos) + inMid.Y;

            return point;
        }
    }
}
