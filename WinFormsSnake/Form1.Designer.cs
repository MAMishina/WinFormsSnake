namespace WinFormsSnake
{
    partial class SnakeForm1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Startbutton1 = new System.Windows.Forms.Button();
            this.Snapbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 343);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Startbutton1
            // 
            this.Startbutton1.BackColor = System.Drawing.Color.GreenYellow;
            this.Startbutton1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Startbutton1.Location = new System.Drawing.Point(34, 12);
            this.Startbutton1.Name = "Startbutton1";
            this.Startbutton1.Size = new System.Drawing.Size(112, 34);
            this.Startbutton1.TabIndex = 1;
            this.Startbutton1.Text = "Start";
            this.Startbutton1.UseVisualStyleBackColor = false;
            this.Startbutton1.Click += new System.EventHandler(this.Startbutton1_Click);
            // 
            // Snapbutton2
            // 
            this.Snapbutton2.Location = new System.Drawing.Point(34, 71);
            this.Snapbutton2.Name = "Snapbutton2";
            this.Snapbutton2.Size = new System.Drawing.Size(112, 34);
            this.Snapbutton2.TabIndex = 2;
            this.Snapbutton2.Text = "Snap";
            this.Snapbutton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "There is zero apple was ate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Record: ";
            // 
            // SnakeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Snapbutton2);
            this.Controls.Add(this.Startbutton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SnakeForm1";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SnakeForm1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SnakeForm1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Button Startbutton1;
        private Button Snapbutton2;
        private Label label1;
        private Label label2;
    }
}