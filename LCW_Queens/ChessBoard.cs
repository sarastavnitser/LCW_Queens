using System;
using System.Drawing;
using System.Windows.Forms;

namespace LCW_Queens
{
    public partial class ChessBoard : Form
    {
        private readonly int SQUARE_SIZE = 50;
        private Label[,] _squares;


        public ChessBoard(int rowSize, int[] queensLocation)
        {
            InitializeComponent();
            InitializeBoard(rowSize, queensLocation);
        }

        private void ChessBoard_Load(object sender, EventArgs e)
        {
        }

        private void InitializeBoard(int rowSize, int[] queensLocation)
        {
            Size = new Size(SQUARE_SIZE * rowSize + 100, SQUARE_SIZE * rowSize + 100);
            _squares = new Label[rowSize, rowSize];
            for (var row = 0; row < rowSize; row++)
            for (var col = 0; col < rowSize; col++)
            {
                var queen = queensLocation[row] == col;
                var square = CreateSquare(row, col, rowSize, queen);

                _squares[row, col] = square;
                pnlSquares.Controls.Add(square);
            }
        }

        private Label CreateSquare(int row, int col, int rowSize, bool queen)
        {
            var square = new Label();
            if (queen) square.Text = @"♕";

            square.Font = new Font("Calibri", SQUARE_SIZE / 2);
            square.TextAlign = ContentAlignment.MiddleCenter;
            square.Height = square.Width = SQUARE_SIZE;
            square.Location = new Point(col * SQUARE_SIZE, row * SQUARE_SIZE);

            var light = Color.LightBlue;
            var dark = Color.DarkBlue;


            if (rowSize % 2 == 0)
                square.BackColor = (row + col) % 2 == 0
                    ? light
                    : dark;
            else
                square.BackColor = (row + col) % 2 != 0
                    ? light
                    : dark;

            return square;
        }
    }
}