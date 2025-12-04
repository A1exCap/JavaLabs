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

            this.Size = new Size(800, 600);
            this.Text = "Малювання мишею";
            this.BackColor = Color.White;

            // Створюємо полотно для малювання
            canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            // Підписка на події миші
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            this.MouseClick += Form1_MouseClick;

            // Щоб полотно автоматично перерисовувалося при Resize
            this.Resize += (s, e) =>
            {
                var newCanvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                using (Graphics g = Graphics.FromImage(newCanvas))
                {
                    g.Clear(Color.White);
                    g.DrawImage(canvas, Point.Empty);
                }
                canvas = newCanvas;
                this.Invalidate();
            };
        }
        private void Form1_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                isDrawing = true;
                lastPoint = e.Location; // запам'ятовуємо точку початку
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
