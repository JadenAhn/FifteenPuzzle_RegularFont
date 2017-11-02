namespace JAhnAssignment3
{
    partial class GameBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.quitAltF3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.pnlTile = new System.Windows.Forms.Panel();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.lblClickNumber = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuLoadFile,
            this.menuSaveFile,
            this.quitAltF3ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuNewGame
            // 
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(185, 22);
            this.menuNewGame.Text = "New Game     Ctrl+N";
            this.menuNewGame.Click += new System.EventHandler(this.MenuNewGame_Click);
            // 
            // menuLoadFile
            // 
            this.menuLoadFile.Name = "menuLoadFile";
            this.menuLoadFile.Size = new System.Drawing.Size(185, 22);
            this.menuLoadFile.Text = "Load Game     Ctrl+O";
            this.menuLoadFile.Click += new System.EventHandler(this.MenuLoadFile_Click);
            // 
            // menuSaveFile
            // 
            this.menuSaveFile.Name = "menuSaveFile";
            this.menuSaveFile.Size = new System.Drawing.Size(185, 22);
            this.menuSaveFile.Text = "Save Game     Ctrl+S";
            this.menuSaveFile.Click += new System.EventHandler(this.MenuSaveFile_Click);
            // 
            // quitAltF3ToolStripMenuItem
            // 
            this.quitAltF3ToolStripMenuItem.Name = "quitAltF3ToolStripMenuItem";
            this.quitAltF3ToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.quitAltF3ToolStripMenuItem.Text = "Quit                Alt+F4";
            this.quitAltF3ToolStripMenuItem.Click += new System.EventHandler(this.quitAltF3ToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.lblSubTitle);
            this.pnlMenu.Controls.Add(this.lblTitle);
            this.pnlMenu.Controls.Add(this.cbSize);
            this.pnlMenu.Controls.Add(this.cbDifficulty);
            this.pnlMenu.Controls.Add(this.btnGenerate);
            this.pnlMenu.Controls.Add(this.lblDifficulty);
            this.pnlMenu.Controls.Add(this.lblSize);
            this.pnlMenu.Location = new System.Drawing.Point(3, 38);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(381, 319);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.lblSubTitle.ForeColor = System.Drawing.Color.White;
            this.lblSubTitle.Location = new System.Drawing.Point(110, 77);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(199, 78);
            this.lblSubTitle.TabIndex = 4;
            this.lblSubTitle.Text = "puzzle";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(79)))));
            this.lblTitle.Location = new System.Drawing.Point(58, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(206, 78);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "fifteen";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "3 x 3",
            "4 x 4",
            "5 x 5"});
            this.cbSize.Location = new System.Drawing.Point(181, 193);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(102, 20);
            this.cbSize.TabIndex = 1;
            this.cbSize.Text = "4 x 4";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "HELL"});
            this.cbDifficulty.Location = new System.Drawing.Point(181, 224);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(102, 20);
            this.cbDifficulty.TabIndex = 2;
            this.cbDifficulty.Text = "Easy";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(123, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(137, 34);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Start Game";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Gulim", 9F);
            this.lblDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblDifficulty.Location = new System.Drawing.Point(107, 225);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(52, 12);
            this.lblDifficulty.TabIndex = 1;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Gulim", 9F);
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(120, 194);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 12);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size";
            // 
            // pnlTile
            // 
            this.pnlTile.Location = new System.Drawing.Point(0, 35);
            this.pnlTile.Name = "pnlTile";
            this.pnlTile.Size = new System.Drawing.Size(70, 60);
            this.pnlTile.TabIndex = 2;
            // 
            // dlgSave
            // 
            this.dlgSave.InitialDirectory = "C:\\";
            this.dlgSave.RestoreDirectory = true;
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // lblClickNumber
            // 
            this.lblClickNumber.AutoSize = true;
            this.lblClickNumber.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblClickNumber.ForeColor = System.Drawing.Color.White;
            this.lblClickNumber.Location = new System.Drawing.Point(8, 25);
            this.lblClickNumber.Name = "lblClickNumber";
            this.lblClickNumber.Size = new System.Drawing.Size(0, 15);
            this.lblClickNumber.TabIndex = 3;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(168)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lblClickNumber);
            this.Controls.Add(this.pnlTile);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameBoard";
            this.Text = "15 Puzzle";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem menuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem menuLoadFile;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Panel pnlTile;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Label lblClickNumber;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.ToolStripMenuItem quitAltF3ToolStripMenuItem;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
    }
}

