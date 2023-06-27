namespace Tetris
{
    internal class L : Figure
    {

        public L(int x, int y, char c)
        {
            Points[0] = new Point(x, y, c);
            Points[1] = new Point(x, y + 1, c);
            Points[2] = new Point(x, y + 2, c);
            Points[3] = new Point(x + 1, y + 2, c);
            Draw();
        }
        public override void Rotate()
        {
            if (Points[0].X == Points[1].X)
            {
                RotateHorisontal();
            }
            else
            {
                RotateVertical();
            }

        }

        private void RotateVertical()
        {
            for (int i = 0; i < Points.Length - 1; i++)
            {
                Points[i].X = Points[0].X;
                Points[i].Y = Points[0].Y + i;
            }
            Points[3].X = Points[2].X + 1;
            Points[3].Y = Points[2].Y;
        }

        private void RotateHorisontal()
        {
            for (int i = 0; i < Points.Length - 1; i++)
            {
                Points[i].Y = Points[0].Y;
                Points[i].X = Points[0].X + i;
            }
            Points[3].Y = Points[2].Y - 1;
            Points[3].X = Points[2].X;
        }
    }
}
