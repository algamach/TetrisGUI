namespace TetrisGUI
{
    internal class DrawerProvider
    {
        private static IDrawer _drawer = new ConsoleDrawer();

        public static IDrawer Drawer
        {
            get
            {
                return _drawer;
            }
        }
    }
}
