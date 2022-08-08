namespace AI_Tictactoe
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
            this.lblGameInfo = new System.Windows.Forms.Label();
            this.dgvBoard = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameInfo
            // 
            this.lblGameInfo.AutoSize = true;
            this.lblGameInfo.Location = new System.Drawing.Point(174, 106);
            this.lblGameInfo.Name = "lblGameInfo";
            this.lblGameInfo.Size = new System.Drawing.Size(0, 13);
            this.lblGameInfo.TabIndex = 1;
            // 
            // dgvBoard
            // 
            this.dgvBoard.AllowUserToResizeColumns = false;
            this.dgvBoard.AllowUserToResizeRows = false;
            this.dgvBoard.ColumnHeadersVisible = false;
            this.dgvBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvBoard.Location = new System.Drawing.Point(9, 8);
            this.dgvBoard.Margin = new System.Windows.Forms.Padding(0);
            this.dgvBoard.Name = "dgvBoard";
            this.dgvBoard.RowHeadersVisible = false;
            this.dgvBoard.RowTemplate.Height = 50;
            this.dgvBoard.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBoard.Size = new System.Drawing.Size(153, 153);
            this.dgvBoard.TabIndex = 2;
            this.dgvBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoard_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Text = "";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(165, 139);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEasy
            // 
            this.btnEasy.Location = new System.Drawing.Point(165, 9);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(75, 23);
            this.btnEasy.TabIndex = 4;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(165, 38);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 5;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.Location = new System.Drawing.Point(165, 67);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(75, 23);
            this.btnHard.TabIndex = 6;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "<---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvBoard);
            this.Controls.Add(this.lblGameInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGameInfo;
        private System.Windows.Forms.DataGridView dgvBoard;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

