namespace OpenPicture
{
    partial class OpenPicture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenPicture));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.drawingSet = new System.Windows.Forms.CheckBox();
            this.setBackG = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.setX = new System.Windows.Forms.TrackBar();
            this.setY = new System.Windows.Forms.TrackBar();
            this.setWidth = new System.Windows.Forms.TrackBar();
            this.setLength = new System.Windows.Forms.TrackBar();
            this.propDraw = new System.Windows.Forms.Label();
            this.propBcg = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.plotButton = new System.Windows.Forms.Button();
            this.dynamicSearth = new System.Windows.Forms.CheckBox();
            this.uncheckedButton = new System.Windows.Forms.Button();
            this.loadUndo = new System.Windows.Forms.Button();
            this.loadNext = new System.Windows.Forms.Button();
            this.saveChedked = new System.Windows.Forms.Button();
            this.checkedButton = new System.Windows.Forms.Button();
            this.checkRange = new System.Windows.Forms.Button();
            this.loadIterateButton = new System.Windows.Forms.Button();
            this.pictureSlider = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameReadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeOfPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SortNameNumber = new System.Windows.Forms.ToolStripButton();
            this.SortByLength = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.savePosition = new System.Windows.Forms.Button();
            this.clearPositionList = new System.Windows.Forms.Button();
            this.estimatePosition = new System.Windows.Forms.CheckBox();
            this.newEstimatePoint = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(614, 33);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(353, 414);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.showButton);
            this.flowLayoutPanel1.Controls.Add(this.clearButton);
            this.flowLayoutPanel1.Controls.Add(this.drawingSet);
            this.flowLayoutPanel1.Controls.Add(this.setBackG);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.propDraw);
            this.flowLayoutPanel1.Controls.Add(this.propBcg);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 453);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 215);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(3, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(86, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "ShowPicture";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(95, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawingSet
            // 
            this.drawingSet.AutoSize = true;
            this.drawingSet.Enabled = false;
            this.drawingSet.Location = new System.Drawing.Point(187, 3);
            this.drawingSet.Name = "drawingSet";
            this.drawingSet.Size = new System.Drawing.Size(84, 17);
            this.drawingSet.TabIndex = 4;
            this.drawingSet.Text = "Set Drawing";
            this.drawingSet.UseVisualStyleBackColor = true;
            this.drawingSet.CheckedChanged += new System.EventHandler(this.drawingSet_CheckedChanged);
            // 
            // setBackG
            // 
            this.setBackG.AutoSize = true;
            this.setBackG.Enabled = false;
            this.setBackG.Location = new System.Drawing.Point(277, 3);
            this.setBackG.Name = "setBackG";
            this.setBackG.Size = new System.Drawing.Size(103, 17);
            this.setBackG.TabIndex = 5;
            this.setBackG.Text = "Set Background";
            this.setBackG.UseVisualStyleBackColor = true;
            this.setBackG.CheckedChanged += new System.EventHandler(this.setBackG_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.setX);
            this.flowLayoutPanel3.Controls.Add(this.setY);
            this.flowLayoutPanel3.Controls.Add(this.setWidth);
            this.flowLayoutPanel3.Controls.Add(this.setLength);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Enabled = false;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(496, 163);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // setX
            // 
            this.setX.AccessibleDescription = "";
            this.setX.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.SetFlowBreak(this.setX, true);
            this.setX.Location = new System.Drawing.Point(3, 3);
            this.setX.Maximum = 720;
            this.setX.Name = "setX";
            this.setX.Size = new System.Drawing.Size(493, 45);
            this.setX.TabIndex = 2;
            this.setX.Tag = "";
            this.setX.Value = 360;
            this.setX.Scroll += new System.EventHandler(this.setX_Scroll);
            // 
            // setY
            // 
            this.setY.Dock = System.Windows.Forms.DockStyle.Top;
            this.setY.Location = new System.Drawing.Point(3, 54);
            this.setY.Maximum = 575;
            this.setY.Name = "setY";
            this.setY.Size = new System.Drawing.Size(493, 45);
            this.setY.TabIndex = 285;
            this.setY.Value = 287;
            this.setY.Scroll += new System.EventHandler(this.setY_Scroll);
            // 
            // setWidth
            // 
            this.setWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.setWidth.Location = new System.Drawing.Point(3, 105);
            this.setWidth.Maximum = 50;
            this.setWidth.Name = "setWidth";
            this.setWidth.Size = new System.Drawing.Size(247, 45);
            this.setWidth.TabIndex = 3;
            this.setWidth.Value = 25;
            this.setWidth.Scroll += new System.EventHandler(this.setWidth_Scroll);
            // 
            // setLength
            // 
            this.setLength.Dock = System.Windows.Forms.DockStyle.Top;
            this.setLength.Location = new System.Drawing.Point(256, 105);
            this.setLength.Maximum = 50;
            this.setLength.Name = "setLength";
            this.setLength.Size = new System.Drawing.Size(235, 45);
            this.setLength.TabIndex = 1;
            this.setLength.Value = 25;
            this.setLength.Scroll += new System.EventHandler(this.setLength_Scroll);
            // 
            // propDraw
            // 
            this.propDraw.AutoSize = true;
            this.propDraw.Location = new System.Drawing.Point(505, 29);
            this.propDraw.Name = "propDraw";
            this.propDraw.Size = new System.Drawing.Size(29, 13);
            this.propDraw.TabIndex = 6;
            this.propDraw.Text = "Prop";
            // 
            // propBcg
            // 
            this.propBcg.AutoSize = true;
            this.propBcg.Location = new System.Drawing.Point(540, 29);
            this.propBcg.Name = "propBcg";
            this.propBcg.Size = new System.Drawing.Size(48, 13);
            this.propBcg.TabIndex = 7;
            this.propBcg.Text = "PropBcg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.09278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.90722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.67863F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.32137F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 671);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.searchButton);
            this.flowLayoutPanel2.Controls.Add(this.plotButton);
            this.flowLayoutPanel2.Controls.Add(this.dynamicSearth);
            this.flowLayoutPanel2.Controls.Add(this.uncheckedButton);
            this.flowLayoutPanel2.Controls.Add(this.loadUndo);
            this.flowLayoutPanel2.Controls.Add(this.loadNext);
            this.flowLayoutPanel2.Controls.Add(this.saveChedked);
            this.flowLayoutPanel2.Controls.Add(this.checkedButton);
            this.flowLayoutPanel2.Controls.Add(this.checkRange);
            this.flowLayoutPanel2.Controls.Add(this.loadIterateButton);
            this.flowLayoutPanel2.Controls.Add(this.savePosition);
            this.flowLayoutPanel2.Controls.Add(this.clearPositionList);
            this.flowLayoutPanel2.Controls.Add(this.estimatePosition);
            this.flowLayoutPanel2.Controls.Add(this.pictureSlider);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.newEstimatePoint);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(614, 453);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(353, 215);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchButton.Location = new System.Drawing.Point(3, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Load To List";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // plotButton
            // 
            this.plotButton.Enabled = false;
            this.plotButton.Location = new System.Drawing.Point(103, 3);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(95, 23);
            this.plotButton.TabIndex = 1;
            this.plotButton.Text = "Get Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click_1);
            // 
            // dynamicSearth
            // 
            this.dynamicSearth.AutoSize = true;
            this.dynamicSearth.Enabled = false;
            this.dynamicSearth.Location = new System.Drawing.Point(204, 3);
            this.dynamicSearth.Name = "dynamicSearth";
            this.dynamicSearth.Size = new System.Drawing.Size(95, 17);
            this.dynamicSearth.TabIndex = 4;
            this.dynamicSearth.Text = "Find Similar To";
            this.dynamicSearth.UseVisualStyleBackColor = true;
            this.dynamicSearth.CheckedChanged += new System.EventHandler(this.dynamicSearth_CheckedChanged);
            // 
            // uncheckedButton
            // 
            this.uncheckedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.uncheckedButton.Enabled = false;
            this.uncheckedButton.Location = new System.Drawing.Point(3, 32);
            this.uncheckedButton.Name = "uncheckedButton";
            this.uncheckedButton.Size = new System.Drawing.Size(94, 23);
            this.uncheckedButton.TabIndex = 5;
            this.uncheckedButton.Text = "Uncheck All";
            this.uncheckedButton.UseVisualStyleBackColor = true;
            this.uncheckedButton.Click += new System.EventHandler(this.uncheckedButton_Click);
            // 
            // loadUndo
            // 
            this.loadUndo.Dock = System.Windows.Forms.DockStyle.Left;
            this.loadUndo.Enabled = false;
            this.loadUndo.Location = new System.Drawing.Point(103, 32);
            this.loadUndo.Name = "loadUndo";
            this.loadUndo.Size = new System.Drawing.Size(95, 23);
            this.loadUndo.TabIndex = 7;
            this.loadUndo.Text = "Undo";
            this.loadUndo.UseVisualStyleBackColor = true;
            this.loadUndo.Click += new System.EventHandler(this.loadUndo_Click);
            // 
            // loadNext
            // 
            this.loadNext.Enabled = false;
            this.loadNext.Location = new System.Drawing.Point(204, 32);
            this.loadNext.Name = "loadNext";
            this.loadNext.Size = new System.Drawing.Size(98, 23);
            this.loadNext.TabIndex = 6;
            this.loadNext.Text = "Next";
            this.loadNext.UseVisualStyleBackColor = true;
            this.loadNext.Click += new System.EventHandler(this.loadNext_Click);
            // 
            // saveChedked
            // 
            this.saveChedked.Enabled = false;
            this.saveChedked.Location = new System.Drawing.Point(3, 61);
            this.saveChedked.Name = "saveChedked";
            this.saveChedked.Size = new System.Drawing.Size(95, 23);
            this.saveChedked.TabIndex = 8;
            this.saveChedked.Text = "Save Checked";
            this.saveChedked.UseVisualStyleBackColor = true;
            this.saveChedked.Click += new System.EventHandler(this.saveChedked_Click);
            // 
            // checkedButton
            // 
            this.checkedButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkedButton.Enabled = false;
            this.checkedButton.Location = new System.Drawing.Point(104, 61);
            this.checkedButton.Name = "checkedButton";
            this.checkedButton.Size = new System.Drawing.Size(94, 23);
            this.checkedButton.TabIndex = 9;
            this.checkedButton.Text = "Check All";
            this.checkedButton.UseVisualStyleBackColor = true;
            this.checkedButton.Click += new System.EventHandler(this.checkedButton_Click);
            // 
            // checkRange
            // 
            this.checkRange.Enabled = false;
            this.checkRange.Location = new System.Drawing.Point(204, 61);
            this.checkRange.Name = "checkRange";
            this.checkRange.Size = new System.Drawing.Size(98, 23);
            this.checkRange.TabIndex = 10;
            this.checkRange.Text = "Check Range";
            this.checkRange.UseVisualStyleBackColor = true;
            this.checkRange.Click += new System.EventHandler(this.checkRange_Click);
            // 
            // loadIterateButton
            // 
            this.loadIterateButton.Location = new System.Drawing.Point(3, 90);
            this.loadIterateButton.Name = "loadIterateButton";
            this.loadIterateButton.Size = new System.Drawing.Size(94, 23);
            this.loadIterateButton.TabIndex = 11;
            this.loadIterateButton.Text = "Load To Iterate";
            this.loadIterateButton.UseVisualStyleBackColor = true;
            this.loadIterateButton.Click += new System.EventHandler(this.loadIterateButton_Click);
            // 
            // pictureSlider
            // 
            this.pictureSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureSlider.Enabled = false;
            this.pictureSlider.Location = new System.Drawing.Point(3, 142);
            this.pictureSlider.Maximum = 50;
            this.pictureSlider.Name = "pictureSlider";
            this.pictureSlider.Size = new System.Drawing.Size(347, 45);
            this.pictureSlider.TabIndex = 12;
            this.pictureSlider.Value = 25;
            this.pictureSlider.Scroll += new System.EventHandler(this.pictureSlider_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Picture Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(611, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aboutProgramToolStripMenuItem.Text = "About The Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameReadSettingsToolStripMenuItem,
            this.typeOfPicturesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // nameReadSettingsToolStripMenuItem
            // 
            this.nameReadSettingsToolStripMenuItem.Name = "nameReadSettingsToolStripMenuItem";
            this.nameReadSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameReadSettingsToolStripMenuItem.Text = "Name Read Settings";
            this.nameReadSettingsToolStripMenuItem.Click += new System.EventHandler(this.nameReadSettingsToolStripMenuItem_Click);
            // 
            // typeOfPicturesToolStripMenuItem
            // 
            this.typeOfPicturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jPGToolStripMenuItem,
            this.pNGToolStripMenuItem});
            this.typeOfPicturesToolStripMenuItem.Name = "typeOfPicturesToolStripMenuItem";
            this.typeOfPicturesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typeOfPicturesToolStripMenuItem.Text = "Type Of Pictures";
            // 
            // jPGToolStripMenuItem
            // 
            this.jPGToolStripMenuItem.Checked = true;
            this.jPGToolStripMenuItem.CheckOnClick = true;
            this.jPGToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
            this.jPGToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.jPGToolStripMenuItem.Text = "JPG";
            this.jPGToolStripMenuItem.Click += new System.EventHandler(this.jPGToolStripMenuItem_Click);
            // 
            // pNGToolStripMenuItem
            // 
            this.pNGToolStripMenuItem.CheckOnClick = true;
            this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
            this.pNGToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.pNGToolStripMenuItem.Text = "PNG";
            this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(614, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(353, 24);
            this.flowLayoutPanel4.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortNameNumber,
            this.SortByLength});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(58, 24);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SortNameNumber
            // 
            this.SortNameNumber.CheckOnClick = true;
            this.SortNameNumber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortNameNumber.Image = ((System.Drawing.Image)(resources.GetObject("SortNameNumber.Image")));
            this.SortNameNumber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortNameNumber.Name = "SortNameNumber";
            this.SortNameNumber.Size = new System.Drawing.Size(23, 21);
            this.SortNameNumber.Text = "Sort By Number";
            this.SortNameNumber.Click += new System.EventHandler(this.SortNameNumber_Click);
            // 
            // SortByLength
            // 
            this.SortByLength.CheckOnClick = true;
            this.SortByLength.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortByLength.Image = ((System.Drawing.Image)(resources.GetObject("SortByLength.Image")));
            this.SortByLength.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortByLength.Name = "SortByLength";
            this.SortByLength.Size = new System.Drawing.Size(23, 21);
            this.SortByLength.Text = "Sort Items By Names Length";
            this.SortByLength.Click += new System.EventHandler(this.SortByLength_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose Folder Directory To Save Files";
            // 
            // savePosition
            // 
            this.savePosition.Location = new System.Drawing.Point(103, 90);
            this.savePosition.Name = "savePosition";
            this.savePosition.Size = new System.Drawing.Size(95, 23);
            this.savePosition.TabIndex = 14;
            this.savePosition.Text = "Save Position";
            this.savePosition.UseVisualStyleBackColor = true;
            this.savePosition.Click += new System.EventHandler(this.savePosition_Click);
            // 
            // clearPositionList
            // 
            this.clearPositionList.Location = new System.Drawing.Point(204, 90);
            this.clearPositionList.Name = "clearPositionList";
            this.clearPositionList.Size = new System.Drawing.Size(98, 23);
            this.clearPositionList.TabIndex = 15;
            this.clearPositionList.Text = "Clear Pos. List";
            this.clearPositionList.UseVisualStyleBackColor = true;
            this.clearPositionList.Click += new System.EventHandler(this.clearPositionList_Click);
            // 
            // estimatePosition
            // 
            this.estimatePosition.AutoSize = true;
            this.estimatePosition.Enabled = false;
            this.estimatePosition.Location = new System.Drawing.Point(3, 119);
            this.estimatePosition.Name = "estimatePosition";
            this.estimatePosition.Size = new System.Drawing.Size(106, 17);
            this.estimatePosition.TabIndex = 16;
            this.estimatePosition.Text = "Estimate Position";
            this.estimatePosition.UseVisualStyleBackColor = true;
            this.estimatePosition.CheckedChanged += new System.EventHandler(this.estimatePosition_CheckedChanged);
            // 
            // newEstimatePoint
            // 
            this.newEstimatePoint.AutoSize = true;
            this.newEstimatePoint.Location = new System.Drawing.Point(92, 190);
            this.newEstimatePoint.Name = "newEstimatePoint";
            this.newEstimatePoint.Size = new System.Drawing.Size(100, 13);
            this.newEstimatePoint.TabIndex = 17;
            this.newEstimatePoint.Text = "Last Estimate Point:";
            // 
            // OpenPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 671);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OpenPicture";
            this.Text = "Open Picture";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSlider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.CheckBox dynamicSearth;
        private System.Windows.Forms.Button uncheckedButton;
        private System.Windows.Forms.Button loadUndo;
        private System.Windows.Forms.Button loadNext;
        private System.Windows.Forms.Button saveChedked;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button checkedButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TrackBar setX;
        private System.Windows.Forms.TrackBar setY;
        private System.Windows.Forms.TrackBar setWidth;
        private System.Windows.Forms.TrackBar setLength;
        private System.Windows.Forms.CheckBox drawingSet;
        private System.Windows.Forms.CheckBox setBackG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameReadSettingsToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SortNameNumber;
        private System.Windows.Forms.ToolStripButton SortByLength;
        private System.Windows.Forms.Button checkRange;
        private System.Windows.Forms.Label propDraw;
        private System.Windows.Forms.Label propBcg;
        private System.Windows.Forms.ToolStripMenuItem typeOfPicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jPGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
        private System.Windows.Forms.Button loadIterateButton;
        private System.Windows.Forms.TrackBar pictureSlider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savePosition;
        private System.Windows.Forms.Button clearPositionList;
        private System.Windows.Forms.CheckBox estimatePosition;
        private System.Windows.Forms.Label newEstimatePoint;
    }
}

