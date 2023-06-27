namespace TetrisGUI
{
    internal interface IDrawer
    {
        void DrawPoint(int x, int y);
        void HidePoint(int x, int y);
        void WriteGameOver();
        void InitField();
    }
}
