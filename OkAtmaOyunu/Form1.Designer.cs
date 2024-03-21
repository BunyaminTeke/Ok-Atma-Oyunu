namespace OkAtmaOyunu
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
            components = new System.ComponentModel.Container();
            pb_arrow = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_onust = new Label();
            lbl_onalt = new Label();
            lbl_yirmiust = new Label();
            lbl_yirmialt = new Label();
            lbl_otuzalt = new Label();
            lbl_otuzust = new Label();
            lbl_kirkust = new Label();
            lbl_kirkalt = new Label();
            lbl_ellialt = new Label();
            lbl_elliust = new Label();
            lbl_altmisust = new Label();
            lbl_yuz = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lbl_altmisalt = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pb_arrow).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pb_arrow
            // 
            pb_arrow.Location = new Point(12, 275);
            pb_arrow.Name = "pb_arrow";
            pb_arrow.Size = new Size(175, 30);
            pb_arrow.TabIndex = 0;
            pb_arrow.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // lbl_onust
            // 
            lbl_onust.BackColor = Color.Black;
            lbl_onust.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_onust.ForeColor = Color.White;
            lbl_onust.Location = new Point(870, -1);
            lbl_onust.Name = "lbl_onust";
            lbl_onust.Size = new Size(72, 70);
            lbl_onust.TabIndex = 1;
            lbl_onust.Text = "10";
            lbl_onust.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_onalt
            // 
            lbl_onalt.BackColor = Color.Black;
            lbl_onalt.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_onalt.ForeColor = Color.White;
            lbl_onalt.Location = new Point(870, 523);
            lbl_onalt.Name = "lbl_onalt";
            lbl_onalt.Size = new Size(72, 70);
            lbl_onalt.TabIndex = 2;
            lbl_onalt.Text = "10";
            lbl_onalt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_yirmiust
            // 
            lbl_yirmiust.BackColor = Color.White;
            lbl_yirmiust.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_yirmiust.Location = new Point(870, 69);
            lbl_yirmiust.Name = "lbl_yirmiust";
            lbl_yirmiust.Size = new Size(72, 60);
            lbl_yirmiust.TabIndex = 3;
            lbl_yirmiust.Text = "20";
            lbl_yirmiust.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_yirmialt
            // 
            lbl_yirmialt.BackColor = Color.White;
            lbl_yirmialt.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_yirmialt.Location = new Point(870, 463);
            lbl_yirmialt.Name = "lbl_yirmialt";
            lbl_yirmialt.Size = new Size(72, 60);
            lbl_yirmialt.TabIndex = 4;
            lbl_yirmialt.Text = "20";
            lbl_yirmialt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_otuzalt
            // 
            lbl_otuzalt.BackColor = Color.Black;
            lbl_otuzalt.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_otuzalt.ForeColor = Color.White;
            lbl_otuzalt.Location = new Point(870, 413);
            lbl_otuzalt.Name = "lbl_otuzalt";
            lbl_otuzalt.Size = new Size(72, 50);
            lbl_otuzalt.TabIndex = 5;
            lbl_otuzalt.Text = "30";
            lbl_otuzalt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_otuzust
            // 
            lbl_otuzust.BackColor = Color.Black;
            lbl_otuzust.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_otuzust.ForeColor = Color.White;
            lbl_otuzust.Location = new Point(870, 129);
            lbl_otuzust.Name = "lbl_otuzust";
            lbl_otuzust.Size = new Size(72, 50);
            lbl_otuzust.TabIndex = 6;
            lbl_otuzust.Text = "30";
            lbl_otuzust.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_kirkust
            // 
            lbl_kirkust.BackColor = Color.White;
            lbl_kirkust.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_kirkust.Location = new Point(870, 179);
            lbl_kirkust.Name = "lbl_kirkust";
            lbl_kirkust.Size = new Size(72, 45);
            lbl_kirkust.TabIndex = 7;
            lbl_kirkust.Text = "40";
            lbl_kirkust.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_kirkalt
            // 
            lbl_kirkalt.BackColor = Color.White;
            lbl_kirkalt.Font = new Font("Bahnschrift", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_kirkalt.Location = new Point(870, 368);
            lbl_kirkalt.Name = "lbl_kirkalt";
            lbl_kirkalt.Size = new Size(72, 45);
            lbl_kirkalt.TabIndex = 8;
            lbl_kirkalt.Text = "40";
            lbl_kirkalt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_ellialt
            // 
            lbl_ellialt.BackColor = Color.Black;
            lbl_ellialt.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_ellialt.ForeColor = Color.White;
            lbl_ellialt.Location = new Point(870, 328);
            lbl_ellialt.Name = "lbl_ellialt";
            lbl_ellialt.Size = new Size(72, 40);
            lbl_ellialt.TabIndex = 9;
            lbl_ellialt.Text = "50";
            lbl_ellialt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_elliust
            // 
            lbl_elliust.BackColor = Color.Black;
            lbl_elliust.Font = new Font("Bahnschrift SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_elliust.ForeColor = Color.White;
            lbl_elliust.Location = new Point(870, 224);
            lbl_elliust.Name = "lbl_elliust";
            lbl_elliust.Size = new Size(72, 40);
            lbl_elliust.TabIndex = 10;
            lbl_elliust.Text = "50";
            lbl_elliust.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_altmisust
            // 
            lbl_altmisust.BackColor = Color.White;
            lbl_altmisust.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_altmisust.Location = new Point(870, 264);
            lbl_altmisust.Name = "lbl_altmisust";
            lbl_altmisust.Size = new Size(72, 25);
            lbl_altmisust.TabIndex = 11;
            lbl_altmisust.Text = "60";
            // 
            // lbl_yuz
            // 
            lbl_yuz.BackColor = Color.Red;
            lbl_yuz.Location = new Point(870, 289);
            lbl_yuz.Name = "lbl_yuz";
            lbl_yuz.Size = new Size(72, 15);
            lbl_yuz.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(899, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(43, 593);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(8, 284);
            label1.Name = "label1";
            label1.Size = new Size(0, 24);
            label1.TabIndex = 15;
            // 
            // lbl_altmisalt
            // 
            lbl_altmisalt.BackColor = Color.White;
            lbl_altmisalt.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_altmisalt.Location = new Point(870, 304);
            lbl_altmisalt.Name = "lbl_altmisalt";
            lbl_altmisalt.Size = new Size(72, 25);
            lbl_altmisalt.TabIndex = 12;
            lbl_altmisalt.Text = "60";
            lbl_altmisalt.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer2
            // 
            timer2.Interval = 40;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(942, 593);
            Controls.Add(panel1);
            Controls.Add(lbl_yuz);
            Controls.Add(lbl_altmisalt);
            Controls.Add(lbl_altmisust);
            Controls.Add(lbl_elliust);
            Controls.Add(lbl_ellialt);
            Controls.Add(lbl_kirkalt);
            Controls.Add(lbl_kirkust);
            Controls.Add(lbl_otuzust);
            Controls.Add(lbl_otuzalt);
            Controls.Add(lbl_yirmialt);
            Controls.Add(lbl_yirmiust);
            Controls.Add(lbl_onalt);
            Controls.Add(lbl_onust);
            Controls.Add(pb_arrow);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pb_arrow).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_arrow;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_onust;
        private Label lbl_onalt;
        private Label lbl_yirmiust;
        private Label lbl_yirmialt;
        private Label lbl_otuzalt;
        private Label lbl_otuzust;
        private Label lbl_kirkust;
        private Label lbl_kirkalt;
        private Label lbl_ellialt;
        private Label lbl_elliust;
        private Label lbl_altmisust;
        private Label lbl_yuz;
        private Panel panel1;
        private Label lbl_altmisalt;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
    }
}
