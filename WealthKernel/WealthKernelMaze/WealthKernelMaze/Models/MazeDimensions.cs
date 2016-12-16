using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthKernelMaze.Models
{
    public class MazeDimensions
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public MazeDimensions(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
