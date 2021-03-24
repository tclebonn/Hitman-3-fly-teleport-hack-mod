
namespace Hitman3Reworked
{
    partial class UserControlMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMainPage));
            this.CheckBoxXAxis = new System.Windows.Forms.CheckBox();
            this.CheckBoxYAxis = new System.Windows.Forms.CheckBox();
            this.TextBoxXMultiplier = new System.Windows.Forms.TextBox();
            this.textBoxYMultiplier = new System.Windows.Forms.TextBox();
            this.buttonXAxis = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckBoxXAxis
            // 
            this.CheckBoxXAxis.AutoSize = true;
            this.CheckBoxXAxis.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxXAxis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxXAxis.ForeColor = System.Drawing.Color.White;
            this.CheckBoxXAxis.Location = new System.Drawing.Point(42, 36);
            this.CheckBoxXAxis.Name = "CheckBoxXAxis";
            this.CheckBoxXAxis.Size = new System.Drawing.Size(138, 22);
            this.CheckBoxXAxis.TabIndex = 0;
            this.CheckBoxXAxis.Text = "Active X / Z axis";
            this.CheckBoxXAxis.UseVisualStyleBackColor = false;
            this.CheckBoxXAxis.CheckedChanged += new System.EventHandler(this.CheckBoxXAxis_CheckedChanged);
            // 
            // CheckBoxYAxis
            // 
            this.CheckBoxYAxis.AutoSize = true;
            this.CheckBoxYAxis.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxYAxis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckBoxYAxis.ForeColor = System.Drawing.Color.White;
            this.CheckBoxYAxis.Location = new System.Drawing.Point(42, 72);
            this.CheckBoxYAxis.Name = "CheckBoxYAxis";
            this.CheckBoxYAxis.Size = new System.Drawing.Size(115, 22);
            this.CheckBoxYAxis.TabIndex = 18;
            this.CheckBoxYAxis.Text = "Active Y axis";
            this.CheckBoxYAxis.UseVisualStyleBackColor = false;
            this.CheckBoxYAxis.CheckedChanged += new System.EventHandler(this.CheckBoxYAxis_CheckedChanged);
            // 
            // TextBoxXMultiplier
            // 
            this.TextBoxXMultiplier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TextBoxXMultiplier.Location = new System.Drawing.Point(224, 35);
            this.TextBoxXMultiplier.Name = "TextBoxXMultiplier";
            this.TextBoxXMultiplier.Size = new System.Drawing.Size(100, 21);
            this.TextBoxXMultiplier.TabIndex = 2;
            this.TextBoxXMultiplier.Text = "0.05";
            // 
            // textBoxYMultiplier
            // 
            this.textBoxYMultiplier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxYMultiplier.Location = new System.Drawing.Point(224, 71);
            this.textBoxYMultiplier.Name = "textBoxYMultiplier";
            this.textBoxYMultiplier.Size = new System.Drawing.Size(100, 21);
            this.textBoxYMultiplier.TabIndex = 3;
            this.textBoxYMultiplier.Text = "0.01";
            // 
            // buttonXAxis
            // 
            this.buttonXAxis.BackColor = System.Drawing.Color.Transparent;
            this.buttonXAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXAxis.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonXAxis.ForeColor = System.Drawing.Color.White;
            this.buttonXAxis.Location = new System.Drawing.Point(363, 49);
            this.buttonXAxis.Name = "buttonXAxis";
            this.buttonXAxis.Size = new System.Drawing.Size(83, 31);
            this.buttonXAxis.TabIndex = 4;
            this.buttonXAxis.Text = "Set";
            this.buttonXAxis.UseVisualStyleBackColor = false;
            this.buttonXAxis.Click += new System.EventHandler(this.buttonXAxis_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 120);
            this.label1.TabIndex = 19;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // UserControlMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckBoxYAxis);
            this.Controls.Add(this.CheckBoxXAxis);
            this.Controls.Add(this.buttonXAxis);
            this.Controls.Add(this.textBoxYMultiplier);
            this.Controls.Add(this.TextBoxXMultiplier);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UserControlMainPage";
            this.Size = new System.Drawing.Size(544, 310);
            this.Load += new System.EventHandler(this.UserControlMainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox CheckBoxYAxis;
        private System.Windows.Forms.TextBox TextBoxXMultiplier;
        private System.Windows.Forms.TextBox textBoxYMultiplier;
        private System.Windows.Forms.Button buttonXAxis;
        private System.Windows.Forms.CheckBox CheckBoxXAxis;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}
