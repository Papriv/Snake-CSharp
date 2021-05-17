using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake_CSharp
{
    public class Juego
    {
        public int scale = 10;
        public int LengtMap = 30;
        private int[,] cuadros;
        private List<Cuadros> Snake;

        public enum Direction { Rigth,Down,Left,Up}
        public Direction ActualDirection = Direction.Rigth;

        PictureBox oPictureBox;

        private int PosInicialX 
        {
            get 
            {
                return LengtMap / 2;
            }
        }

        private int PosInicialY 
        {
            get
            {
                return LengtMap / 2;
            }
        }

        public Juego(PictureBox oPictureBox) 
        {
            this.oPictureBox = oPictureBox;
            Reset();
        }

        public void Reset()
        {
            Snake = new List<Cuadros>();
            Cuadros cuadroInicial = new Cuadros(PosInicialX, PosInicialY);
            Snake.Add(cuadroInicial);

            cuadros = new int[LengtMap,LengtMap];

            for (int j = 0;  j < LengtMap; j++)
            {
                for (int i = 0; i < LengtMap; i++)
                {
                    cuadros[i, j] = 0;
                }
            }

        }

        public void Mostrar()
        {
            Bitmap bmp = new Bitmap(oPictureBox.Width, oPictureBox.Height);
            for (int j = 0; j < LengtMap; j++)
            {
                for (int i = 0; i < LengtMap; i++)
                {
                    if (Snake.Where(d=>d.X==i && d.Y==j).Count()>0)
                    {
                        PaintPixel(bmp, i, j, Color.Black);
                    }
                    else
                    {
                        PaintPixel(bmp, i, j, Color.White);
                    }
                }
            }

            oPictureBox.Image = bmp;

        }

        private void PaintPixel(Bitmap bmp, int x, int y, Color color)
        {
            for (int j=0;j<scale;j++)
            {
                for (int i = 0; i < scale; i++)
                {
                    bmp.SetPixel(i + (x * scale), j + (y * scale), color);
                }
            }
        }


    }

    public class Cuadros
    {
        public int X, Y;
        public Cuadros(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }



    }
}
