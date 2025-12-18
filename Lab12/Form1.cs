using System;
using System.Windows.Forms;

namespace SphereSegmentVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = double.Parse(textBoxRadius.Text);
                double height = double.Parse(textBoxHeight.Text);

                double volume = Math.PI * height * height * (3 * radius - height) / 3;

                textBoxVolume.Text = volume.ToString("F4");
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxRadius.Clear();
            textBoxHeight.Clear();
            textBoxVolume.Clear();
        }
    }
}