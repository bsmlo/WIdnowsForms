namespace Rain
{
    partial class Rain
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.allDrops = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.positionVal = new System.Windows.Forms.Label();
            this.dropsBar = new System.Windows.Forms.TrackBar();
            this.resetButton = new System.Windows.Forms.Button();
            this.timeControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timeBox = new System.Windows.Forms.CheckBox();
            this.startPositionTime = new System.Windows.Forms.TextBox();
            this.timeTime = new System.Windows.Forms.TextBox();
            this.velocityTIme = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.counterReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropsBar)).BeginInit();
            this.timeControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1409, 563);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 579);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(46, 13);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "Counts: ";
            // 
            // speedBar
            // 
            this.speedBar.Location = new System.Drawing.Point(12, 604);
            this.speedBar.Maximum = 50;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(718, 45);
            this.speedBar.TabIndex = 2;
            this.speedBar.Scroll += new System.EventHandler(this.SpeedBar_Scroll);
            this.speedBar.ValueChanged += new System.EventHandler(this.SpeedBar_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(747, 604);
            this.trackBar1.Maximum = 1300;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(675, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // allDrops
            // 
            this.allDrops.AutoSize = true;
            this.allDrops.Location = new System.Drawing.Point(12, 715);
            this.allDrops.Name = "allDrops";
            this.allDrops.Size = new System.Drawing.Size(53, 13);
            this.allDrops.TabIndex = 4;
            this.allDrops.Text = "All drops: ";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(9, 636);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(73, 13);
            this.speedLabel.TabIndex = 5;
            this.speedLabel.Text = "Speed value: ";
            // 
            // positionVal
            // 
            this.positionVal.AutoSize = true;
            this.positionVal.Location = new System.Drawing.Point(744, 636);
            this.positionVal.Name = "positionVal";
            this.positionVal.Size = new System.Drawing.Size(50, 13);
            this.positionVal.TabIndex = 6;
            this.positionVal.Text = "Position: ";
            // 
            // dropsBar
            // 
            this.dropsBar.Location = new System.Drawing.Point(15, 667);
            this.dropsBar.Maximum = 500;
            this.dropsBar.Name = "dropsBar";
            this.dropsBar.Size = new System.Drawing.Size(718, 45);
            this.dropsBar.TabIndex = 7;
            this.dropsBar.ValueChanged += new System.EventHandler(this.DropsBar_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(747, 667);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset All";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // timeControlPanel
            // 
            this.timeControlPanel.Controls.Add(this.timeBox);
            this.timeControlPanel.Controls.Add(this.startPositionTime);
            this.timeControlPanel.Controls.Add(this.timeTime);
            this.timeControlPanel.Controls.Add(this.velocityTIme);
            this.timeControlPanel.Controls.Add(this.distance);
            this.timeControlPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.timeControlPanel.Location = new System.Drawing.Point(828, 667);
            this.timeControlPanel.Name = "timeControlPanel";
            this.timeControlPanel.Size = new System.Drawing.Size(74, 182);
            this.timeControlPanel.TabIndex = 9;
            // 
            // timeBox
            // 
            this.timeBox.AutoSize = true;
            this.timeBox.Location = new System.Drawing.Point(3, 3);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(76, 17);
            this.timeBox.TabIndex = 0;
            this.timeBox.Text = "Count time";
            this.timeBox.UseVisualStyleBackColor = true;
            this.timeBox.CheckedChanged += new System.EventHandler(this.TimeBox_CheckedChanged);
            // 
            // startPositionTime
            // 
            this.startPositionTime.Location = new System.Drawing.Point(3, 26);
            this.startPositionTime.Name = "startPositionTime";
            this.startPositionTime.Size = new System.Drawing.Size(64, 20);
            this.startPositionTime.TabIndex = 1;
            this.startPositionTime.TextChanged += new System.EventHandler(this.StartPositionTime_TextChanged);
            // 
            // timeTime
            // 
            this.timeTime.Location = new System.Drawing.Point(3, 52);
            this.timeTime.Name = "timeTime";
            this.timeTime.Size = new System.Drawing.Size(64, 20);
            this.timeTime.TabIndex = 3;
            this.timeTime.TextChanged += new System.EventHandler(this.TimeTime_TextChanged);
            // 
            // velocityTIme
            // 
            this.velocityTIme.Location = new System.Drawing.Point(3, 78);
            this.velocityTIme.Name = "velocityTIme";
            this.velocityTIme.Size = new System.Drawing.Size(64, 20);
            this.velocityTIme.TabIndex = 4;
            this.velocityTIme.TextChanged += new System.EventHandler(this.VelocityTIme_TextChanged);
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(3, 104);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(64, 20);
            this.distance.TabIndex = 5;
            this.distance.TextChanged += new System.EventHandler(this.Distance_TextChanged);
            // 
            // distanceBox
            // 
            this.distanceBox.AutoSize = true;
            this.distanceBox.Location = new System.Drawing.Point(913, 667);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(99, 17);
            this.distanceBox.TabIndex = 1;
            this.distanceBox.Text = "Count Distance";
            this.distanceBox.UseVisualStyleBackColor = true;
            this.distanceBox.CheckedChanged += new System.EventHandler(this.DistanceBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 696);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standing pos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(901, 722);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Time to spand on rain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(901, 748);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Velocity";
            // 
            // start
            // 
            this.start.Enabled = false;
            this.start.Location = new System.Drawing.Point(747, 725);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 13;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // counterReset
            // 
            this.counterReset.Location = new System.Drawing.Point(747, 696);
            this.counterReset.Name = "counterReset";
            this.counterReset.Size = new System.Drawing.Size(75, 23);
            this.counterReset.TabIndex = 14;
            this.counterReset.Text = "Res Counter";
            this.counterReset.UseVisualStyleBackColor = true;
            this.counterReset.Click += new System.EventHandler(this.CounterReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(901, 774);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Distance to walk";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1029, 670);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(291, 179);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Rain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 861);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.distanceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.counterReset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeControlPanel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.dropsBar);
            this.Controls.Add(this.positionVal);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.allDrops);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1450, 900);
            this.MinimumSize = new System.Drawing.Size(1450, 900);
            this.Name = "Rain";
            this.Text = "Rain";
            this.Load += new System.EventHandler(this.Rain_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropsBar)).EndInit();
            this.timeControlPanel.ResumeLayout(false);
            this.timeControlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label allDrops;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label positionVal;
        private System.Windows.Forms.TrackBar dropsBar;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.FlowLayoutPanel timeControlPanel;
        private System.Windows.Forms.CheckBox timeBox;
        private System.Windows.Forms.TextBox startPositionTime;
        private System.Windows.Forms.TextBox timeTime;
        private System.Windows.Forms.TextBox velocityTIme;
        private System.Windows.Forms.CheckBox distanceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button counterReset;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}

