using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WealthKernelMaze.Services;

namespace WealthKernelMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            var mazeService = new MazeService();
            mazeService.LoadMaze();
            Console.Read();
        }
    }
}
