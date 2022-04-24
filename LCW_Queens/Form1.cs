using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LCW_Queens
{
    public partial class NQueensMenu : Form
    {
        private static bool _returned;

        public NQueensMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var board = CreateChessBoard();
            board.Show();
        }


        private ChessBoard CreateChessBoard()
        {
            var size = (int)nudNumQueens.Value;
            var queensLocations = Enumerate(size);
            _returned = false;
            return new ChessBoard(size, queensLocations);
        }


        private static bool IsConsistent(IReadOnlyList<int> board, int row)
        {
            for (var i = 0; i < row; i++)
            {
                if (board[i] == board[row]) return false; // same column
                if (board[i] - board[row] == row - i) return false; // same major diagonal
                if (board[row] - board[i] == row - i) return false; // same minor diagonal
            }

            return true;
        }


        /***************************************************************************
         *  Print and exit program after first solution found
         ***************************************************************************/

        private static int[] Enumerate(int n)
        {
            var a = new int[n];
            return Enumerate(a, 0);
        }

        private static int[] Enumerate(int[] q, int k)
        {
            var n = q.Length;
            if (k == n)
            {
                _returned = true;
                return q;
            }

            for (var i = 0; i < n; i++)
                if (!_returned)
                {
                    q[k] = i;
                    if (IsConsistent(q, k)) Enumerate(q, k + 1);
                }
                else
                {
                    break;
                }

            return q;
        }

        private void nudNumQueens_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}