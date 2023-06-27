namespace Tetris
{
    internal abstract class Figure
    {
        const int LENGTH = 4;
        public Point[] Points = new Point[LENGTH];

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.Draw();
            }
        }
        public void Hide()
        {
            foreach (Point p in Points)
            {
                p.Hide();
            }
        }
        public abstract void Rotate();

        internal Result TryMove(Direction dir)
        {
            Hide();

            Move(dir);

            var result = VerifyPosition();
            if (result != Result.SUCCESS)
                Move(Reverse(dir));

            Draw();

            return result;
        }

        private Direction Reverse(Direction dir)
        {
            switch (dir)
            {
                case Direction.LEFT:
                    return Direction.RIGHT;
                case Direction.RIGHT:
                    return Direction.LEFT;
                case Direction.UP:
                    return Direction.DOWN;
                case Direction.DOWN:
                    return Direction.UP;
                default:
                    return dir;
            }
        }

        private Result VerifyPosition()
        {
            foreach (var p in Points)
            {
                //in theory it shouldn't be here -1     
                if (p.Y >= Field.Height - 1)
                    return Result.DOWN_BORDER_STRIKE;
                if (p.X >= Field.Width || p.X < 0 || p.Y < 0)
                    return Result.BORDER_STRIKE;
                if (Field.CheckStrike(p))
                    return Result.HEAP_STRIKE;
            }
            return Result.SUCCESS;
        }

        public void Move(Direction dir)
        {
            foreach (var p in Points)
            {
                p.Move(dir);
            }
        }

        internal Result TryRotate()
        {
            Hide();

            Rotate();

            var result = VerifyPosition();
            if (result != Result.SUCCESS)
                Rotate();

            Draw();
            return result;
        }

        internal bool IsOnTop()
        {
            return Points[0].Y == 0;
        }
    }
}
