namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(300, 500);
            this.Text = "Нижнє центральне вiкно";
            this.BackColor = Color.Yellow;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height
            );

            Console.WriteLine("Location: " + this.Location);
            Console.WriteLine("Title: " + this.Text);
            Console.WriteLine("State: " + this.WindowState);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
