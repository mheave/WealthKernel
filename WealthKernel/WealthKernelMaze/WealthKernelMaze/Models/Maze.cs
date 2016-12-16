using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace WealthKernelMaze.Models
{
    public class Maze
    {
        public MazeDimensions Dimensions { get; set; }

        public Matrix<double> MazeMatrix { get; set; }

        public Maze(int width, int height)
        {
            Dimensions = new MazeDimensions(width, height);
            var matrix = Matrix<double>.Build.Dense(width, height);
            
            MazeMatrix = matrix;               
        }
    }
}
