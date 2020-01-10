namespace ThaoDoanAssignment1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.heuristicsBtn = new System.Windows.Forms.Button();
            this.NonIntelligentBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenFile = new System.Windows.Forms.Button();
            this.MethodLabel = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.MainMenuBtn = new System.Windows.Forms.Button();
            this.RestartBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.heuristicsBtn);
            this.panel1.Controls.Add(this.NonIntelligentBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 613);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(217, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 58);
            this.label1.TabIndex = 12;
            this.label1.Text = "K\'night Tour";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ExitBtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(180, 400);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(250, 40);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // heuristicsBtn
            // 
            this.heuristicsBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.heuristicsBtn.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heuristicsBtn.Location = new System.Drawing.Point(180, 350);
            this.heuristicsBtn.Name = "heuristicsBtn";
            this.heuristicsBtn.Size = new System.Drawing.Size(250, 40);
            this.heuristicsBtn.TabIndex = 10;
            this.heuristicsBtn.Text = "Heuristics Method";
            this.heuristicsBtn.UseVisualStyleBackColor = false;
            this.heuristicsBtn.Click += new System.EventHandler(this.HeuristicsBtn_Click);
            // 
            // NonIntelligentBtn
            // 
            this.NonIntelligentBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.NonIntelligentBtn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NonIntelligentBtn.Location = new System.Drawing.Point(180, 300);
            this.NonIntelligentBtn.Name = "NonIntelligentBtn";
            this.NonIntelligentBtn.Size = new System.Drawing.Size(250, 40);
            this.NonIntelligentBtn.TabIndex = 9;
            this.NonIntelligentBtn.Text = "Non Intelligent Method";
            this.NonIntelligentBtn.UseVisualStyleBackColor = false;
            this.NonIntelligentBtn.Click += new System.EventHandler(this.NonIntelligentBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.OpenFile);
            this.panel2.Controls.Add(this.MethodLabel);
            this.panel2.Controls.Add(this.Score);
            this.panel2.Controls.Add(this.MainMenuBtn);
            this.panel2.Controls.Add(this.RestartBtn);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 613);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(368, 536);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(115, 37);
            this.OpenFile.TabIndex = 15;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // MethodLabel
            // 
            this.MethodLabel.AutoSize = true;
            this.MethodLabel.BackColor = System.Drawing.Color.Transparent;
            this.MethodLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MethodLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MethodLabel.Location = new System.Drawing.Point(147, 21);
            this.MethodLabel.Name = "MethodLabel";
            this.MethodLabel.Size = new System.Drawing.Size(0, 29);
            this.MethodLabel.TabIndex = 14;
            this.MethodLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Score.Location = new System.Drawing.Point(191, 60);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(0, 29);
            this.Score.TabIndex = 13;
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenuBtn
            // 
            this.MainMenuBtn.Location = new System.Drawing.Point(218, 536);
            this.MainMenuBtn.Name = "MainMenuBtn";
            this.MainMenuBtn.Size = new System.Drawing.Size(131, 37);
            this.MainMenuBtn.TabIndex = 12;
            this.MainMenuBtn.Text = "Main Menu";
            this.MainMenuBtn.UseVisualStyleBackColor = true;
            this.MainMenuBtn.Click += new System.EventHandler(this.MainMenuBtn_Click_1);
            // 
            // RestartBtn
            // 
            this.RestartBtn.Location = new System.Drawing.Point(83, 536);
            this.RestartBtn.Name = "RestartBtn";
            this.RestartBtn.Size = new System.Drawing.Size(119, 37);
            this.RestartBtn.TabIndex = 11;
            this.RestartBtn.Text = "Restart";
            this.RestartBtn.UseVisualStyleBackColor = true;
            this.RestartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 117);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button heuristicsBtn;
        private System.Windows.Forms.Button NonIntelligentBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button MainMenuBtn;
        private System.Windows.Forms.Button RestartBtn;
        private System.Windows.Forms.Label MethodLabel;
        private System.Windows.Forms.Button OpenFile;
    }
}

