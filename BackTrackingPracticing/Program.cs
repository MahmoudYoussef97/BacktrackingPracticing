using System;

namespace BackTrackingPracticing
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Rate Problem
            int[,] maze = new int[4, 4] {   { 1, 0, 0, 0 },
                                            { 1, 1, 0, 1 },
                                            { 0, 1, 0, 0 },
                                            { 1, 1, 1, 1 } };
            int[,] solution = new int[4, 4];
            if(RateProblemFunctionHelper.SolveMaze(maze, 0, 0, solution))
                Console.WriteLine("There is a solution");
            else
                Console.WriteLine("There is no solution");
            for(int i =0;i< maze.GetLength(0);++i)
            {
                for(int j=0;j<maze.GetLength(0);++j)
                {
                    Console.Write(solution[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("------------------");

            // N-Queen Problem
            int[,] chessBoard = new int[4, 4];
            NQueenProblemFunctionHelper.SolveNQueen(chessBoard, 0);
            for (int i = 0; i < chessBoard.GetLength(0); ++i)
            {
                for (int j = 0; j < chessBoard.GetLength(0); ++j)
                {
                    Console.Write(chessBoard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
