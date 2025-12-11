namespace Lab11
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false; 
        private Point lastPoint;        
        private Bitmap canvas;          
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint
            | ControlStyles.UserPaint
            | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            this.Size = new Size(1920, 1080);
            this.Text = "Mouse drawning";
            this.BackColor = Color.White;

            canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;
        }
        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isDrawing = true;
                lastPoint = e.Location; 
            }
        }

        private void Form1_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isDrawing = false;
            }
        }

        private void Form1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lastPoint = e.Location;
                this.Invalidate(); // перерисовка форми
            }
        }

        private void Form1_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.Clear(Color.White); // очищаємо полотно
                }
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(canvas, Point.Empty); // малюємо полотно
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
