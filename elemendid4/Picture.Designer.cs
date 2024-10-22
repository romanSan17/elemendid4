namespace Elemendid_vormis_TARpv23
{
    partial class Picture
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            SwapButton = new Button();
            backgroundButton = new Button();
            CloseButton = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            clearButton = new Button();
            showButton = new Button();
            rotate = new Button();
            Zoom = new Button();
            Reset = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ShowButton2 = new Button();
            ClearButton2 = new Button();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            openFileDialog4 = new OpenFileDialog();
            openFileDialog5 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65.51724F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2413788F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2413788F));
            tableLayoutPanel1.Size = new Size(790, 384);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            tableLayoutPanel1.SetColumnSpan(flowLayoutPanel3, 4);
            flowLayoutPanel3.Controls.Add(CloseButton);
            flowLayoutPanel3.Controls.Add(backgroundButton);
            flowLayoutPanel3.Controls.Add(SwapButton);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel3.Location = new Point(3, 320);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(784, 61);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // SwapButton
            // 
            SwapButton.AutoSize = true;
            SwapButton.Location = new Point(240, 33);
            SwapButton.Name = "SwapButton";
            SwapButton.Size = new Size(75, 25);
            SwapButton.TabIndex = 4;
            SwapButton.Text = "Swap";
            SwapButton.UseVisualStyleBackColor = true;
            SwapButton.Click += SwapButton_Click;
            // 
            // backgroundButton
            // 
            backgroundButton.AutoSize = true;
            backgroundButton.Location = new Point(84, 33);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(150, 25);
            backgroundButton.TabIndex = 2;
            backgroundButton.Text = "Set the background color";
            backgroundButton.UseVisualStyleBackColor = true;
            backgroundButton.Click += backgroundButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Location = new Point(3, 33);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 25);
            CloseButton.TabIndex = 3;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox2, 2);
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(398, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(389, 245);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(389, 245);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 254);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(showButton);
            flowLayoutPanel1.Controls.Add(rotate);
            flowLayoutPanel1.Controls.Add(Zoom);
            flowLayoutPanel1.Controls.Add(Reset);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(82, 254);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(310, 60);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Location = new Point(203, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(104, 25);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear the picture";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.Location = new Point(111, 3);
            showButton.Name = "showButton";
            showButton.Size = new Size(86, 25);
            showButton.TabIndex = 0;
            showButton.Text = "Show picture";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // rotate
            // 
            rotate.AutoSize = true;
            rotate.Location = new Point(14, 3);
            rotate.Name = "rotate";
            rotate.Size = new Size(91, 25);
            rotate.TabIndex = 4;
            rotate.Text = "Rotate picture";
            rotate.UseVisualStyleBackColor = true;
            rotate.Click += rotate_Click;
            // 
            // Zoom
            // 
            Zoom.AutoSize = true;
            Zoom.Location = new Point(216, 34);
            Zoom.Name = "Zoom";
            Zoom.Size = new Size(91, 25);
            Zoom.TabIndex = 5;
            Zoom.Text = "Zoom";
            Zoom.UseVisualStyleBackColor = true;
            Zoom.Click += Zoom_Click;
            // 
            // Reset
            // 
            Reset.AutoSize = true;
            Reset.Location = new Point(119, 34);
            Reset.Name = "Reset";
            Reset.Size = new Size(91, 25);
            Reset.TabIndex = 6;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(ClearButton2);
            flowLayoutPanel2.Controls.Add(ShowButton2);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(398, 254);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(310, 60);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // ShowButton2
            // 
            ShowButton2.AutoSize = true;
            ShowButton2.Location = new Point(93, 3);
            ShowButton2.Name = "ShowButton2";
            ShowButton2.Size = new Size(95, 25);
            ShowButton2.TabIndex = 1;
            ShowButton2.Text = "Show picture 2";
            ShowButton2.UseVisualStyleBackColor = true;
            ShowButton2.Click += ShowButton2_Click;
            // 
            // ClearButton2
            // 
            ClearButton2.AutoSize = true;
            ClearButton2.Location = new Point(194, 3);
            ClearButton2.Name = "ClearButton2";
            ClearButton2.Size = new Size(113, 25);
            ClearButton2.TabIndex = 2;
            ClearButton2.Text = "Clear the picture 2";
            ClearButton2.UseVisualStyleBackColor = true;
            ClearButton2.Click += ClearButton2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Select a picture file";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog1";
            openFileDialog2.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog2.Title = "Select a picture file";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog1";
            openFileDialog3.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog3.Title = "Select a picture file";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog1";
            openFileDialog4.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog4.Title = "Select a picture file";
            // 
            // openFileDialog5
            // 
            openFileDialog5.FileName = "openFileDialog5";
            openFileDialog5.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog5.Title = "Select a picture file 2";
            openFileDialog5.FileOk += openFileDialog5_FileOk;
            // 
            // Picture
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 384);
            Controls.Add(tableLayoutPanel1);
            Name = "Picture";
            Text = "Picture";
            Load += Picture_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button showButton;
        private Button clearButton;
        private Button backgroundButton;
        private Button CloseButton;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private Button rotate;
        private Button Zoom;
        private Button Reset;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button ShowButton2;
        private Button ClearButton2;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private OpenFileDialog openFileDialog4;
        private OpenFileDialog openFileDialog5;
        private Button SwapButton;
    }
}