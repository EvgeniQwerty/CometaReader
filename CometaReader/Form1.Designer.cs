
namespace CometaReader
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pauseButton = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.speedLabel = new System.Windows.Forms.Label();
            this.statLabel = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(797, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.Location = new System.Drawing.Point(12, 178);
            this.richTextBox.Multiline = false;
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(776, 96);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playButton.Location = new System.Drawing.Point(245, 41);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(120, 98);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "▶";
            this.playButton.UseCompatibleTextRendering = true;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "\"Text files(*.txt)|*.txt|All files(*.*)|*.*\";";
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pauseButton.Location = new System.Drawing.Point(413, 41);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(120, 98);
            this.pauseButton.TabIndex = 3;
            this.pauseButton.Text = "ll";
            this.pauseButton.UseCompatibleTextRendering = true;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(57, 415);
            this.numericUpDown.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.ReadOnly = true;
            this.numericUpDown.Size = new System.Drawing.Size(41, 23);
            this.numericUpDown.TabIndex = 4;
            this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(12, 417);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(39, 15);
            this.speedLabel.TabIndex = 5;
            this.speedLabel.Text = "Speed";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.Location = new System.Drawing.Point(331, 417);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(0, 15);
            this.statLabel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "CometaReader";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label statLabel;
    }
}

