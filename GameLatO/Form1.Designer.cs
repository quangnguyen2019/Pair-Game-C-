namespace GameLatO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerForCells = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.numcUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbNotification = new System.Windows.Forms.Label();
            this.lbTimeRemaining = new System.Windows.Forms.Label();
            this.timerCountdown = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panelCountdown = new System.Windows.Forms.Panel();
            this.cbLevels = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcUpDownColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRow)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelCountdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerForCells
            // 
            this.timerForCells.Interval = 300;
            this.timerForCells.Tick += new System.EventHandler(this.timerForCells_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "003-Venusaur-icon.png");
            this.imageList1.Images.SetKeyName(1, "006-Charizard-icon.png");
            this.imageList1.Images.SetKeyName(2, "009-Blastoise-icon.png");
            this.imageList1.Images.SetKeyName(3, "012-Butterfree-icon.png");
            this.imageList1.Images.SetKeyName(4, "015-Beedrill-icon.png");
            this.imageList1.Images.SetKeyName(5, "018-Pidgeot-icon.png");
            this.imageList1.Images.SetKeyName(6, "020-Raticate-icon.png");
            this.imageList1.Images.SetKeyName(7, "021-Spearow-icon.png");
            this.imageList1.Images.SetKeyName(8, "022-Fearow-icon.png");
            this.imageList1.Images.SetKeyName(9, "025-Pikachu-icon.png");
            this.imageList1.Images.SetKeyName(10, "026-Raichu-icon.png");
            this.imageList1.Images.SetKeyName(11, "037-Vulpix-icon.png");
            this.imageList1.Images.SetKeyName(12, "038-Ninetales-icon.png");
            this.imageList1.Images.SetKeyName(13, "059-Arcanine-icon.png");
            this.imageList1.Images.SetKeyName(14, "069-Bellsprout-icon.png");
            this.imageList1.Images.SetKeyName(15, "078-Rapidash-icon.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLevels);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Controls.Add(this.numcUpDownColumn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numUpDownRow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 41);
            this.panel2.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(483, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 36);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Start";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // numcUpDownColumn
            // 
            this.numcUpDownColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcUpDownColumn.Location = new System.Drawing.Point(145, 11);
            this.numcUpDownColumn.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numcUpDownColumn.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numcUpDownColumn.Name = "numcUpDownColumn";
            this.numcUpDownColumn.Size = new System.Drawing.Size(63, 22);
            this.numcUpDownColumn.TabIndex = 3;
            this.numcUpDownColumn.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Columns";
            // 
            // numUpDownRow
            // 
            this.numUpDownRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownRow.Location = new System.Drawing.Point(12, 11);
            this.numUpDownRow.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numUpDownRow.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownRow.Name = "numUpDownRow";
            this.numUpDownRow.Size = new System.Drawing.Size(63, 22);
            this.numUpDownRow.TabIndex = 1;
            this.numUpDownRow.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rows";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(21, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 62);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(24, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(575, 362);
            this.panel3.TabIndex = 6;
            // 
            // lbNotification
            // 
            this.lbNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNotification.AutoSize = true;
            this.lbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Red;
            this.lbNotification.Location = new System.Drawing.Point(259, 525);
            this.lbNotification.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(136, 25);
            this.lbNotification.TabIndex = 8;
            this.lbNotification.Text = "lbNotification";
            // 
            // lbTimeRemaining
            // 
            this.lbTimeRemaining.AutoSize = true;
            this.lbTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeRemaining.Location = new System.Drawing.Point(34, 0);
            this.lbTimeRemaining.Name = "lbTimeRemaining";
            this.lbTimeRemaining.Size = new System.Drawing.Size(117, 42);
            this.lbTimeRemaining.TabIndex = 7;
            this.lbTimeRemaining.Text = "00:00";
            // 
            // timerCountdown
            // 
            this.timerCountdown.Interval = 1000;
            this.timerCountdown.Tick += new System.EventHandler(this.timerCountdown_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = " ";
            // 
            // panelCountdown
            // 
            this.panelCountdown.Controls.Add(this.lbTimeRemaining);
            this.panelCountdown.Controls.Add(this.label4);
            this.panelCountdown.Location = new System.Drawing.Point(236, 87);
            this.panelCountdown.Name = "panelCountdown";
            this.panelCountdown.Size = new System.Drawing.Size(155, 42);
            this.panelCountdown.TabIndex = 10;
            // 
            // cbLevels
            // 
            this.cbLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevels.FormattingEnabled = true;
            this.cbLevels.Location = new System.Drawing.Point(298, 11);
            this.cbLevels.Name = "cbLevels";
            this.cbLevels.Size = new System.Drawing.Size(160, 24);
            this.cbLevels.TabIndex = 5;
            this.cbLevels.SelectedIndexChanged += new System.EventHandler(this.cbLevels_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 578);
            this.Controls.Add(this.panelCountdown);
            this.Controls.Add(this.lbNotification);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pairs Game";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numcUpDownColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRow)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelCountdown.ResumeLayout(false);
            this.panelCountdown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerForCells;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.NumericUpDown numcUpDownColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownRow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTimeRemaining;
        private System.Windows.Forms.Timer timerCountdown;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelCountdown;
        private System.Windows.Forms.ComboBox cbLevels;
    }
}

