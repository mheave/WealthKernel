using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WealthKernelMaze.Models;

namespace WealthKernelMaze.Services
{
    public class MazeService
    {
        public Maze Maze { get; private set; }
        public void LoadMaze()
        {
            Maze = new Maze(13, 9); ;           

        }
    }
}
