namespace Pokerbank
{
    partial class NewGameForm
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
            this.txbGameName = new System.Windows.Forms.TextBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.txbDate = new System.Windows.Forms.TextBox();
            this.lblGameDate = new System.Windows.Forms.Label();
            this.gbxPlayers = new System.Windows.Forms.GroupBox();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGameName
            // 
            this.txbGameName.Location = new System.Drawing.Point(21, 40);
            this.txbGameName.Name = "txbGameName";
            this.txbGameName.Size = new System.Drawing.Size(228, 23);
            this.txbGameName.TabIndex = 1;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(21, 22);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(71, 15);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "Game name";
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(21, 94);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(228, 23);
            this.txbDate.TabIndex = 2;
            // 
            // lblGameDate
            // 
            this.lblGameDate.AutoSize = true;
            this.lblGameDate.Location = new System.Drawing.Point(21, 76);
            this.lblGameDate.Name = "lblGameDate";
            this.lblGameDate.Size = new System.Drawing.Size(31, 15);
            this.lblGameDate.TabIndex = 1;
            this.lblGameDate.Text = "Date";
            // 
            // gbxPlayers
            // 
            this.gbxPlayers.Controls.Add(this.dgvPlayers);
            this.gbxPlayers.Location = new System.Drawing.Point(300, 22);
            this.gbxPlayers.Name = "gbxPlayers";
            this.gbxPlayers.Size = new System.Drawing.Size(312, 306);
            this.gbxPlayers.TabIndex = 2;
            this.gbxPlayers.TabStop = false;
            this.gbxPlayers.Text = "Players";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMoney});
            this.dgvPlayers.Location = new System.Drawing.Point(7, 23);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(299, 277);
            this.dgvPlayers.TabIndex = 3;
            this.dgvPlayers.Text = "dataGridView1";
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colMoney
            // 
            this.colMoney.HeaderText = "Money";
            this.colMoney.Name = "colMoney";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(174, 299);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveForm);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 344);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxPlayers);
            this.Controls.Add(this.lblGameDate);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txbGameName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewGameForm";
            this.Text = "New game";
            this.gbxPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGameName;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.TextBox txbDate;
        private System.Windows.Forms.Label lblGameDate;
        private System.Windows.Forms.GroupBox gbxPlayers;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
    }
}

