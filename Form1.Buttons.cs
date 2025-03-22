using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GameOfLife
{
    public partial class Form1
    {

        private void startButton_Click(object sender, EventArgs e)
        {
            if (stopModification)
            {
                timer1.Stop();
                stopModification = false;
                startButton.Text = "Start";
                messageLabel.Text = "Left-click creates cells. Right-click terminates them.";
                clearButton.Enabled = true;
                randomizerButton.Enabled = true;
            }
            else
            {
                this.myPanel.Visible = true;
                timer1.Start();
                stopModification = true;
                startButton.Text = "Stop";
                messageLabel.Text = "Life goes on.";
                clearButton.Enabled = false;
                randomizerButton.Enabled = false;
            }

        }

 
        int randomButtonCounter = 2;
        private void randomizerButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (randomButtonCounter > 32) randomButtonCounter = 2;
            
            Clear();

            foreach (Cell c in cells)
            {
                if (rand.Next(0, 1000) % (randomButtonCounter) == 0) 
                {
                    c.SigneItToChange();
                    c.ChangeIfSigned();
                }
            }
            randomButtonCounter *= 2;

            generations = 1;
            generationCounter.Text = generations.ToString();
            SetNewHistory();
            repeatsIn = 0;
            startButton.Text = "Start";
            startButton.Enabled = true;
            messageLabel.Text = "Left-click creates cells. Right-click terminates them.";
            messageLabel.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
            myPanel.Refresh();
            stopModification = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();

            generations = 1;
            generationCounter.Text = generations.ToString();
            SetNewHistory();
            repeatsIn = 0;
            startButton.Text = "Start";
            startButton.Enabled = true;
            messageLabel.Text = "Left-click creates cells. Right-click terminates them.";
            messageLabel.BackColor = System.Drawing.Color.FromArgb(50, 255, 255, 255);
            myPanel.Refresh();
            stopModification = false;
        }
        private void Clear() 
        {
            foreach (Cell c in cells)
            {
                if (c.isAlive)
                {
                    c.SigneItToChange();
                    c.ChangeIfSigned();
                }
            }
        }

        
    }
}
