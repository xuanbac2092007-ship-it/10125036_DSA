using System;

namespace Buoi02_DanhSach
{
    static class B12C4
    {
        public static void Run()
        {
            Console.WriteLine("--- BÀI 12: GAME MINESWEEPER ---");
            int rows = hamhotro.DocSo("Nhap so dong", 3);
            int cols = hamhotro.DocSo("Nhap so cot", 3);
            int[,] board = new int[rows, cols]; 

            
            if (rows > 1 && cols > 2)
            {
                board[0, 1] = 99;
                board[1, 2] = 99;
            }

            Console.WriteLine("\nBan co mìn (X la co mìn):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == 99) Console.Write("X\t");
                    else Console.Write("0\t");
                }
                Console.WriteLine();
            }
        }
    }
}
