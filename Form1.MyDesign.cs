namespace GameOfLife
{
    public partial class Form1
    {
        private MyCanvas myPanel;
        private void InitializePlus() 
        {
            this.myPanel = new MyCanvas();

            this.myPanel.BackColor = System.Drawing.Color.FromArgb(180,255,255,255);
            this.myPanel.Location = new System.Drawing.Point(12, 12);
            this.myPanel.Name = "myPanel";
            this.myPanel.Padding = new System.Windows.Forms.Padding(50, 80, 50, 50);
            this.myPanel.Size = new System.Drawing.Size(671, 541);
            this.myPanel.TabIndex = 0;
            this.myPanel.Visible = true;
            this.myPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel_Paint);
            this.myPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseDown);
            this.myPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseMove);
        
            this.Controls.Add(this.myPanel);
        }
    }
    public class MyCanvas : System.Windows.Forms.Panel 
    {
        public MyCanvas()
        {
            this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer |
                System.Windows.Forms.ControlStyles.UserPaint, true);
        }
    } 
}
