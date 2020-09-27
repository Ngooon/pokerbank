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
            this.nameLabel = new System.Windows.Forms.Label();
            this.playerTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.playerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Location = new System.Drawing.Point(527, 200);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(92, 31);
            this.btnNewPlayer.TabIndex = 0;
            this.btnNewPlayer.Text = "New game";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.NewGame);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(32, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "label1";
            // 
            // playerTable
            // 
            this.playerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerTable.Location = new System.Drawing.Point(18, 122);
            this.playerTable.Name = "playerTable";
            this.playerTable.ReadOnly = true;
            this.playerTable.Size = new System.Drawing.Size(422, 311);
            this.playerTable.TabIndex = 1;
            this.playerTable.Text = "dataGridView1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.playerTable);
            this.Controls.Add(this.btnNewPlayer);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.playerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.DataGridView playerTable;
        private System.Windows.Forms.Label nameLabel;
    }
}