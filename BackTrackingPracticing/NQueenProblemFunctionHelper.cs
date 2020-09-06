using System;
using System.Collections.Generic;
using System.Text;

namespace BackTrackingPracticing
{
    public static class NQueenProblemFunctionHelper
    {
        public static bool SolveNQueen(int[,] chessBoard, int col)
        {
            // Base Condition
            if (col >= chessBoard.GetLength(0))
                return true;

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                // Check if the position is safe and no other queen attacking
                if (IsSafe(chessBoard, row, col))
                {
                    chessBoard[row, col] = 1; // Assign queen position
                    if (SolveNQueen(chessBoard, col + 1))
                        return true;
                    chessBoard[row, col] = 0; // Backtrack and unmark
                }
            }
            return false;
        }
        public static bool IsSafe(int[,] chessBoard, int row, int col)
        {
            // Checking the current row
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                if (i == col) continue;
                if (chessBoard[row, i] == 1) return false;
            }
            // Checking the current col
            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                if (i == row) continue;
                if (chessBoard[i, col] == 1) return false;
            }
            int xDir = row;
            int yDir = col;
            while (xDir < chessBoard.GetLength(0) && yDir < chessBoard.GetLength(0))
            {
                if (chessBoard[xDir, yDir] == 1) return false;
                xDir += 1;
                yDir += 1;
            }
            xDir = row;
            yDir = col;
            while (xDir >= 0 && yDir >= 0)
            {
                if (chessBoard[xDir, yDir] == 1) return false;
                xDir -= 1;
                yDir -= 1;
            }
            xDir = row;
            yDir = col;
            while (xDir >= 0 && yDir < chessBoard.GetLength(0))
            {
                if (chessBoard[xDir, yDir] == 1) return false;
                xDir -= 1;
                yDir += 1;
            }
            xDir = row;
            yDir = col;
            while (xDir < chessBoard.GetLength(0) && yDir >= 0)
            {
                if (chessBoard[xDir, yDir] == 1) return false;
                xDir += 1;
                yDir -= 1;
            }
            return true;
        }
    }
}
