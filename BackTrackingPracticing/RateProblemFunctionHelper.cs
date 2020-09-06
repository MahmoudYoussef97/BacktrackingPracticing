using System;
using System.Collections.Generic;
using System.Text;

namespace BackTrackingPracticing
{
    public static class RateProblemFunctionHelper
    {
        public static bool SolveMaze(int[,] maze, int xDir, int yDir, int[,] solution)
        {
            // Base Condition - Found a solution
            if (xDir == maze.GetLength(0) - 1 && yDir == maze.GetLength(0) - 1)
            {
                solution[xDir, yDir] = 1;
                return true;
            }

            // Checking if the position is safe neither a (block nor reach the end)
            if (IsSafe(maze, xDir, yDir))
            {
                solution[xDir, yDir] = 1;

                // Move in x-direction and explore
                if (SolveMaze(maze, xDir + 1, yDir, solution))
                    return true;
                // Move in y-direction and explore
                if (SolveMaze(maze, xDir, yDir + 1, solution))
                    return true;

                // Backtrack and unmark the position if you didn't find a way
                solution[xDir, yDir] = 0;
                return false;
            }
            return false;
        }
        public static bool IsSafe(int[,] maze, int xDir, int yDir)
        {
            // Reaching the end of the maze
            if (xDir >= maze.GetLength(0) || yDir >= maze.GetLength(0)) return false;
            return maze[xDir, yDir] != 0;   // Arleady a block
        }
    }
}
