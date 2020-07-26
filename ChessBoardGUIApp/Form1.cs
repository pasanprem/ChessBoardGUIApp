using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUIApp
{   

    public partial class Form1 : Form
    {
        //reference to the class board. containst the values of the board
        static Board myBoard = new Board(8);

        //2D array of buttons whose values are determinded by myBoard
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        private void populateGrid()
        {

            int buttonSize = panel1.Width / myBoard.Size;

            //make the panel a perfect square (not essential here)
            panel1.Height = panel1.Width;

            //nested loops. create buttons and print them to the screen
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    //add click event
                    btnGrid[i, j].Click += Grid_Button_Click;

                    panel1.Controls.Add(btnGrid[i, j]);

                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
