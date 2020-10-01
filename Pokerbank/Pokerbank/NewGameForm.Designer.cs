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
            this.cbxStandardMoney = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbStartMoney = new System.Windows.Forms.TextBox();
            this.lblStartMoneyLabel = new System.Windows.Forms.Label();
            this.gbxPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGameName
            // 
            this.txbGameName.Location = new System.Drawing.Point(24, 53);
            this.txbGameName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbGameName.Name = "txbGameName";
            this.txbGameName.Size = new System.Drawing.Size(260, 27);
            this.txbGameName.TabIndex = 1;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Location = new System.Drawing.Point(24, 29);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(89, 20);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "Game name";
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(24, 125);
            this.txbDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(260, 27);
            this.txbDate.TabIndex = 2;
            // 
            // lblGameDate
            // 
            this.lblGameDate.AutoSize = true;
            this.lblGameDate.Location = new System.Drawing.Point(24, 101);
            this.lblGameDate.Name = "lblGameDate";
            this.lblGameDate.Size = new System.Drawing.Size(41, 20);
            this.lblGameDate.TabIndex = 1;
            this.lblGameDate.Text = "Date";
            // 
            // gbxPlayers
            // 
            this.gbxPlayers.Controls.Add(this.dgvPlayers);
            this.gbxPlayers.Location = new System.Drawing.Point(343, 29);
            this.gbxPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPlayers.Name = "gbxPlayers";
            this.gbxPlayers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxPlayers.Size = new System.Drawing.Size(357, 408);
            this.gbxPlayers.TabIndex = 2;
            this.gbxPlayers.TabStop = false;
            this.gbxPlayers.Text = "Players";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colMoney,
            this.cbxStandardMoney});
            this.dgvPlayers.Location = new System.Drawing.Point(8, 31);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.Size = new System.Drawing.Size(342, 369);
            this.dgvPlayers.TabIndex = 3;
            this.dgvPlayers.Text = "dataGridView1";
            this.dgvPlayers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateReadOnly);
            this.dgvPlayers.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.newRowUpdate);
            // 
            // colName
            // 
            this.colName.Frozen = true;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colName.Width = 125;
            // 
            // colMoney
            // 
            this.colMoney.HeaderText = "Money";
            this.colMoney.MinimumWidth = 6;
            this.colMoney.Name = "colMoney";
            this.colMoney.ReadOnly = true;
            this.colMoney.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMoney.Width = 125;
            // 
            // cbxStandardMoney
            // 
            this.cbxStandardMoney.HeaderText = "";
            this.cbxStandardMoney.MinimumWidth = 25;
            this.cbxStandardMoney.Name = "cbxStandardMoney";
            this.cbxStandardMoney.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cbxStandardMoney.Width = 25;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(14, 399);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(198, 398);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveForm);
            // 
            // txbStartMoney
            // 
            this.txbStartMoney.Location = new System.Drawing.Point(24, 199);
            this.txbStartMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbStartMoney.Name = "txbStartMoney";
            this.txbStartMoney.Size = new System.Drawing.Size(260, 27);
            this.txbStartMoney.TabIndex = 2;
            // 
            // lblStartMoneyLabel
            // 
            this.lblStartMoneyLabel.AutoSize = true;
            this.lblStartMoneyLabel.Location = new System.Drawing.Point(24, 175);
            this.lblStartMoneyLabel.Name = "lblStartMoneyLabel";
            this.lblStartMoneyLabel.Size = new System.Drawing.Size(89, 20);
            this.lblStartMoneyLabel.TabIndex = 1;
            this.lblStartMoneyLabel.Text = "Start money";
            // 
            // NewGameForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(728, 459);
            this.Controls.Add(this.lblStartMoneyLabel);
            this.Controls.Add(this.txbStartMoney);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxPlayers);
            this.Controls.Add(this.lblGameDate);
            this.Controls.Add(this.txbDate);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.txbGameName);
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
        public System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbStartMoney;
        private System.Windows.Forms.Label lblStartMoneyLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbxStandardMoney;
    }
}

