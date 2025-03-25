using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        Cell[,] cells = new Cell[67, 54];
        bool[][][] history = new bool[12][][];
        private bool stopModification = false;
        private bool roundCells = false;
        Graphics g;
        Brush myBrush;
        Pen myPen;
        private int generations = 1;
        private int repeatsIn = 0;

        public Form1()
        {
            InitializeComponent(); //visual studio generated code
            InitializePlus(); //my supplement;
            //initialize map of cells:
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j] = new Cell(i, j);
                }
            }
            //initialize history of maps:
            SetNewHistory();

            myBrush = new SolidBrush(Color.Green);
            myPen = new Pen(Color.Black);
           
            this.Show();
            string introduction = "Game of Life "
                + "is a cellular automaton devised by the British "
                + "mathematician John Horton Conway in 1970. "
                + "It is a zero-player game, meaning that its "
                + "evolution is determined by its initial state, "
                + "requiring no further input. "
                + "One interacts with the Game of Life by creating "
                + "an initial configuration and observing how it evolves.\n\n"
                + "CREATE YOU OWN CELL STRUCTURE USING THE MOUSE OR THE RANDOMIZER BUTTON!\n\n"
                + "Operating Rules:\n\n"
                + "1. Any live cell with fewer than two live neighbours dies, "
                       + "as if by underpopulation.\n\n"
               + "2. Any live cell with two or three live neighbours lives on "
                       + "to the next generation.\n\n"
               + "3. Any live cell with more than three live neighbours dies, "
                       + "as if by overpopulation.\n\n"
               + "4. Any dead cell with exactly three live neighbours becomes "
                       + "a live cell, as if by reproduction.\n\n"
               + "(Corner-neighbours matter.)";
                MessageBox.Show(introduction, "About Game of Life", MessageBoxButtons.OK, MessageBoxIcon.None);
        }


        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    int cellXlocation = cells[i, j].x * Cell.width;
                    int cellYLocation = cells[i, j].y * Cell.height;
                    if (cells[i, j].isAlive)
                    {
                        if (roundCells)
                        {
                            g.FillEllipse(myBrush, cellXlocation, cellYLocation, Cell.width, Cell.height);
                        }
                        else 
                        { 
                            g.FillRectangle(myBrush, cellXlocation, cellYLocation, Cell.width, Cell.height);
                        }
                    }
                    if (roundCells)
                    {
                        g.DrawEllipse(myPen, cellXlocation, cellYLocation, Cell.width, Cell.height);
                    }
                    else 
                    { 
                        g.DrawRectangle(myPen, cellXlocation, cellYLocation, Cell.width, Cell.height);
                    }
                }
            }
            cellCounter.Text = Cell.population.ToString();
            IslandCounting();            
        }


        private void setInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)setInterval.Value;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < cells.GetLength(0); i++) 
            {
                for (int j = 0; j < cells.GetLength(1); j++) 
                {
                    CountNeighbours(cells[i, j]);
                }
            }

            RefreshCellStructure();
            myPanel.Refresh();
            generationCounter.Text = (++generations).ToString();
            
            if (HistoryRepeats())
            {
                timer1.Stop();
                startButton.Text = "---";
                
                startButton.Enabled = false;
                clearButton.Enabled = true;
                randomizerButton.Enabled = true;
                messageLabel.BackColor = Color.FromArgb(185, 168, 240, 157);
                messageLabel.Text = "Cell structure is repeating now in every " +
                                     (repeatsIn > 1 ? repeatsIn + " turns. ":"turn. ") +
                                    "Program stopped.";
                return;
            }
        }
    }
}
