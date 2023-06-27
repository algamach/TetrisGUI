﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using Tetris;

namespace TetrisGUI
{
    internal class GuiDrawer : IDrawer
    {
        public const int SIZE = 20;
        public void DrawPoint(int x, int y)
        {
            GraphicsWindow.PenColor = "DarkBlue";
            GraphicsWindow.PenWidth = 2;
            GraphicsWindow.DrawRectangle(x*SIZE, y*SIZE, SIZE, SIZE);
        }

        public void HidePoint(int x, int y)
        {
            GraphicsWindow.PenColor = GraphicsWindow.BackgroundColor;
            GraphicsWindow.PenWidth = 3;
            GraphicsWindow.DrawRectangle(x * SIZE, y * SIZE, SIZE, SIZE);
        }

        public void InitField()
        {
            GraphicsWindow.Width = Field.Width *SIZE;
            GraphicsWindow.Height = Field.Height *SIZE;

            GraphicsWindow.BackgroundColor = "LightBlue";
        }

        public void WriteGameOver()
        {
            throw new NotImplementedException();
        }
    }
}