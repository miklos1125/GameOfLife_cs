namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cellCounter = new System.Windows.Forms.TextBox();
            this.generationCounter = new System.Windows.Forms.TextBox();
            this.islandCounter = new System.Windows.Forms.TextBox();
            this.setInterval = new System.Windows.Forms.NumericUpDown();
            this.cellNumLabel = new System.Windows.Forms.Label();
            this.generationsLabel = new System.Windows.Forms.Label();
            this.islandsLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.randomizerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(32, 570);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 41);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cellCounter
            // 
            this.cellCounter.Location = new System.Drawing.Point(146, 588);
            this.cellCounter.Name = "cellCounter";
            this.cellCounter.ReadOnly = true;
            this.cellCounter.Size = new System.Drawing.Size(75, 20);
            this.cellCounter.TabIndex = 2;
            this.cellCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generationCounter
            // 
            this.generationCounter.Location = new System.Drawing.Point(259, 588);
            this.generationCounter.Name = "generationCounter";
            this.generationCounter.ReadOnly = true;
            this.generationCounter.Size = new System.Drawing.Size(75, 20);
            this.generationCounter.TabIndex = 3;
            this.generationCounter.Text = "1";
            this.generationCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // islandCounter
            // 
            this.islandCounter.Location = new System.Drawing.Point(372, 588);
            this.islandCounter.Name = "islandCounter";
            this.islandCounter.ReadOnly = true;
            this.islandCounter.Size = new System.Drawing.Size(75, 20);
            this.islandCounter.TabIndex = 4;
            this.islandCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // setInterval
            // 
            this.setInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setInterval.Location = new System.Drawing.Point(485, 588);
            this.setInterval.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.setInterval.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setInterval.Name = "setInterval";
            this.setInterval.ReadOnly = true;
            this.setInterval.Size = new System.Drawing.Size(75, 20);
            this.setInterval.TabIndex = 5;
            this.setInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.setInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.setInterval.ValueChanged += new System.EventHandler(this.setInterval_ValueChanged);
            // 
            // cellNumLabel
            // 
            this.cellNumLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cellNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cellNumLabel.Location = new System.Drawing.Point(146, 570);
            this.cellNumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cellNumLabel.Name = "cellNumLabel";
            this.cellNumLabel.Size = new System.Drawing.Size(75, 15);
            this.cellNumLabel.TabIndex = 6;
            this.cellNumLabel.Text = "Cells";
            this.cellNumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // generationsLabel
            // 
            this.generationsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.generationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generationsLabel.Location = new System.Drawing.Point(259, 570);
            this.generationsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.generationsLabel.Name = "generationsLabel";
            this.generationsLabel.Size = new System.Drawing.Size(75, 15);
            this.generationsLabel.TabIndex = 7;
            this.generationsLabel.Text = "Generations";
            this.generationsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // islandsLabel
            // 
            this.islandsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.islandsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.islandsLabel.Location = new System.Drawing.Point(372, 570);
            this.islandsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.islandsLabel.Name = "islandsLabel";
            this.islandsLabel.Size = new System.Drawing.Size(75, 15);
            this.islandsLabel.TabIndex = 8;
            this.islandsLabel.Text = "Islands";
            this.islandsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // intervalLabel
            // 
            this.intervalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.intervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.intervalLabel.Location = new System.Drawing.Point(485, 570);
            this.intervalLabel.Margin = new System.Windows.Forms.Padding(0);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(75, 15);
            this.intervalLabel.TabIndex = 9;
            this.intervalLabel.Text = "Interval (ms)";
            this.intervalLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // messageLabel
            // 
            this.messageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageLabel.Location = new System.Drawing.Point(133, 613);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(441, 18);
            this.messageLabel.TabIndex = 10;
            this.messageLabel.Text = "Left-click creates cells. Right-click terminates them.";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // randomizerButton
            // 
            this.randomizerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.randomizerButton.Location = new System.Drawing.Point(591, 565);
            this.randomizerButton.Margin = new System.Windows.Forms.Padding(0);
            this.randomizerButton.Name = "randomizerButton";
            this.randomizerButton.Size = new System.Drawing.Size(75, 20);
            this.randomizerButton.TabIndex = 12;
            this.randomizerButton.Text = "Randomizer";
            this.randomizerButton.UseVisualStyleBackColor = false;
            this.randomizerButton.Click += new System.EventHandler(this.randomizerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.clearButton.Location = new System.Drawing.Point(591, 593);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 20);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameOfLife.Properties.Resources.cell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 636);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.randomizerButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.islandsLabel);
            this.Controls.Add(this.generationsLabel);
            this.Controls.Add(this.cellNumLabel);
            this.Controls.Add(this.setInterval);
            this.Controls.Add(this.islandCounter);
            this.Controls.Add(this.generationCounter);
            this.Controls.Add(this.cellCounter);
            this.Controls.Add(this.startButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Of Life";
            ((System.ComponentModel.ISupportInitialize)(this.setInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox cellCounter;
        private System.Windows.Forms.TextBox generationCounter;
        private System.Windows.Forms.TextBox islandCounter;
        private System.Windows.Forms.NumericUpDown setInterval;
        private System.Windows.Forms.Label cellNumLabel;
        private System.Windows.Forms.Label generationsLabel;
        private System.Windows.Forms.Label islandsLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button randomizerButton;
        private System.Windows.Forms.Button clearButton;
    }
}

