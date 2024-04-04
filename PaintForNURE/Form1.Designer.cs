namespace PaintForNURE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbCanvas = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            numSize = new NumericUpDown();
            label1 = new Label();
            lbColor = new Label();
            btnColor = new Button();
            ((System.ComponentModel.ISupportInitialize)pbCanvas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // pbCanvas
            // 
            pbCanvas.BackColor = Color.White;
            pbCanvas.Cursor = Cursors.Cross;
            pbCanvas.Location = new Point(71, 12);
            pbCanvas.Name = "pbCanvas";
            pbCanvas.Size = new Size(701, 537);
            pbCanvas.TabIndex = 3;
            pbCanvas.TabStop = false;
            pbCanvas.Paint += canvas_Draw;
            pbCanvas.MouseDown += canvas_MouseDown;
            pbCanvas.MouseMove += canvas_MouseMove;
            pbCanvas.MouseUp += canvas_MouseUp;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuBar;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numSize);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbColor);
            panel1.Controls.Add(btnColor);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(53, 537);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(3, 507);
            button1.Name = "button1";
            button1.Size = new Size(43, 23);
            button1.TabIndex = 5;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numSize
            // 
            numSize.Location = new Point(3, 70);
            numSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSize.Name = "numSize";
            numSize.Size = new Size(39, 23);
            numSize.TabIndex = 5;
            numSize.Tag = "";
            numSize.TextAlign = HorizontalAlignment.Center;
            numSize.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numSize.ValueChanged += numSize_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 96);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "Size";
            // 
            // lbColor
            // 
            lbColor.AutoSize = true;
            lbColor.Location = new Point(6, 44);
            lbColor.Name = "lbColor";
            lbColor.Size = new Size(36, 15);
            lbColor.TabIndex = 2;
            lbColor.Text = "Color";
            // 
            // btnColor
            // 
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Location = new Point(6, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(36, 38);
            btnColor.TabIndex = 1;
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(pbCanvas);
            Name = "Form1";
            Text = "Paint for NURE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbCanvas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbCanvas;
        private Panel panel1;
        private Label lbColor;
        private Button btnColor;
        private NumericUpDown numSize;
        private Label label1;
        private Button button1;
    }
}
