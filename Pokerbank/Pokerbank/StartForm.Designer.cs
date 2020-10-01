namespace Pokerbank
{
    partial class StartForm
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
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.lblGameNameLabel = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblStartMoney = new System.Windows.Forms.Label();
            this.lblStartMoneyLabel = new System.Windows.Forms.Label();
            this.lblPlayersLabel = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Location = new System.Drawing.Point(501, 349);
            this.btnNewPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(198, 41);
            this.btnNewPlayer.TabIndex = 2;
            this.btnNewPlayer.Text = "New game";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.newGame);
            // 
            // lblGameNameLabel
            // 
            this.lblGameNameLabel.AutoSize = true;
            this.lblGameNameLabel.Location = new System.Drawing.Point(14, 12);
            this.lblGameNameLabel.Name = "lblGameNameLabel";
            this.lblGameNameLabel.Size = new System.Drawing.Size(102, 20);
            this.lblGameNameLabel.TabIndex = 2;
            this.lblGameNameLabel.Text = "Current game:";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(14, 241);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.Size = new System.Drawing.Size(291, 343);
            this.dgvPlayers.TabIndex = 1;
            this.dgvPlayers.Text = "dataGridView1";
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameName.Location = new System.Drawing.Point(14, 32);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(0, 30);
            this.lblGameName.TabIndex = 3;
            // 
            // lblStartMoney
            // 
            this.lblStartMoney.AutoSize = true;
            this.lblStartMoney.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartMoney.Location = new System.Drawing.Point(14, 163);
            this.lblStartMoney.Name = "lblStartMoney";
            this.lblStartMoney.Size = new System.Drawing.Size(0, 25);
            this.lblStartMoney.TabIndex = 3;
            // 
            // lblStartMoneyLabel
            // 
            this.lblStartMoneyLabel.AutoSize = true;
            this.lblStartMoneyLabel.Location = new System.Drawing.Point(14, 143);
            this.lblStartMoneyLabel.Name = "lblStartMoneyLabel";
            this.lblStartMoneyLabel.Size = new System.Drawing.Size(89, 20);
            this.lblStartMoneyLabel.TabIndex = 2;
            this.lblStartMoneyLabel.Text = "Start money";
            // 
            // lblPlayersLabel
            // 
            this.lblPlayersLabel.AutoSize = true;
            this.lblPlayersLabel.Location = new System.Drawing.Point(14, 213);
            this.lblPlayersLabel.Name = "lblPlayersLabel";
            this.lblPlayersLabel.Size = new System.Drawing.Size(55, 20);
            this.lblPlayersLabel.TabIndex = 2;
            this.lblPlayersLabel.Text = "Players";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(501, 279);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(198, 41);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.playGame);
            // 
            // btnEditGame
            // 
            this.btnEditGame.Location = new System.Drawing.Point(501, 417);
            this.btnEditGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(198, 41);
            this.btnEditGame.TabIndex = 3;
            this.btnEditGame.Text = "Edit current game";
            this.btnEditGame.UseVisualStyleBackColor = true;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(14, 83);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 20);
            this.lblDateLabel.TabIndex = 2;
            this.lblDateLabel.Text = "Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(14, 103);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 25);
            this.lblDate.TabIndex = 3;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 600);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateLabel);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblPlayersLabel);
            this.Controls.Add(this.lblStartMoneyLabel);
            this.Controls.Add(this.lblStartMoney);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.lblGameNameLabel);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.btnNewPlayer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Label lblGameNameLabel;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblStartMoney;
        private System.Windows.Forms.Label lblStartMoneyLabel;
        private System.Windows.Forms.Label lblPlayersLabel;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnEditGame;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblDate;
    }
}