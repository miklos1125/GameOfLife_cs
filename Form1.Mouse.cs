using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1
    { 
        private void myPanel_MouseDown(object sender, MouseEventArgs e)
        {

            if (!stopModification) MouseModification(e);
 
        }
        private void myPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.None) 
            {
                if (!stopModification) MouseModification(e);
            }
        }

        private void MouseModification(MouseEventArgs e) {
            int x = e.Location.X / Cell.width;
            int y = e.Location.Y / Cell.height;
            
            //arrayIndex out of Bounds safety:
            if (x>=cells.GetLength(0)) x = cells.GetLength(0)-1;
            if (y>=cells.GetLength(1)) y = cells.GetLength(1)-1;
            if (x <= 0) x = 0;
            if (y <= 0) y = 0;


            if (e.Button == MouseButtons.Left)
            {
                if (!cells[x, y].isAlive)
                {
                    cells[x, y].SigneItToChange();
                    cells[x, y].ChangeIfSigned();
                    myPanel.Refresh();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (cells[x, y].isAlive)
                {
                    cells[x, y].SigneItToChange();
                    cells[x, y].ChangeIfSigned();
                    myPanel.Refresh();
                }
            }
        }
    }
}
