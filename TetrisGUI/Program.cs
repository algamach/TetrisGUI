using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.Width = 500;
            GraphicsWindow.Height = 500;

            GraphicsWindow.BackgroundColor = "LightBlue";

            GraphicsWindow.DrawRectangle(20, 20, 10, 10);
        }
    }
}
