namespace lb10_11
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
            panel1 = new Panel();
            textBox2 = new TextBox();
            TextEdit = new RadioButton();
            label1 = new Label();
            button2 = new Button();
            Paste = new RadioButton();
            Select = new RadioButton();
            Elips = new RadioButton();
            PipetteMode = new RadioButton();
            Drawing = new RadioButton();
            domainUpDown1 = new DomainUpDown();
            colorSecondary = new Button();
            colorPrimary = new Button();
            numericPenSize = new HScrollBar();
            BtFill = new RadioButton();
            BtEraser = new RadioButton();
            pencilButton = new RadioButton();
            menuStrip1 = new MenuStrip();
            failToolStripMenuItem = new ToolStripMenuItem();
            seveMemoToolStripMenuItem = new ToolStripMenuItem();
            loadMemoToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            pictureToolStripMenuItem = new ToolStripMenuItem();
            cancelToolStripMenuItem = new ToolStripMenuItem();
            createToolStripMenuItem = new ToolStripMenuItem();
            bindingSource1 = new BindingSource(components);
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            fontDialog1 = new FontDialog();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(TextEdit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Paste);
            panel1.Controls.Add(Select);
            panel1.Controls.Add(Elips);
            panel1.Controls.Add(PipetteMode);
            panel1.Controls.Add(Drawing);
            panel1.Controls.Add(domainUpDown1);
            panel1.Controls.Add(colorSecondary);
            panel1.Controls.Add(colorPrimary);
            panel1.Controls.Add(numericPenSize);
            panel1.Controls.Add(BtFill);
            panel1.Controls.Add(BtEraser);
            panel1.Controls.Add(pencilButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 53);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1122, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 14;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // TextEdit
            // 
            TextEdit.AutoSize = true;
            TextEdit.Location = new Point(537, 18);
            TextEdit.Name = "TextEdit";
            TextEdit.Size = new Size(66, 19);
            TextEdit.TabIndex = 13;
            TextEdit.TabStop = true;
            TextEdit.Text = "TextEdit";
            TextEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1054, 20);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 12;
            label1.Text = "Example";
            label1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(951, 16);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Edit front";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // Paste
            // 
            Paste.AutoSize = true;
            Paste.Location = new Point(478, 18);
            Paste.Name = "Paste";
            Paste.Size = new Size(53, 19);
            Paste.TabIndex = 10;
            Paste.TabStop = true;
            Paste.Text = "Paste";
            Paste.UseVisualStyleBackColor = true;
            Paste.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // Select
            // 
            Select.AutoSize = true;
            Select.Location = new Point(416, 18);
            Select.Name = "Select";
            Select.Size = new Size(56, 19);
            Select.TabIndex = 9;
            Select.TabStop = true;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = true;
            Select.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // Elips
            // 
            Elips.AutoSize = true;
            Elips.Location = new Point(361, 18);
            Elips.Name = "Elips";
            Elips.Size = new Size(49, 19);
            Elips.TabIndex = 8;
            Elips.TabStop = true;
            Elips.Text = "Elips";
            Elips.UseVisualStyleBackColor = true;
            Elips.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // PipetteMode
            // 
            PipetteMode.AutoSize = true;
            PipetteMode.Location = new Point(240, 18);
            PipetteMode.Name = "PipetteMode";
            PipetteMode.Size = new Size(62, 19);
            PipetteMode.TabIndex = 7;
            PipetteMode.TabStop = true;
            PipetteMode.Text = "Pipette";
            PipetteMode.UseVisualStyleBackColor = true;
            PipetteMode.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // Drawing
            // 
            Drawing.AutoSize = true;
            Drawing.Location = new Point(308, 18);
            Drawing.Name = "Drawing";
            Drawing.Size = new Size(47, 19);
            Drawing.TabIndex = 6;
            Drawing.TabStop = true;
            Drawing.Text = "Line";
            Drawing.UseVisualStyleBackColor = true;
            Drawing.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("Solid");
            domainUpDown1.Items.Add("Dash");
            domainUpDown1.Items.Add("DashDot ");
            domainUpDown1.Items.Add("DashDotDot");
            domainUpDown1.Location = new Point(810, 16);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(120, 23);
            domainUpDown1.TabIndex = 5;
            domainUpDown1.Text = "domainUpDown1";
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // colorSecondary
            // 
            colorSecondary.BackColor = Color.White;
            colorSecondary.Location = new Point(741, 7);
            colorSecondary.Name = "colorSecondary";
            colorSecondary.Size = new Size(63, 36);
            colorSecondary.TabIndex = 5;
            colorSecondary.UseVisualStyleBackColor = false;
            colorSecondary.Click += colorSecondary_Click;
            // 
            // colorPrimary
            // 
            colorPrimary.BackColor = Color.Black;
            colorPrimary.Location = new Point(672, 7);
            colorPrimary.Name = "colorPrimary";
            colorPrimary.Size = new Size(63, 36);
            colorPrimary.TabIndex = 4;
            colorPrimary.UseVisualStyleBackColor = false;
            colorPrimary.Click += button2_Click;
            // 
            // numericPenSize
            // 
            numericPenSize.Location = new Point(589, 7);
            numericPenSize.Maximum = 15;
            numericPenSize.Minimum = 1;
            numericPenSize.Name = "numericPenSize";
            numericPenSize.Size = new Size(80, 17);
            numericPenSize.TabIndex = 3;
            numericPenSize.Value = 1;
            numericPenSize.Scroll += numericPenSize_Scroll;
            // 
            // BtFill
            // 
            BtFill.AutoSize = true;
            BtFill.Location = new Point(179, 16);
            BtFill.Name = "BtFill";
            BtFill.Size = new Size(55, 19);
            BtFill.TabIndex = 2;
            BtFill.TabStop = true;
            BtFill.Text = "Brush";
            BtFill.UseVisualStyleBackColor = true;
            BtFill.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // BtEraser
            // 
            BtEraser.AutoSize = true;
            BtEraser.Location = new Point(112, 16);
            BtEraser.Name = "BtEraser";
            BtEraser.Size = new Size(61, 19);
            BtEraser.TabIndex = 1;
            BtEraser.TabStop = true;
            BtEraser.Text = "Lastick";
            BtEraser.UseVisualStyleBackColor = true;
            BtEraser.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // pencilButton
            // 
            pencilButton.AutoSize = true;
            pencilButton.Location = new Point(12, 16);
            pencilButton.Name = "pencilButton";
            pencilButton.Size = new Size(91, 19);
            pencilButton.TabIndex = 0;
            pencilButton.TabStop = true;
            pencilButton.Text = "DrawingLine";
            pencilButton.UseVisualStyleBackColor = true;
            pencilButton.CheckedChanged += pencilButton_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { failToolStripMenuItem, pictureToolStripMenuItem, createToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1234, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // failToolStripMenuItem
            // 
            failToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { seveMemoToolStripMenuItem, loadMemoToolStripMenuItem, saveToolStripMenuItem, loadToolStripMenuItem });
            failToolStripMenuItem.Name = "failToolStripMenuItem";
            failToolStripMenuItem.Size = new Size(35, 20);
            failToolStripMenuItem.Text = "fail";
            // 
            // seveMemoToolStripMenuItem
            // 
            seveMemoToolStripMenuItem.Name = "seveMemoToolStripMenuItem";
            seveMemoToolStripMenuItem.Size = new Size(135, 22);
            seveMemoToolStripMenuItem.Text = "seve memo";
            seveMemoToolStripMenuItem.Click += seveMemoToolStripMenuItem_Click;
            // 
            // loadMemoToolStripMenuItem
            // 
            loadMemoToolStripMenuItem.Name = "loadMemoToolStripMenuItem";
            loadMemoToolStripMenuItem.Size = new Size(135, 22);
            loadMemoToolStripMenuItem.Text = "load memo";
            loadMemoToolStripMenuItem.Click += loadMemoToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(135, 22);
            saveToolStripMenuItem.Text = "save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(135, 22);
            loadToolStripMenuItem.Text = "load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // pictureToolStripMenuItem
            // 
            pictureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cancelToolStripMenuItem });
            pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            pictureToolStripMenuItem.Size = new Size(56, 20);
            pictureToolStripMenuItem.Text = "Picture";
            // 
            // cancelToolStripMenuItem
            // 
            cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            cancelToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            cancelToolStripMenuItem.Size = new Size(151, 22);
            cancelToolStripMenuItem.Text = "Cancel";
            cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(53, 20);
            createToolStripMenuItem.Text = "Create";
            createToolStripMenuItem.Click += createToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(0, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(959, 447);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(976, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(228, 447);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(0, 559);
            button1.Name = "button1";
            button1.Size = new Size(1234, 25);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 584);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem failToolStripMenuItem;
        private RadioButton BtFill;
        private RadioButton BtEraser;
        private RadioButton pencilButton;
        private BindingSource bindingSource1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private HScrollBar numericPenSize;
        private Button button1;
        private Button colorPrimary;
        private ColorDialog colorDialog1;
        private Button colorSecondary;
        private ColorDialog colorDialog2;
        private ToolStripMenuItem pictureToolStripMenuItem;
        private ToolStripMenuItem cancelToolStripMenuItem;
        private DomainUpDown domainUpDown1;
        private RadioButton PipetteMode;
        private RadioButton Drawing;
        private RadioButton Elips;
        private RadioButton Select;
        private RadioButton Paste;
        private Label label1;
        private Button button2;
        private FontDialog fontDialog1;
        private RadioButton TextEdit;
        private TextBox textBox2;
        private ToolStripMenuItem seveMemoToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem loadMemoToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
    }
}
