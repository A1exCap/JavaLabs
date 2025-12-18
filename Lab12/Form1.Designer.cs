namespace SphereSegmentVolume
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox textBoxRadius;
        private TextBox textBoxHeight;
        private TextBox textBoxVolume;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCalculate;
        private Button buttonClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.textBoxRadius.Location = new System.Drawing.Point(150, 30);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(120, 20);
            this.textBoxRadius.TabIndex = 0;

            this.textBoxHeight.Location = new System.Drawing.Point(150, 70);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(120, 20);
            this.textBoxHeight.TabIndex = 1;

            this.textBoxVolume.Location = new System.Drawing.Point(150, 150);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.ReadOnly = true;
            this.textBoxVolume.Size = new System.Drawing.Size(120, 20);
            this.textBoxVolume.TabIndex = 2;

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Радіус кулі (R), см:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Висота сегмента (h):";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Об\'єм сегмента, см³:";

            this.buttonCalculate.Location = new System.Drawing.Point(50, 110);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(90, 30);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Обчислити";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);

            this.buttonClear.Location = new System.Drawing.Point(180, 110);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 30);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 200);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxRadius);
            this.Name = "Form1";
            this.Text = "Обчислення об\'єму кульового сегмента";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}