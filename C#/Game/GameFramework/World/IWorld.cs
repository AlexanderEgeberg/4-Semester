using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    public interface IWorld
    {

        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }

        void PrintPlayground(StringBuilder sb);

        void PrintRowString(int r, StringBuilder sb);

        void PrintColRowChar(int row, int col, StringBuilder sb);
    }
}
