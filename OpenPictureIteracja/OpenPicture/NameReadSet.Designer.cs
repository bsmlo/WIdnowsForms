namespace OpenPicture
{
    partial class NameReadSet
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.readOption1 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.InfoRead = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.readOption3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveSettings = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.readOption2 = new System.Windows.Forms.RadioButton();
            this.ReadName = new System.Windows.Forms.TextBox();
            this.CheckName = new System.Windows.Forms.Label();
            this.setNameInfo = new System.Windows.Forms.Label();
            this.OnlyNumbInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.50956F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.49044F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.readOption1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 98);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(378, 56);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // readOption1
            // 
            this.readOption1.AutoSize = true;
            this.readOption1.Location = new System.Drawing.Point(3, 3);
            this.readOption1.Name = "readOption1";
            this.readOption1.Size = new System.Drawing.Size(91, 17);
            this.readOption1.TabIndex = 0;
            this.readOption1.TabStop = true;
            this.readOption1.Text = "Default option";
            this.readOption1.UseVisualStyleBackColor = true;
            this.readOption1.CheckedChanged += new System.EventHandler(this.readOption1_CheckedChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.InfoRead);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(378, 89);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // InfoRead
            // 
            this.InfoRead.AutoSize = true;
            this.InfoRead.Location = new System.Drawing.Point(3, 0);
            this.InfoRead.Name = "InfoRead";
            this.InfoRead.Size = new System.Drawing.Size(84, 13);
            this.InfoRead.TabIndex = 0;
            this.InfoRead.Text = "Set Read option";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.readOption3);
            this.flowLayoutPanel4.Controls.Add(this.OnlyNumbInfo);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 272);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(378, 57);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // readOption3
            // 
            this.readOption3.AutoSize = true;
            this.readOption3.Location = new System.Drawing.Point(3, 3);
            this.readOption3.Name = "readOption3";
            this.readOption3.Size = new System.Drawing.Size(122, 17);
            this.readOption3.TabIndex = 0;
            this.readOption3.TabStop = true;
            this.readOption3.Text = "Only Picture Number";
            this.readOption3.UseVisualStyleBackColor = true;
            this.readOption3.CheckedChanged += new System.EventHandler(this.readOption3_CheckedChanged);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.saveSettings);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 335);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(378, 27);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(3, 3);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(100, 23);
            this.saveSettings.TabIndex = 0;
            this.saveSettings.Text = "Save Settings";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.readOption2);
            this.flowLayoutPanel3.Controls.Add(this.ReadName);
            this.flowLayoutPanel3.Controls.Add(this.CheckName);
            this.flowLayoutPanel3.Controls.Add(this.setNameInfo);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 160);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(378, 106);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // readOption2
            // 
            this.readOption2.AutoSize = true;
            this.readOption2.Location = new System.Drawing.Point(3, 3);
            this.readOption2.Name = "readOption2";
            this.readOption2.Size = new System.Drawing.Size(118, 17);
            this.readOption2.TabIndex = 0;
            this.readOption2.TabStop = true;
            this.readOption2.Text = "Set Name Standard";
            this.readOption2.UseVisualStyleBackColor = true;
            this.readOption2.CheckedChanged += new System.EventHandler(this.readOption2_CheckedChanged);
            // 
            // ReadName
            // 
            this.ReadName.Location = new System.Drawing.Point(3, 26);
            this.ReadName.Name = "ReadName";
            this.ReadName.Size = new System.Drawing.Size(372, 20);
            this.ReadName.TabIndex = 1;
            // 
            // CheckName
            // 
            this.CheckName.AutoSize = true;
            this.CheckName.Location = new System.Drawing.Point(3, 49);
            this.CheckName.Name = "CheckName";
            this.CheckName.Size = new System.Drawing.Size(41, 13);
            this.CheckName.TabIndex = 2;
            this.CheckName.Text = "Check:";
            // 
            // setNameInfo
            // 
            this.setNameInfo.AutoSize = true;
            this.setNameInfo.Location = new System.Drawing.Point(50, 49);
            this.setNameInfo.Name = "setNameInfo";
            this.setNameInfo.Size = new System.Drawing.Size(71, 13);
            this.setNameInfo.TabIndex = 4;
            this.setNameInfo.Text = "Info set name";
            // 
            // OnlyNumbInfo
            // 
            this.OnlyNumbInfo.AutoSize = true;
            this.OnlyNumbInfo.Location = new System.Drawing.Point(131, 0);
            this.OnlyNumbInfo.Name = "OnlyNumbInfo";
            this.OnlyNumbInfo.Size = new System.Drawing.Size(35, 13);
            this.OnlyNumbInfo.TabIndex = 1;
            this.OnlyNumbInfo.Text = "label1";
            // 
            // NameReadSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 389);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NameReadSet";
            this.Text = "NameReadSet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton readOption1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label InfoRead;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton readOption2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton readOption3;
        private System.Windows.Forms.TextBox ReadName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button saveSettings;
        private System.Windows.Forms.Label CheckName;
        private System.Windows.Forms.Label OnlyNumbInfo;
        private System.Windows.Forms.Label setNameInfo;
    }
}