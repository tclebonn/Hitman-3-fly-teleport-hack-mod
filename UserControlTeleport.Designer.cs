
namespace Hitman3Reworked
{
    partial class UserControlTeleport
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSavePosition = new System.Windows.Forms.Button();
            this.buttonTeleportToSavedPosition = new System.Windows.Forms.Button();
            this.savedPositionsComboBox = new System.Windows.Forms.ComboBox();
            this.textboxmanualY = new System.Windows.Forms.TextBox();
            this.textboxmanualX = new System.Windows.Forms.TextBox();
            this.textboxmanualZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonTPToPosition = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSavePosition
            // 
            this.buttonSavePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSavePosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSavePosition.ForeColor = System.Drawing.Color.White;
            this.buttonSavePosition.Location = new System.Drawing.Point(220, 104);
            this.buttonSavePosition.Name = "buttonSavePosition";
            this.buttonSavePosition.Size = new System.Drawing.Size(169, 27);
            this.buttonSavePosition.TabIndex = 1;
            this.buttonSavePosition.Text = "Save new position";
            this.buttonSavePosition.UseVisualStyleBackColor = true;
            this.buttonSavePosition.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTeleportToSavedPosition
            // 
            this.buttonTeleportToSavedPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeleportToSavedPosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTeleportToSavedPosition.ForeColor = System.Drawing.Color.White;
            this.buttonTeleportToSavedPosition.Location = new System.Drawing.Point(395, 105);
            this.buttonTeleportToSavedPosition.Name = "buttonTeleportToSavedPosition";
            this.buttonTeleportToSavedPosition.Size = new System.Drawing.Size(168, 26);
            this.buttonTeleportToSavedPosition.TabIndex = 2;
            this.buttonTeleportToSavedPosition.Text = "TP to saved position";
            this.buttonTeleportToSavedPosition.UseVisualStyleBackColor = true;
            this.buttonTeleportToSavedPosition.Click += new System.EventHandler(this.buttonTeleportToSavedPosition_Click);
            // 
            // savedPositionsComboBox
            // 
            this.savedPositionsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savedPositionsComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savedPositionsComboBox.ForeColor = System.Drawing.Color.Black;
            this.savedPositionsComboBox.FormattingEnabled = true;
            this.savedPositionsComboBox.Location = new System.Drawing.Point(25, 105);
            this.savedPositionsComboBox.Name = "savedPositionsComboBox";
            this.savedPositionsComboBox.Size = new System.Drawing.Size(179, 26);
            this.savedPositionsComboBox.TabIndex = 3;
            // 
            // textboxmanualY
            // 
            this.textboxmanualY.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxmanualY.ForeColor = System.Drawing.Color.Black;
            this.textboxmanualY.Location = new System.Drawing.Point(25, 57);
            this.textboxmanualY.Name = "textboxmanualY";
            this.textboxmanualY.Size = new System.Drawing.Size(100, 26);
            this.textboxmanualY.TabIndex = 4;
            // 
            // textboxmanualX
            // 
            this.textboxmanualX.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxmanualX.ForeColor = System.Drawing.Color.Black;
            this.textboxmanualX.Location = new System.Drawing.Point(131, 57);
            this.textboxmanualX.Name = "textboxmanualX";
            this.textboxmanualX.Size = new System.Drawing.Size(100, 26);
            this.textboxmanualX.TabIndex = 5;
            // 
            // textboxmanualZ
            // 
            this.textboxmanualZ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxmanualZ.ForeColor = System.Drawing.Color.Black;
            this.textboxmanualZ.Location = new System.Drawing.Point(237, 57);
            this.textboxmanualZ.Name = "textboxmanualZ";
            this.textboxmanualZ.Size = new System.Drawing.Size(100, 26);
            this.textboxmanualZ.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(284, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Z";
            // 
            // buttonTPToPosition
            // 
            this.buttonTPToPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTPToPosition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTPToPosition.ForeColor = System.Drawing.Color.White;
            this.buttonTPToPosition.Location = new System.Drawing.Point(343, 57);
            this.buttonTPToPosition.Name = "buttonTPToPosition";
            this.buttonTPToPosition.Size = new System.Drawing.Size(123, 26);
            this.buttonTPToPosition.TabIndex = 10;
            this.buttonTPToPosition.Text = "TP to position";
            this.buttonTPToPosition.UseVisualStyleBackColor = true;
            this.buttonTPToPosition.Click += new System.EventHandler(this.buttonTPToPosition_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Make sure to write a name before save a position\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "NumPad 3: TP to saved position";
            // 
            // UserControlTeleport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTPToPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxmanualZ);
            this.Controls.Add(this.textboxmanualX);
            this.Controls.Add(this.textboxmanualY);
            this.Controls.Add(this.savedPositionsComboBox);
            this.Controls.Add(this.buttonTeleportToSavedPosition);
            this.Controls.Add(this.buttonSavePosition);
            this.Name = "UserControlTeleport";
            this.Size = new System.Drawing.Size(578, 349);
            this.Load += new System.EventHandler(this.UserControlTeleport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSavePosition;
        private System.Windows.Forms.Button buttonTeleportToSavedPosition;
        private System.Windows.Forms.ComboBox savedPositionsComboBox;
        private System.Windows.Forms.TextBox textboxmanualY;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonTPToPosition;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textboxmanualX;
        private System.Windows.Forms.TextBox textboxmanualZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
