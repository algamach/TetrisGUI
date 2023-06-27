namespace TetrisGUI
{
    internal class DrawerProvider
    {
        private static IDrawer _drawer = new GuiDrawer();

        public static IDrawer Drawer
        {
            get
            {
                return _drawer;
            }
        }
    }
}
