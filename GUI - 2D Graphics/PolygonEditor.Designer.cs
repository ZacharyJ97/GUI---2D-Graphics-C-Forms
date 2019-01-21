namespace GUI___2D_Graphics
{
    partial class PolygonEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolygonEditor));
            this.Canvas = new System.Windows.Forms.Panel();
            this.FillButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.RedRB = new System.Windows.Forms.RadioButton();
            this.GreenRB = new System.Windows.Forms.RadioButton();
            this.BlueRB = new System.Windows.Forms.RadioButton();
            this.YellowRB = new System.Windows.Forms.RadioButton();
            this.fillLabel = new System.Windows.Forms.Label();
            this.FillRedRB = new System.Windows.Forms.RadioButton();
            this.FillGreenRB = new System.Windows.Forms.RadioButton();
            this.FillBlueRB = new System.Windows.Forms.RadioButton();
            this.FillYellowRB = new System.Windows.Forms.RadioButton();
            this.LineColorRBGroup = new System.Windows.Forms.GroupBox();
            this.CustomColorLineRB = new System.Windows.Forms.RadioButton();
            this.RedrawLinesBtn = new System.Windows.Forms.Button();
            this.LineColorPalBtn = new System.Windows.Forms.Button();
            this.PinkRB = new System.Windows.Forms.RadioButton();
            this.OrangeRB = new System.Windows.Forms.RadioButton();
            this.PurpleRB = new System.Windows.Forms.RadioButton();
            this.whiteRB = new System.Windows.Forms.RadioButton();
            this.BlackRB = new System.Windows.Forms.RadioButton();
            this.FillColorRBGroup = new System.Windows.Forms.GroupBox();
            this.CustomColorFillRB = new System.Windows.Forms.RadioButton();
            this.FillColorPalBtn = new System.Windows.Forms.Button();
            this.FillPinkRB = new System.Windows.Forms.RadioButton();
            this.FillWhiteRB = new System.Windows.Forms.RadioButton();
            this.FillOrangeRB = new System.Windows.Forms.RadioButton();
            this.FillPurpleRB = new System.Windows.Forms.RadioButton();
            this.FillBlackRB = new System.Windows.Forms.RadioButton();
            this.DrawVertex = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SizingLabel = new System.Windows.Forms.Label();
            this.CanvasStyleInfo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.VertexSizeLabel = new System.Windows.Forms.Label();
            this.VertexSizeScaler = new System.Windows.Forms.NumericUpDown();
            this.LineSizeScaler = new System.Windows.Forms.NumericUpDown();
            this.LineSizeLabel = new System.Windows.Forms.Label();
            this.FillVertex = new System.Windows.Forms.CheckBox();
            this.BackgroundCB = new System.Windows.Forms.ComboBox();
            this.ChangeBGLabel = new System.Windows.Forms.Label();
            this.ClearCanvasBtn = new System.Windows.Forms.Button();
            this.FillAllLinesBtn = new System.Windows.Forms.Button();
            this.NewShapeBtn = new System.Windows.Forms.Button();
            this.lineColorPalette = new System.Windows.Forms.ColorDialog();
            this.fillColorPalette = new System.Windows.Forms.ColorDialog();
            this.RedrawLinesTip = new System.Windows.Forms.ToolTip(this.components);
            this.CanvasStyleTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomColorTip = new System.Windows.Forms.ToolTip(this.components);
            this.CustomColorTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.FillShapeTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewShapeTip = new System.Windows.Forms.ToolTip(this.components);
            this.CompleteForMeTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetCanvasTip = new System.Windows.Forms.ToolTip(this.components);
            this.BGColorPalette = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LineColorRBGroup.SuspendLayout();
            this.FillColorRBGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VertexSizeScaler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineSizeScaler)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.AutoSize = true;
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Location = new System.Drawing.Point(13, 13);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(692, 680);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_OnPaint);
            this.Canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseClick);
            // 
            // FillButton
            // 
            this.FillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillButton.Location = new System.Drawing.Point(6, 140);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(170, 38);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Fill in Shape";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(6, 233);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(183, 25);
            this.ColorLabel.TabIndex = 2;
            this.ColorLabel.Text = "Select a Line Color:";
            // 
            // RedRB
            // 
            this.RedRB.AutoSize = true;
            this.RedRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedRB.Location = new System.Drawing.Point(6, 13);
            this.RedRB.Name = "RedRB";
            this.RedRB.Size = new System.Drawing.Size(72, 29);
            this.RedRB.TabIndex = 3;
            this.RedRB.Text = "Red";
            this.RedRB.UseVisualStyleBackColor = true;
            this.RedRB.CheckedChanged += new System.EventHandler(this.RedRB_CheckedChanged);
            // 
            // GreenRB
            // 
            this.GreenRB.AutoSize = true;
            this.GreenRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreenRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenRB.Location = new System.Drawing.Point(92, 13);
            this.GreenRB.Name = "GreenRB";
            this.GreenRB.Size = new System.Drawing.Size(91, 29);
            this.GreenRB.TabIndex = 4;
            this.GreenRB.Text = "Green";
            this.GreenRB.UseVisualStyleBackColor = true;
            this.GreenRB.CheckedChanged += new System.EventHandler(this.GreenRB_CheckedChanged);
            // 
            // BlueRB
            // 
            this.BlueRB.AutoSize = true;
            this.BlueRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlueRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueRB.Location = new System.Drawing.Point(6, 48);
            this.BlueRB.Name = "BlueRB";
            this.BlueRB.Size = new System.Drawing.Size(76, 29);
            this.BlueRB.TabIndex = 5;
            this.BlueRB.Text = "Blue";
            this.BlueRB.UseVisualStyleBackColor = true;
            this.BlueRB.CheckedChanged += new System.EventHandler(this.BlueRB_CheckedChanged);
            // 
            // YellowRB
            // 
            this.YellowRB.AutoSize = true;
            this.YellowRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YellowRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowRB.Location = new System.Drawing.Point(91, 48);
            this.YellowRB.Name = "YellowRB";
            this.YellowRB.Size = new System.Drawing.Size(94, 29);
            this.YellowRB.TabIndex = 6;
            this.YellowRB.Text = "Yellow";
            this.YellowRB.UseVisualStyleBackColor = true;
            this.YellowRB.CheckedChanged += new System.EventHandler(this.YellowRB_CheckedChanged);
            // 
            // fillLabel
            // 
            this.fillLabel.AutoSize = true;
            this.fillLabel.BackColor = System.Drawing.Color.Transparent;
            this.fillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillLabel.Location = new System.Drawing.Point(6, 436);
            this.fillLabel.Name = "fillLabel";
            this.fillLabel.Size = new System.Drawing.Size(170, 25);
            this.fillLabel.TabIndex = 7;
            this.fillLabel.Text = "Select a Fill Color:";
            // 
            // FillRedRB
            // 
            this.FillRedRB.AutoSize = true;
            this.FillRedRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillRedRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillRedRB.Location = new System.Drawing.Point(6, 25);
            this.FillRedRB.Name = "FillRedRB";
            this.FillRedRB.Size = new System.Drawing.Size(72, 29);
            this.FillRedRB.TabIndex = 8;
            this.FillRedRB.Text = "Red";
            this.FillRedRB.UseVisualStyleBackColor = true;
            this.FillRedRB.CheckedChanged += new System.EventHandler(this.FillRedRB_CheckedChanged);
            // 
            // FillGreenRB
            // 
            this.FillGreenRB.AutoSize = true;
            this.FillGreenRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillGreenRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillGreenRB.Location = new System.Drawing.Point(91, 25);
            this.FillGreenRB.Name = "FillGreenRB";
            this.FillGreenRB.Size = new System.Drawing.Size(91, 29);
            this.FillGreenRB.TabIndex = 9;
            this.FillGreenRB.Text = "Green";
            this.FillGreenRB.UseVisualStyleBackColor = true;
            this.FillGreenRB.CheckedChanged += new System.EventHandler(this.FillGreenRB_CheckedChanged);
            // 
            // FillBlueRB
            // 
            this.FillBlueRB.AutoSize = true;
            this.FillBlueRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillBlueRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillBlueRB.Location = new System.Drawing.Point(6, 60);
            this.FillBlueRB.Name = "FillBlueRB";
            this.FillBlueRB.Size = new System.Drawing.Size(76, 29);
            this.FillBlueRB.TabIndex = 10;
            this.FillBlueRB.Text = "Blue";
            this.FillBlueRB.UseVisualStyleBackColor = true;
            this.FillBlueRB.CheckedChanged += new System.EventHandler(this.FillBlueRB_CheckedChanged);
            // 
            // FillYellowRB
            // 
            this.FillYellowRB.AutoSize = true;
            this.FillYellowRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillYellowRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillYellowRB.Location = new System.Drawing.Point(91, 60);
            this.FillYellowRB.Name = "FillYellowRB";
            this.FillYellowRB.Size = new System.Drawing.Size(94, 29);
            this.FillYellowRB.TabIndex = 11;
            this.FillYellowRB.Text = "Yellow";
            this.FillYellowRB.UseVisualStyleBackColor = true;
            this.FillYellowRB.CheckedChanged += new System.EventHandler(this.FillYellowRB_CheckedChanged);
            // 
            // LineColorRBGroup
            // 
            this.LineColorRBGroup.BackColor = System.Drawing.Color.Transparent;
            this.LineColorRBGroup.Controls.Add(this.CustomColorLineRB);
            this.LineColorRBGroup.Controls.Add(this.RedrawLinesBtn);
            this.LineColorRBGroup.Controls.Add(this.LineColorPalBtn);
            this.LineColorRBGroup.Controls.Add(this.PinkRB);
            this.LineColorRBGroup.Controls.Add(this.OrangeRB);
            this.LineColorRBGroup.Controls.Add(this.PurpleRB);
            this.LineColorRBGroup.Controls.Add(this.whiteRB);
            this.LineColorRBGroup.Controls.Add(this.BlackRB);
            this.LineColorRBGroup.Controls.Add(this.RedRB);
            this.LineColorRBGroup.Controls.Add(this.BlueRB);
            this.LineColorRBGroup.Controls.Add(this.GreenRB);
            this.LineColorRBGroup.Controls.Add(this.YellowRB);
            this.LineColorRBGroup.Location = new System.Drawing.Point(6, 261);
            this.LineColorRBGroup.Name = "LineColorRBGroup";
            this.LineColorRBGroup.Size = new System.Drawing.Size(307, 172);
            this.LineColorRBGroup.TabIndex = 12;
            this.LineColorRBGroup.TabStop = false;
            // 
            // CustomColorLineRB
            // 
            this.CustomColorLineRB.AutoSize = true;
            this.CustomColorLineRB.Location = new System.Drawing.Point(211, 135);
            this.CustomColorLineRB.Name = "CustomColorLineRB";
            this.CustomColorLineRB.Size = new System.Drawing.Size(21, 20);
            this.CustomColorLineRB.TabIndex = 30;
            this.CustomColorLineRB.TabStop = true;
            this.CustomColorLineRB.UseVisualStyleBackColor = true;
            this.CustomColorLineRB.CheckedChanged += new System.EventHandler(this.CustomColorLineRB_CheckedChanged);
            // 
            // RedrawLinesBtn
            // 
            this.RedrawLinesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedrawLinesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedrawLinesBtn.Location = new System.Drawing.Point(6, 126);
            this.RedrawLinesBtn.Name = "RedrawLinesBtn";
            this.RedrawLinesBtn.Size = new System.Drawing.Size(199, 38);
            this.RedrawLinesBtn.TabIndex = 25;
            this.RedrawLinesBtn.Text = "Redraw My Lines";
            this.RedrawLinesBtn.UseVisualStyleBackColor = true;
            this.RedrawLinesBtn.Click += new System.EventHandler(this.RedrawLinesBtn_Click);
            // 
            // LineColorPalBtn
            // 
            this.LineColorPalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LineColorPalBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LineColorPalBtn.BackgroundImage")));
            this.LineColorPalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineColorPalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LineColorPalBtn.Location = new System.Drawing.Point(235, 126);
            this.LineColorPalBtn.Name = "LineColorPalBtn";
            this.LineColorPalBtn.Size = new System.Drawing.Size(66, 38);
            this.LineColorPalBtn.TabIndex = 27;
            this.LineColorPalBtn.UseVisualStyleBackColor = false;
            this.LineColorPalBtn.Click += new System.EventHandler(this.LineColorPalBtn_Click);
            // 
            // PinkRB
            // 
            this.PinkRB.AutoSize = true;
            this.PinkRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinkRB.Location = new System.Drawing.Point(193, 83);
            this.PinkRB.Name = "PinkRB";
            this.PinkRB.Size = new System.Drawing.Size(75, 29);
            this.PinkRB.TabIndex = 17;
            this.PinkRB.TabStop = true;
            this.PinkRB.Text = "Pink";
            this.PinkRB.UseVisualStyleBackColor = true;
            this.PinkRB.CheckedChanged += new System.EventHandler(this.PinkRB_CheckedChanged);
            // 
            // OrangeRB
            // 
            this.OrangeRB.AutoSize = true;
            this.OrangeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrangeRB.Location = new System.Drawing.Point(193, 48);
            this.OrangeRB.Name = "OrangeRB";
            this.OrangeRB.Size = new System.Drawing.Size(103, 29);
            this.OrangeRB.TabIndex = 16;
            this.OrangeRB.TabStop = true;
            this.OrangeRB.Text = "Orange";
            this.OrangeRB.UseVisualStyleBackColor = true;
            this.OrangeRB.CheckedChanged += new System.EventHandler(this.OrangeRB_CheckedChanged);
            // 
            // PurpleRB
            // 
            this.PurpleRB.AutoSize = true;
            this.PurpleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurpleRB.Location = new System.Drawing.Point(193, 13);
            this.PurpleRB.Name = "PurpleRB";
            this.PurpleRB.Size = new System.Drawing.Size(93, 29);
            this.PurpleRB.TabIndex = 15;
            this.PurpleRB.TabStop = true;
            this.PurpleRB.Text = "Purple";
            this.PurpleRB.UseVisualStyleBackColor = true;
            this.PurpleRB.CheckedChanged += new System.EventHandler(this.PurpleRB_CheckedChanged);
            // 
            // whiteRB
            // 
            this.whiteRB.AutoSize = true;
            this.whiteRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteRB.Location = new System.Drawing.Point(91, 83);
            this.whiteRB.Name = "whiteRB";
            this.whiteRB.Size = new System.Drawing.Size(88, 29);
            this.whiteRB.TabIndex = 14;
            this.whiteRB.TabStop = true;
            this.whiteRB.Text = "White";
            this.whiteRB.UseVisualStyleBackColor = true;
            this.whiteRB.CheckedChanged += new System.EventHandler(this.whiteRB_CheckedChanged);
            // 
            // BlackRB
            // 
            this.BlackRB.AutoSize = true;
            this.BlackRB.Checked = true;
            this.BlackRB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlackRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackRB.Location = new System.Drawing.Point(6, 84);
            this.BlackRB.Name = "BlackRB";
            this.BlackRB.Size = new System.Drawing.Size(85, 29);
            this.BlackRB.TabIndex = 7;
            this.BlackRB.TabStop = true;
            this.BlackRB.Text = "Black";
            this.BlackRB.UseVisualStyleBackColor = true;
            this.BlackRB.CheckedChanged += new System.EventHandler(this.BlackRB_CheckedChanged);
            // 
            // FillColorRBGroup
            // 
            this.FillColorRBGroup.BackColor = System.Drawing.Color.Transparent;
            this.FillColorRBGroup.Controls.Add(this.CustomColorFillRB);
            this.FillColorRBGroup.Controls.Add(this.FillColorPalBtn);
            this.FillColorRBGroup.Controls.Add(this.FillPinkRB);
            this.FillColorRBGroup.Controls.Add(this.FillWhiteRB);
            this.FillColorRBGroup.Controls.Add(this.FillOrangeRB);
            this.FillColorRBGroup.Controls.Add(this.FillPurpleRB);
            this.FillColorRBGroup.Controls.Add(this.FillBlackRB);
            this.FillColorRBGroup.Controls.Add(this.FillYellowRB);
            this.FillColorRBGroup.Controls.Add(this.FillRedRB);
            this.FillColorRBGroup.Controls.Add(this.FillGreenRB);
            this.FillColorRBGroup.Controls.Add(this.FillBlueRB);
            this.FillColorRBGroup.Controls.Add(this.FillButton);
            this.FillColorRBGroup.Location = new System.Drawing.Point(6, 464);
            this.FillColorRBGroup.Name = "FillColorRBGroup";
            this.FillColorRBGroup.Size = new System.Drawing.Size(307, 184);
            this.FillColorRBGroup.TabIndex = 13;
            this.FillColorRBGroup.TabStop = false;
            // 
            // CustomColorFillRB
            // 
            this.CustomColorFillRB.AutoSize = true;
            this.CustomColorFillRB.Location = new System.Drawing.Point(208, 147);
            this.CustomColorFillRB.Name = "CustomColorFillRB";
            this.CustomColorFillRB.Size = new System.Drawing.Size(21, 20);
            this.CustomColorFillRB.TabIndex = 29;
            this.CustomColorFillRB.TabStop = true;
            this.CustomColorFillRB.UseVisualStyleBackColor = true;
            this.CustomColorFillRB.CheckedChanged += new System.EventHandler(this.CustomColorFillRB_CheckedChanged);
            // 
            // FillColorPalBtn
            // 
            this.FillColorPalBtn.BackColor = System.Drawing.SystemColors.Control;
            this.FillColorPalBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FillColorPalBtn.BackgroundImage")));
            this.FillColorPalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillColorPalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillColorPalBtn.Location = new System.Drawing.Point(235, 138);
            this.FillColorPalBtn.Name = "FillColorPalBtn";
            this.FillColorPalBtn.Size = new System.Drawing.Size(66, 38);
            this.FillColorPalBtn.TabIndex = 28;
            this.FillColorPalBtn.UseVisualStyleBackColor = false;
            this.FillColorPalBtn.Click += new System.EventHandler(this.FillColorPalBtn_Click);
            // 
            // FillPinkRB
            // 
            this.FillPinkRB.AutoSize = true;
            this.FillPinkRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillPinkRB.Location = new System.Drawing.Point(193, 95);
            this.FillPinkRB.Name = "FillPinkRB";
            this.FillPinkRB.Size = new System.Drawing.Size(75, 29);
            this.FillPinkRB.TabIndex = 20;
            this.FillPinkRB.TabStop = true;
            this.FillPinkRB.Text = "Pink";
            this.FillPinkRB.UseVisualStyleBackColor = true;
            this.FillPinkRB.CheckedChanged += new System.EventHandler(this.FillPinkRB_CheckedChanged);
            // 
            // FillWhiteRB
            // 
            this.FillWhiteRB.AutoSize = true;
            this.FillWhiteRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillWhiteRB.Location = new System.Drawing.Point(91, 96);
            this.FillWhiteRB.Name = "FillWhiteRB";
            this.FillWhiteRB.Size = new System.Drawing.Size(88, 29);
            this.FillWhiteRB.TabIndex = 13;
            this.FillWhiteRB.TabStop = true;
            this.FillWhiteRB.Text = "White";
            this.FillWhiteRB.UseVisualStyleBackColor = true;
            this.FillWhiteRB.CheckedChanged += new System.EventHandler(this.FillWhiteRB_CheckedChanged);
            // 
            // FillOrangeRB
            // 
            this.FillOrangeRB.AutoSize = true;
            this.FillOrangeRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillOrangeRB.Location = new System.Drawing.Point(193, 60);
            this.FillOrangeRB.Name = "FillOrangeRB";
            this.FillOrangeRB.Size = new System.Drawing.Size(103, 29);
            this.FillOrangeRB.TabIndex = 19;
            this.FillOrangeRB.TabStop = true;
            this.FillOrangeRB.Text = "Orange";
            this.FillOrangeRB.UseVisualStyleBackColor = true;
            this.FillOrangeRB.CheckedChanged += new System.EventHandler(this.FillOrangeRB_CheckedChanged);
            // 
            // FillPurpleRB
            // 
            this.FillPurpleRB.AutoSize = true;
            this.FillPurpleRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillPurpleRB.Location = new System.Drawing.Point(193, 25);
            this.FillPurpleRB.Name = "FillPurpleRB";
            this.FillPurpleRB.Size = new System.Drawing.Size(93, 29);
            this.FillPurpleRB.TabIndex = 18;
            this.FillPurpleRB.TabStop = true;
            this.FillPurpleRB.Text = "Purple";
            this.FillPurpleRB.UseVisualStyleBackColor = true;
            this.FillPurpleRB.CheckedChanged += new System.EventHandler(this.FillPurpleRB_CheckedChanged);
            // 
            // FillBlackRB
            // 
            this.FillBlackRB.AutoSize = true;
            this.FillBlackRB.Checked = true;
            this.FillBlackRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillBlackRB.Location = new System.Drawing.Point(7, 96);
            this.FillBlackRB.Name = "FillBlackRB";
            this.FillBlackRB.Size = new System.Drawing.Size(85, 29);
            this.FillBlackRB.TabIndex = 12;
            this.FillBlackRB.TabStop = true;
            this.FillBlackRB.Text = "Black";
            this.FillBlackRB.UseVisualStyleBackColor = true;
            this.FillBlackRB.CheckedChanged += new System.EventHandler(this.FillBlackRB_CheckedChanged);
            // 
            // DrawVertex
            // 
            this.DrawVertex.AutoSize = true;
            this.DrawVertex.BackColor = System.Drawing.Color.Transparent;
            this.DrawVertex.Checked = true;
            this.DrawVertex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawVertex.Location = new System.Drawing.Point(6, 84);
            this.DrawVertex.Name = "DrawVertex";
            this.DrawVertex.Size = new System.Drawing.Size(215, 29);
            this.DrawVertex.TabIndex = 14;
            this.DrawVertex.Text = "Draw Vertex Points?";
            this.DrawVertex.UseVisualStyleBackColor = false;
            this.DrawVertex.CheckedChanged += new System.EventHandler(this.DrawVertex_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.SizingLabel);
            this.groupBox3.Controls.Add(this.CanvasStyleInfo);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.BackgroundCB);
            this.groupBox3.Controls.Add(this.ChangeBGLabel);
            this.groupBox3.Controls.Add(this.ClearCanvasBtn);
            this.groupBox3.Controls.Add(this.FillAllLinesBtn);
            this.groupBox3.Controls.Add(this.FillColorRBGroup);
            this.groupBox3.Controls.Add(this.fillLabel);
            this.groupBox3.Controls.Add(this.LineColorRBGroup);
            this.groupBox3.Controls.Add(this.ColorLabel);
            this.groupBox3.Controls.Add(this.NewShapeBtn);
            this.groupBox3.Location = new System.Drawing.Point(711, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 692);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "drawn point/line.";
            // 
            // SizingLabel
            // 
            this.SizingLabel.AutoSize = true;
            this.SizingLabel.BackColor = System.Drawing.Color.Transparent;
            this.SizingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizingLabel.Location = new System.Drawing.Point(261, 132);
            this.SizingLabel.Name = "SizingLabel";
            this.SizingLabel.Size = new System.Drawing.Size(218, 22);
            this.SizingLabel.TabIndex = 28;
            this.SizingLabel.Text = "*Changes apply to next";
            // 
            // CanvasStyleInfo
            // 
            this.CanvasStyleInfo.AutoSize = true;
            this.CanvasStyleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanvasStyleInfo.Location = new System.Drawing.Point(261, 22);
            this.CanvasStyleInfo.Name = "CanvasStyleInfo";
            this.CanvasStyleInfo.Size = new System.Drawing.Size(251, 22);
            this.CanvasStyleInfo.TabIndex = 27;
            this.CanvasStyleInfo.Text = "*Best to first select a style.";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.VertexSizeLabel);
            this.groupBox4.Controls.Add(this.VertexSizeScaler);
            this.groupBox4.Controls.Add(this.LineSizeScaler);
            this.groupBox4.Controls.Add(this.LineSizeLabel);
            this.groupBox4.Controls.Add(this.FillVertex);
            this.groupBox4.Controls.Add(this.DrawVertex);
            this.groupBox4.Location = new System.Drawing.Point(5, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 154);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // VertexSizeLabel
            // 
            this.VertexSizeLabel.AutoSize = true;
            this.VertexSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.VertexSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VertexSizeLabel.Location = new System.Drawing.Point(6, 12);
            this.VertexSizeLabel.Name = "VertexSizeLabel";
            this.VertexSizeLabel.Size = new System.Drawing.Size(119, 25);
            this.VertexSizeLabel.TabIndex = 17;
            this.VertexSizeLabel.Text = "Vertex Size:";
            // 
            // VertexSizeScaler
            // 
            this.VertexSizeScaler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VertexSizeScaler.Location = new System.Drawing.Point(131, 12);
            this.VertexSizeScaler.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.VertexSizeScaler.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VertexSizeScaler.Name = "VertexSizeScaler";
            this.VertexSizeScaler.Size = new System.Drawing.Size(69, 30);
            this.VertexSizeScaler.TabIndex = 15;
            this.VertexSizeScaler.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VertexSizeScaler.ValueChanged += new System.EventHandler(this.VertexSizeScaler_ValueChanged);
            // 
            // LineSizeScaler
            // 
            this.LineSizeScaler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineSizeScaler.Location = new System.Drawing.Point(131, 48);
            this.LineSizeScaler.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.LineSizeScaler.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LineSizeScaler.Name = "LineSizeScaler";
            this.LineSizeScaler.Size = new System.Drawing.Size(69, 30);
            this.LineSizeScaler.TabIndex = 19;
            this.LineSizeScaler.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.LineSizeScaler.ValueChanged += new System.EventHandler(this.LineSizeScaler_ValueChanged);
            // 
            // LineSizeLabel
            // 
            this.LineSizeLabel.AutoSize = true;
            this.LineSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.LineSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineSizeLabel.Location = new System.Drawing.Point(26, 50);
            this.LineSizeLabel.Name = "LineSizeLabel";
            this.LineSizeLabel.Size = new System.Drawing.Size(99, 25);
            this.LineSizeLabel.TabIndex = 20;
            this.LineSizeLabel.Text = "Line Size:";
            // 
            // FillVertex
            // 
            this.FillVertex.AutoSize = true;
            this.FillVertex.BackColor = System.Drawing.Color.Transparent;
            this.FillVertex.Checked = true;
            this.FillVertex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FillVertex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillVertex.Location = new System.Drawing.Point(6, 119);
            this.FillVertex.Name = "FillVertex";
            this.FillVertex.Size = new System.Drawing.Size(194, 29);
            this.FillVertex.TabIndex = 16;
            this.FillVertex.Text = "Fill Vertex Points?";
            this.FillVertex.UseVisualStyleBackColor = false;
            this.FillVertex.CheckedChanged += new System.EventHandler(this.FillVertex_CheckedChanged);
            // 
            // BackgroundCB
            // 
            this.BackgroundCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackgroundCB.FormattingEnabled = true;
            this.BackgroundCB.Items.AddRange(new object[] {
            "Solid White",
            "Solid Black",
            "Small Grid on White",
            "Small Grid on Black",
            "Large Grid on White",
            "Large Grid on Black",
            "Custom Color",
            "Custom Color w/ Small Grid"});
            this.BackgroundCB.Location = new System.Drawing.Point(5, 37);
            this.BackgroundCB.MaxDropDownItems = 4;
            this.BackgroundCB.Name = "BackgroundCB";
            this.BackgroundCB.Size = new System.Drawing.Size(250, 33);
            this.BackgroundCB.TabIndex = 23;
            this.BackgroundCB.Text = "Select a Canvas Style";
            this.BackgroundCB.SelectedValueChanged += new System.EventHandler(this.BackgroundCB_SelectedIndexChanged);
            // 
            // ChangeBGLabel
            // 
            this.ChangeBGLabel.AutoSize = true;
            this.ChangeBGLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChangeBGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBGLabel.Location = new System.Drawing.Point(0, 9);
            this.ChangeBGLabel.Name = "ChangeBGLabel";
            this.ChangeBGLabel.Size = new System.Drawing.Size(161, 25);
            this.ChangeBGLabel.TabIndex = 24;
            this.ChangeBGLabel.Text = "Change Canvas:";
            // 
            // ClearCanvasBtn
            // 
            this.ClearCanvasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearCanvasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCanvasBtn.Location = new System.Drawing.Point(358, 649);
            this.ClearCanvasBtn.Name = "ClearCanvasBtn";
            this.ClearCanvasBtn.Size = new System.Drawing.Size(174, 40);
            this.ClearCanvasBtn.TabIndex = 22;
            this.ClearCanvasBtn.Text = "Reset Canvas";
            this.ClearCanvasBtn.UseVisualStyleBackColor = true;
            this.ClearCanvasBtn.Click += new System.EventHandler(this.ClearCanvasBtn_Click);
            // 
            // FillAllLinesBtn
            // 
            this.FillAllLinesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillAllLinesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillAllLinesBtn.Location = new System.Drawing.Point(6, 651);
            this.FillAllLinesBtn.Name = "FillAllLinesBtn";
            this.FillAllLinesBtn.Size = new System.Drawing.Size(307, 38);
            this.FillAllLinesBtn.TabIndex = 21;
            this.FillAllLinesBtn.Text = "Complete Polygon for Me";
            this.FillAllLinesBtn.UseVisualStyleBackColor = true;
            this.FillAllLinesBtn.Click += new System.EventHandler(this.FillAllLinesBtn_Click);
            // 
            // NewShapeBtn
            // 
            this.NewShapeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewShapeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewShapeBtn.Location = new System.Drawing.Point(358, 605);
            this.NewShapeBtn.Name = "NewShapeBtn";
            this.NewShapeBtn.Size = new System.Drawing.Size(174, 38);
            this.NewShapeBtn.TabIndex = 18;
            this.NewShapeBtn.Text = "Start New Shape";
            this.NewShapeBtn.UseVisualStyleBackColor = true;
            this.NewShapeBtn.Click += new System.EventHandler(this.NewShapeBtn_Click);
            // 
            // lineColorPalette
            // 
            this.lineColorPalette.AnyColor = true;
            // 
            // fillColorPalette
            // 
            this.fillColorPalette.AnyColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(262, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "*If you rescale the canvas,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "then reset the style.";
            // 
            // PolygonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 708);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Canvas);
            this.DoubleBuffered = true;
            this.Name = "PolygonEditor";
            this.Text = "Polygon Creator";
            this.Load += new System.EventHandler(this.PolygonEditor_Load);
            this.LineColorRBGroup.ResumeLayout(false);
            this.LineColorRBGroup.PerformLayout();
            this.FillColorRBGroup.ResumeLayout(false);
            this.FillColorRBGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VertexSizeScaler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineSizeScaler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.RadioButton RedRB;
        private System.Windows.Forms.RadioButton GreenRB;
        private System.Windows.Forms.RadioButton BlueRB;
        private System.Windows.Forms.RadioButton YellowRB;
        private System.Windows.Forms.Label fillLabel;
        private System.Windows.Forms.RadioButton FillRedRB;
        private System.Windows.Forms.RadioButton FillGreenRB;
        private System.Windows.Forms.RadioButton FillBlueRB;
        private System.Windows.Forms.RadioButton FillYellowRB;
        private System.Windows.Forms.GroupBox LineColorRBGroup;
        private System.Windows.Forms.GroupBox FillColorRBGroup;
        private System.Windows.Forms.RadioButton BlackRB;
        private System.Windows.Forms.CheckBox DrawVertex;
        private System.Windows.Forms.RadioButton FillBlackRB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown VertexSizeScaler;
        private System.Windows.Forms.CheckBox FillVertex;
        private System.Windows.Forms.Label VertexSizeLabel;
        private System.Windows.Forms.Button NewShapeBtn;
        private System.Windows.Forms.RadioButton FillWhiteRB;
        private System.Windows.Forms.RadioButton whiteRB;
        private System.Windows.Forms.NumericUpDown LineSizeScaler;
        private System.Windows.Forms.Label LineSizeLabel;
        private System.Windows.Forms.RadioButton PinkRB;
        private System.Windows.Forms.RadioButton OrangeRB;
        private System.Windows.Forms.RadioButton PurpleRB;
        private System.Windows.Forms.RadioButton FillPinkRB;
        private System.Windows.Forms.RadioButton FillOrangeRB;
        private System.Windows.Forms.RadioButton FillPurpleRB;
        private System.Windows.Forms.Button FillAllLinesBtn;
        private System.Windows.Forms.Button ClearCanvasBtn;
        private System.Windows.Forms.ComboBox BackgroundCB;
        private System.Windows.Forms.Label ChangeBGLabel;
        private System.Windows.Forms.Button RedrawLinesBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button LineColorPalBtn;
        private System.Windows.Forms.ColorDialog lineColorPalette;
        private System.Windows.Forms.Button FillColorPalBtn;
        private System.Windows.Forms.ColorDialog fillColorPalette;
        private System.Windows.Forms.RadioButton CustomColorLineRB;
        private System.Windows.Forms.RadioButton CustomColorFillRB;
        private System.Windows.Forms.ToolTip RedrawLinesTip;
        private System.Windows.Forms.Label CanvasStyleInfo;
        private System.Windows.Forms.ToolTip CanvasStyleTip;
        private System.Windows.Forms.Label SizingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip CustomColorTip;
        private System.Windows.Forms.ToolTip CustomColorTip2;
        private System.Windows.Forms.ToolTip FillShapeTip;
        private System.Windows.Forms.ToolTip NewShapeTip;
        private System.Windows.Forms.ToolTip CompleteForMeTip;
        private System.Windows.Forms.ToolTip ResetCanvasTip;
        private System.Windows.Forms.ColorDialog BGColorPalette;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

